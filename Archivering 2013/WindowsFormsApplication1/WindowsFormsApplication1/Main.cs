using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        private int examenAantal = 0;
        private int[] kerntaakAantal = new int[10];
        private int huidigExamen = 0;
        private string[] savedStrings = new string[14];
        private string[] columnNames = { "Crebocode", "Kwalificatie", "Uitstroom", "Opleidingsnaam", "Niveau", "Leerroute", "Kenniscentrum", "Cohort", "KD Versie", "Examenprofiel", "Examenplan", "Portefeuillehouder", "Aanspreekpunt", "Manager" };
        private Boolean aanpassing = false;
        
        public Main()
        {
            InitializeComponent();
            examenPlus();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.examens' table. You can move, or remove it, as needed.
            this.overzichtTableAdapter.Fill(this.databaseDataSet.overzicht);
            this.examensTableAdapter.Fill(this.databaseDataSet.examens);
            this.kerntakenTableAdapter.Fill(this.databaseDataSet.kerntaken);

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int rowCount = dataGridView1.RowCount;
            int columnCount = gecontroleerdDataGridViewTextBoxColumn.Index;

            //loop door elke row
            for (int i = 0; i < rowCount; i++)
            {
                //als de value in de laatse kolom(gecontroleerd) 0 is kleur dan elke cel groen..
                if (dataGridView1.Rows[i].Cells[columnCount].Value != null && dataGridView1.Rows[i].Cells[columnCount].Value.Equals(1))
                {
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        cell.Style.BackColor = Color.YellowGreen;
                    }
                }
                else
                {
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        cell.Style.BackColor = Color.Tomato;
                    }
                }
            }
        }

        private void updateDatabase_Change(object sender, DataGridViewCellEventArgs e)
        {
            updateDatabase();
        }

        private void showContextMenuStrip(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            dataGridView1.ClearSelection();
            dataGridView1.Rows[index].Selected = true;
            
            e.ContextMenuStrip = contextMenuStrip1;
        }

        private void gecontroleerd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                int column = gecontroleerdDataGridViewTextBoxColumn.Index;

                dataGridView1.Rows[rowIndex].Cells[column].Value = 1;
                updateDatabase();
            }
            else
            {
                MessageBox.Show("Er kan maar één rij worden geselecteerd");
            }
        }

        private void niet_Gecontroleerd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                int column = gecontroleerdDataGridViewTextBoxColumn.Index;

                dataGridView1.Rows[rowIndex].Cells[column].Value = 0;
                updateDatabase();
            }
            else
            {
                MessageBox.Show("Er kan maar één rij worden geselecteerd");
            }
        }

        private void aanpassen_Click(object sender, EventArgs e)
        {
            clearForm(tabPage1);

            if (dataGridView1.SelectedRows.Count == 1)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                OpleidingBox.Text = dataGridView1.Rows[rowIndex].Cells[opleidingDataGridViewTextBoxColumn.Index].Value.ToString();
                CreboBox.Text = dataGridView1.Rows[rowIndex].Cells[creboDataGridViewTextBoxColumn.Index].Value.ToString();
                KwalificatieBox.Text = dataGridView1.Rows[rowIndex].Cells[kwalificatieDataGridViewTextBoxColumn.Index].Value.ToString();
                UitstroomBox.Text = dataGridView1.Rows[rowIndex].Cells[uitstroomDataGridViewTextBoxColumn.Index].Value.ToString();
                NiveauBox.Text = dataGridView1.Rows[rowIndex].Cells[niveauDataGridViewTextBoxColumn.Index].Value.ToString();
                LeerrouteBox.Text = dataGridView1.Rows[rowIndex].Cells[leerrouteDataGridViewTextBoxColumn.Index].Value.ToString();
                KenniscentrumBox.Text = dataGridView1.Rows[rowIndex].Cells[kenniscentrumDataGridViewTextBoxColumn.Index].Value.ToString();
                CohortBox.Text = dataGridView1.Rows[rowIndex].Cells[cohortDataGridViewTextBoxColumn.Index].Value.ToString();
                KdVersieBox.Text = dataGridView1.Rows[rowIndex].Cells[kdVersieDataGridViewTextBoxColumn.Index].Value.ToString();
                ExamenProfielBox.Text = dataGridView1.Rows[rowIndex].Cells[examenprofielDataGridViewTextBoxColumn.Index].Value.ToString();               
                PortHouderBox.Text = dataGridView1.Rows[rowIndex].Cells[portefeuillehouderDataGridViewTextBoxColumn.Index].Value.ToString();
                AanspreekBox.Text = dataGridView1.Rows[rowIndex].Cells[aanspreekpuntDataGridViewTextBoxColumn.Index].Value.ToString();
                ManagerBox.Text = dataGridView1.Rows[rowIndex].Cells[managerDataGridViewTextBoxColumn.Index].Value.ToString();

                int i = 0;

                        foreach (DataGridViewRow examenRow in dataGridView2.Rows)
                        {
                            if (Convert.ToInt32(examenRow.Cells[opleidingidDataGridViewTextBoxColumn.Index].Value) == Convert.ToInt32(dataGridView1.CurrentRow.Cells[idDataGridViewTextBoxColumn.Index].Value))
                            {
                                if (i >= 1)
                                {
                                    examenPlus();
                                }

                                
                                ConstructeurBox[examenAantal - 1].Text = examenRow.Cells[examenconstructeurDataGridViewTextBoxColumn.Index].Value.ToString();
                                PeriodeAfnameBox[examenAantal - 1].Text = examenRow.Cells[examenstartperiodeDataGridViewTextBoxColumn.Index].Value.ToString();
                                ePeriodeAfnameBox[examenAantal - 1].Text = examenRow.Cells[exameneindperiodeDataGridViewTextBoxColumn.Index].Value.ToString();
                                LocatieBox[examenAantal - 1].Text = examenRow.Cells[examenlocatieDataGridViewTextBoxColumn.Index].Value.ToString();
                                NaamOpdrachtBox[examenAantal - 1].Text = examenRow.Cells[examennaamopdrachtDataGridViewTextBoxColumn.Index].Value.ToString();
                                StatusOpdrachtBox[examenAantal - 1].Text = examenRow.Cells[examenstatusopdrachtDataGridViewTextBoxColumn.Index].Value.ToString();
                                BeoordelingBox[examenAantal - 1].Text = examenRow.Cells[examenbeoordelingDataGridViewTextBoxColumn.Index].Value.ToString();
                                OpmerkingBox[examenAantal - 1].Text = examenRow.Cells[examenopmerkingDataGridViewTextBoxColumn.Index].Value.ToString();

                                i++;
                                int j = 0;

                                foreach (DataGridViewRow kerntaakRow in dataGridView3.Rows)
                                {
                                    if (Convert.ToInt32(kerntaakRow.Cells[ktexamenidDataGridViewTextBoxColumn.Index].Value) == Convert.ToInt32(examenRow.Cells[examenidDataGridViewTextBoxColumn.Index].Value))
                                    {
                                        if (j >= 1)
                                        {
                                            kerntaakPlus(examenAantal - 1);
                                        }

                                        KerntakenBox[examenAantal - 1, j].Text = kerntaakRow.Cells[kerntaaknaamDataGridViewTextBoxColumn.Index].Value.ToString();
                                        KerntaakNrBox[examenAantal - 1, j].Text = kerntaakRow.Cells[kerntaaknummerDataGridViewTextBoxColumn.Index].Value.ToString();
                                        WerkprocessenBox[examenAantal - 1, j].Text = kerntaakRow.Cells[kerntaakwerkprocessenDataGridViewTextBoxColumn.Index].Value.ToString();
                                        j++;
                                    }
                                }
                            }
                        }
                    
                

                OpslaanButton.Click -= new System.EventHandler(buttonOpslaan_Click);
                OpslaanButton.Click += new System.EventHandler(aanpassenOpslaan);
                OpslaanPlusButton.Visible = false;
                ExamPlusButton.Visible = false;
                ExamMinButton.Visible = false;

                tabControl1.SelectTab("tabPage1");
                aanpassing = true;
            }
            else
            {
                MessageBox.Show("Er kan maar één rij worden geselecteerd");
            }
        }

        private void aanpassenOpslaan(object sender, EventArgs e)
        {
            if (!validateForm())
            {
                return;
            }
            
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[rowIndex].Cells[opleidingDataGridViewTextBoxColumn.Index].Value = OpleidingBox.Text;
            dataGridView1.Rows[rowIndex].Cells[creboDataGridViewTextBoxColumn.Index].Value = CreboBox.Text;
            dataGridView1.Rows[rowIndex].Cells[kwalificatieDataGridViewTextBoxColumn.Index].Value = KwalificatieBox.Text;
            dataGridView1.Rows[rowIndex].Cells[uitstroomDataGridViewTextBoxColumn.Index].Value = UitstroomBox.Text;
            dataGridView1.Rows[rowIndex].Cells[niveauDataGridViewTextBoxColumn.Index].Value = NiveauBox.Text;
            dataGridView1.Rows[rowIndex].Cells[leerrouteDataGridViewTextBoxColumn.Index].Value = LeerrouteBox.Text;
            dataGridView1.Rows[rowIndex].Cells[kenniscentrumDataGridViewTextBoxColumn.Index].Value = KenniscentrumBox.Text;
            dataGridView1.Rows[rowIndex].Cells[cohortDataGridViewTextBoxColumn.Index].Value = CohortBox.Text;
            dataGridView1.Rows[rowIndex].Cells[kdVersieDataGridViewTextBoxColumn.Index].Value = KdVersieBox.Text;
            dataGridView1.Rows[rowIndex].Cells[examenprofielDataGridViewTextBoxColumn.Index].Value = ExamenProfielBox.Text;
            dataGridView1.Rows[rowIndex].Cells[portefeuillehouderDataGridViewTextBoxColumn.Index].Value = PortHouderBox.Text;
            dataGridView1.Rows[rowIndex].Cells[aanspreekpuntDataGridViewTextBoxColumn.Index].Value = AanspreekBox.Text;
            dataGridView1.Rows[rowIndex].Cells[managerDataGridViewTextBoxColumn.Index].Value = ManagerBox.Text;

            int i = 0;
            foreach (DataGridViewRow examenRow in dataGridView2.Rows)
            {
                if (Convert.ToInt32(examenRow.Cells[opleidingidDataGridViewTextBoxColumn.Index].Value) == Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value))
                {
                    examenRow.Cells[examennummerDataGridViewTextBoxColumn.Index].Value = examNR(i);
                    examenRow.Cells[examenconstructeurDataGridViewTextBoxColumn.Index].Value = ConstructeurBox[i].Text;
                    examenRow.Cells[examenstartperiodeDataGridViewTextBoxColumn.Index].Value = PeriodeAfnameBox[i].Text;
                    examenRow.Cells[exameneindperiodeDataGridViewTextBoxColumn.Index].Value = ePeriodeAfnameBox[i].Text;
                    examenRow.Cells[examenlocatieDataGridViewTextBoxColumn.Index].Value = LocatieBox[i].Text;
                    examenRow.Cells[examennaamopdrachtDataGridViewTextBoxColumn.Index].Value = NaamOpdrachtBox[i].Text;
                    examenRow.Cells[examenstatusopdrachtDataGridViewTextBoxColumn.Index].Value = StatusOpdrachtBox[i].Text;
                    examenRow.Cells[examenbeoordelingDataGridViewTextBoxColumn.Index].Value = BeoordelingBox[i].Text;
                    examenRow.Cells[examenopmerkingDataGridViewTextBoxColumn.Index].Value = OpmerkingBox[i].Text;
                    
                    int j = 0;
                    foreach (DataGridViewRow kerntaakRow in dataGridView3.Rows)
                    {
                        if (Convert.ToInt32(kerntaakRow.Cells[ktexamenidDataGridViewTextBoxColumn.Index].Value) == Convert.ToInt32(examenRow.Cells[0].Value))
                        {
                            kerntaakRow.Cells[kerntaaknaamDataGridViewTextBoxColumn.Index].Value = KerntakenBox[i, j].Text;
                            kerntaakRow.Cells[kerntaaknummerDataGridViewTextBoxColumn.Index].Value = KerntaakNrBox[i, j].Text;
                            kerntaakRow.Cells[kerntaakwerkprocessenDataGridViewTextBoxColumn.Index].Value = WerkprocessenBox[i, j].Text;
                            j++;
                        }
                    }
                    i++;
                }
            }
            

            updateDatabase();

            OpslaanButton.Click += new System.EventHandler(buttonOpslaan_Click);
            OpslaanButton.Click -= new System.EventHandler(aanpassenOpslaan);
            OpslaanPlusButton.Visible = true;
            ExamPlusButton.Visible = true;
            ExamMinButton.Visible = true;
            clearForm(tabPage1);
            tabControl1.SelectTab("tabPage2");
            aanpassing = false;
        }

        private void buttonOpslaan_Click(object sender, EventArgs e)
        {
            if (!validateForm())
            {
                return;
            }

            //overzicht tabel
            DatabaseDataSet.overzichtRow overzichtRow = databaseDataSet.overzicht.NewoverzichtRow();
            String opleiding = OpleidingBox.Text;
            String crebo = CreboBox.Text;
            String kwalificatie = KwalificatieBox.Text;
            String uitstroom = UitstroomBox.Text;
            String niveau = NiveauBox.Text;
            String leerroute = LeerrouteBox.Text;
            String kenniscentrum = KenniscentrumBox.Text;
            String cohort = CohortBox.Text;
            String kdversie = KdVersieBox.Text;
            String examenprofiel = ExamenProfielBox.Text;
            String portefeuillehouder = PortHouderBox.Text;
            String aanspreekpunt = AanspreekBox.Text;
            String manager = ManagerBox.Text;

            overzichtRow.opleiding = opleiding;
            overzichtRow.crebo = crebo;
            overzichtRow.kwalificatie = kwalificatie;
            overzichtRow.uitstroom = uitstroom;
            overzichtRow.niveau = niveau;
            overzichtRow.leerroute = leerroute;
            overzichtRow.kenniscentrum = kenniscentrum;
            overzichtRow.cohort = cohort;
            overzichtRow.kd_versie = kdversie;
            overzichtRow.examenprofiel = examenprofiel;
            overzichtRow.portefeuillehouder = portefeuillehouder;
            overzichtRow.aanspreekpunt = aanspreekpunt;
            overzichtRow.manager = manager;

            //voegt overzicht row toe nadat de examens gemaakt zijn
            databaseDataSet.overzicht.AddoverzichtRow(overzichtRow);

            updateDatabase();

            this.overzichtTableAdapter.Fill(this.databaseDataSet.overzicht);

            //examentabel
            for (int i = 0; i < examenAantal; i++)
            {
                DatabaseDataSet.examensRow examenRow = databaseDataSet.examens.NewexamensRow();
                examenRow.examen_vak = ExamenTitle[i].Text;
                examenRow.examen_nummer = examNR(i);
                examenRow.examen_constructeur = ConstructeurBox[i].Text;
                examenRow.examen_start_periode = PeriodeAfnameBox[i].Text;
                examenRow.examen_eind_periode = ePeriodeAfnameBox[i].Text;
                examenRow.examen_locatie = LocatieBox[i].Text;
                examenRow.examen_naam_opdracht = NaamOpdrachtBox[i].Text;
                examenRow.examen_status_opdracht = StatusOpdrachtBox[i].Text;
                examenRow.examen_beoordeling = BeoordelingBox[i].Text;
                examenRow.examen_opmerking = OpmerkingBox[i].Text;
                examenRow.opleiding_id = getInt(databaseDataSet.overzicht.Rows[databaseDataSet.overzicht.Rows.Count - 1][0]);

                databaseDataSet.examens.AddexamensRow(examenRow);

                //update database etc
                updateDatabase();
                this.examensTableAdapter.Fill(this.databaseDataSet.examens);

                for (int j = 0; j < kerntaakAantal[i]; j++)
                {
                    DatabaseDataSet.kerntakenRow kerntaakRow = databaseDataSet.kerntaken.NewkerntakenRow();
                    kerntaakRow.kerntaak_naam = KerntakenBox[i, j].Text;
                    kerntaakRow.kerntaak_nummer = KerntaakNrBox[i, j].Text;
                    kerntaakRow.kerntaak_werkprocessen = WerkprocessenBox[i, j].Text;
                    kerntaakRow.examen_id = getInt(databaseDataSet.examens.Rows[databaseDataSet.examens.Rows.Count - 1][0]);

                    databaseDataSet.kerntaken.AddkerntakenRow(kerntaakRow);
                }                
            }
            updateDatabase();
            this.kerntakenTableAdapter.Fill(this.databaseDataSet.kerntaken);
            
            if (sender.Equals(OpslaanButton))
            {
                tabControl1.SelectTab("tabPage2");
            }
            // Het form wordt gereset naar lege staat.
            clearForm(tabPage1);
        }

        private void exporteren_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Worksheets|*.xls";
            sfd.ShowDialog();

            SaveExcel(sfd.FileName);
        }

        private void updateDatabase()
        {
            try
            {
                this.overzichtBindingSource.EndEdit();
                this.examensBindingSource.EndEdit();
                this.kerntakenBindingSource.EndEdit();
                this.overzichtTableAdapter.Update(this.databaseDataSet.overzicht);
                this.examensTableAdapter.Update(this.databaseDataSet.examens);
                this.kerntakenTableAdapter.Update(this.databaseDataSet.kerntaken);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Het is niet gelukt om de database te updaten. Uw gegevens zijn niet opgeslagen.");
            }
        }

        public void SaveExcel(string Path)
        {
            try
            {
                //open een ExcelStatus form(progress bar)
                ExcelStatus es = new ExcelStatus();
                es.progressBar1.Maximum = dataGridView1.Rows.Count;
                es.progressBar1.Minimum = 0;
                es.Show();

                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet workSheetOpleidingen;
                Excel.Worksheet workSheetExamens;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkBook.Worksheets.get_Item(3).Delete(); //verwijderd "Blad3"

                workSheetOpleidingen = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                workSheetOpleidingen.Name = "Opleidingen";
                workSheetExamens = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(2);
                workSheetExamens.Name = "Examens";

                //Excel.Range[] fromHyperlink = new Excel.Range[dataGridView1.Rows.Count];

                /* OPLEIDINGEN WORKSHEET */
                //voeg de opleiding kolommen toe
                int row = 1;
                for (int i = 1; i < dataGridView1.Columns.Count; i++)
                {
                    if (dataGridView1.Columns[i].Visible == true)
                    {
                        workSheetOpleidingen.Cells[1, i] = dataGridView1.Columns[i].HeaderText;
                    }
                }
                row++;
                //nu wordt elke opleiding toegevoegd
                foreach (DataGridViewRow itemRow in dataGridView1.Rows)
                {
                    for (int column = 1; column < dataGridView1.Columns.Count; column++)
                    {
                        if (itemRow.Cells[column].Visible == true)
                        {
                            workSheetOpleidingen.Cells[row, column] = itemRow.Cells[column].Value;
                            //hyperlink op crebo
                            if (column == 1)
                            {
                                Excel.Range cell = (Excel.Range)workSheetOpleidingen.Cells[row, column];
                                workSheetOpleidingen.Hyperlinks.Add(cell, string.Empty, "Examens!A2", "Spring naar de examens van deze opleiding.", string.Empty);
                            }
                        }

                    }
                    row++;
                    es.progressBar1.Value++;
                }
                //autofit alle cellen
                workSheetOpleidingen.Cells.Columns.AutoFit();

                //pak de gebruikte velden en vervolgens de gebruike rows
                Excel.Range usedRange = workSheetOpleidingen.UsedRange;
                Excel.Range rows = usedRange.Rows;

                //opmaak van de cellen
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[gecontroleerdDataGridViewTextBoxColumn.Index].Value != null && dataGridView1.Rows[i].Cells[gecontroleerdDataGridViewTextBoxColumn.Index].Value.Equals(1))
                    {
                        rows[i + 2].Interior.Color = Color.YellowGreen;
                    }
                    else
                    {
                        rows[i + 2].Interior.Color = Color.Tomato;
                    }
                    rows.Borders.LineStyle = BorderStyle.FixedSingle;
                    rows.Borders.Weight = 2;
                }

                /* EXAMENS WORKSHEET */
                //kolommen
                String[] kolommen = { "Crebo", "Opleiding", "Cohort" };
                for (int i = 1; i <= kolommen.Length; i++)
                {
                    workSheetExamens.Cells[1, i] = kolommen[i - 1];
                }

                int r = 2; // 2 omdat 1 de kolommen zijn
                int c = 1;
                int hyperlink = 1;
                //examens
                foreach (DataGridViewRow overzichtRow in dataGridView1.Rows)
                {
                    for (int i = 1; i < dataGridView1.Columns.Count; i++)
                    {
                        //voeg alleen het crebo,opleiding en cohort toe.
                        if (overzichtRow.Cells[i].OwningColumn.Index == creboDataGridViewTextBoxColumn.Index ||
                            overzichtRow.Cells[i].OwningColumn.Index == opleidingDataGridViewTextBoxColumn.Index ||
                            overzichtRow.Cells[i].OwningColumn.Index == cohortDataGridViewTextBoxColumn.Index)
                        {
                            workSheetExamens.Cells[r, c] = overzichtRow.Cells[i].Value;
                            workSheetExamens.Cells[r, c].Interior.Color = Color.YellowGreen;

                            //hyperlink target
                            if (i == 1)
                            {
                                workSheetOpleidingen.Hyperlinks.get_Item(hyperlink).SubAddress = "Examens!" + workSheetExamens.Cells[r, c].Address;
                                hyperlink++;
                            }

                            c++;
                        }
                    }
                    r++;

                    c = 1;
                    //nu moeten de examens een voor een toegevoegd worden
                    foreach (DatabaseDataSet.examensRow examenRow in databaseDataSet.examens)
                    {
                        int opleiding_id = (int)overzichtRow.Cells[idDataGridViewTextBoxColumn.Index].Value;
                        if (examenRow.opleiding_id == opleiding_id)
                        {
                            //voeg examen toe
                            workSheetExamens.Cells[r, c] = examenRow.examen_vak;
                            workSheetExamens.Cells[r, c].Interior.Color = Color.LightBlue;                        

                            c++; // voor de kerntaken

                            int examen_id = examenRow.examen_id;
                            foreach (DatabaseDataSet.kerntakenRow kerntaakRow in databaseDataSet.kerntaken)
                            {
                                //voeg kerntaak toe
                                if (kerntaakRow.examen_id == examen_id)
                                {
                                    workSheetExamens.Cells[r, c] = "KT " + kerntaakRow.kerntaak_nummer + ": " + kerntaakRow.kerntaak_naam;
                                    workSheetExamens.Cells[r, c].Interior.Color = Color.LightPink;

                                    if (kerntaakRow.kerntaak_werkprocessen != "")
                                    {
                                        String[] werkprocessen = kerntaakRow.kerntaak_werkprocessen.Split(';');
                                        //werkprocessen
                                        c++; // voor de wp

                                        foreach (String wp in werkprocessen)
                                        {
                                            if (!wp.Equals(" ") || !wp.Equals(""))
                                            {
                                                workSheetExamens.Cells[r, c] = "WP: " + wp;
                                                workSheetExamens.Cells[r, c].Interior.Color = Color.LightGray;
                                                r++;
                                            }
                                        }
                                    }
                                }
                                c = 2;// voor de volgende kerntaak
                            }
                            c = 1; // voor een nieuw examen
                            r++;
                        }
                    }
                }

                //autofit alle cellen
                workSheetExamens.Cells.Columns.AutoFit();

                try
                {
                    xlWorkBook.SaveAs(Path, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                }
                catch
                {
                    MessageBox.Show("Worksheet kon niet worden opgeslagen.");
                }
                finally
                {
                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();
                }

                es.Hide();
                es.Close();
                es.Dispose();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(workSheetOpleidingen);
                workSheetOpleidingen = null;
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);
                xlWorkBook = null;
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
                xlApp = null;

                GC.Collect();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void rowRemovedHandler(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            updateDatabase();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void PrevExamButton_Click(object sender, EventArgs e)
        {
            this.PrevExam();
        }

        private void nextExamButton_Click(object sender, EventArgs e)
        {
            this.NextExam();
        }

        private void ExamPlusButton_Click(object sender, EventArgs e)
        {
            this.examenPlus();
        }

        private void ExamMinButton_Click(object sender, EventArgs e)
        {
            this.examenMin();
        }

        private void KerntaakPlusButton_Click(object sender, EventArgs e)
        {
            int ex = getInt((sender as Button).Tag);
            this.kerntaakPlus(ex);
        }

        private void KerntaakMinButton_Click(object sender, EventArgs e)
        {
            int ex = getInt((sender as Button).Tag);
            this.kerntaakMin(ex);
        }

        private void resetExams()
        {
            int aantal = examenAantal;
            for (int i = 0; i < aantal; i++)
            {
                this.examenMin();
            }            
        }

        private void resetKerntaken()
        {
            for (int i = 0; i < kerntaakAantal.Length; i++)
            {
                int aantal = kerntaakAantal[i];
                for (int j = 0; j < aantal; j++)
                {
                    this.kerntaakMin(i);
                }
            }

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //confirm
            if (MessageBox.Show("Weet u zeker de geselecteerde item(s) te verwijderen? U zult hierdoor al uw gegevens kwijtraken.", "Verwijderen", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            //rows verwijderen dmv rows geselecteerd
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                deleteExamens(row.Index);

                dataGridView1.Rows.RemoveAt(row.Index);
            }

            //rows verwijderen dmv cellen geselecteerd
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                deleteExamens(cell.RowIndex);

                dataGridView1.Rows.RemoveAt(cell.RowIndex);
            }

            updateDatabase();
        }

        //zorgt ervoor dat de "DELETE" knop niet werkt..
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void deleteExamens(int rowIndex)
        {
            int id = (int)dataGridView1.Rows[rowIndex].Cells[0].Value;

                for (int i = dataGridView2.Rows.Count - 1; i >= 0; i--)
                {
                   
                    if (Convert.ToInt32(dataGridView2.Rows[i].Cells[opleidingidDataGridViewTextBoxColumn.Index].Value) == id && Convert.ToInt32(dataGridView2.Rows[i].Cells[opleidingidDataGridViewTextBoxColumn.Index].Value) != 0)
                    {
                        deleteKerntaken(i);

                        dataGridView2.Rows.RemoveAt(i);
                    }
                }
        }

        private void deleteKerntaken(int rowIndex)
        {
            int id = (int)dataGridView2.Rows[rowIndex].Cells[0].Value;

            for (int i = dataGridView3.Rows.Count - 1; i >= 0; i--)
            {
                if(Convert.ToInt32(dataGridView3.Rows[i].Cells[ktexamenidDataGridViewTextBoxColumn.Index].Value) == id && Convert.ToInt32(dataGridView3.Rows[i].Cells[examenidDataGridViewTextBoxColumn.Index].Value) != 0)
                {
                    databaseDataSet.kerntaken.Rows.RemoveAt(i);
                }
            }
        }

        private int getInt(Object value)
        {
            int newValue;
            int.TryParse(value.ToString(), out newValue);
            return newValue;
        }

        private void clearForm(Control control)
        {
            if (emptyCheckBox.Checked == true)
                return;

            foreach (Control c in control.Controls) //Loopt alle controls door die in een formelement zitten.
            {
                if (c.GetType() == typeof(TextBox)) //Als het element een textbox is wordt deze leeg gemaakt
                {
                    ((TextBox)c).Clear();
                }
                else if (c.GetType() == typeof(ComboBox)) //Als het element een combobox is wordt deze teruggezet op het lege veld en text leeggehaald mocht dit ingevoerd kunnen worden.
                {
                    ((ComboBox)c).SelectedIndex = -1;
                    if (((ComboBox)c).DropDownStyle == System.Windows.Forms.ComboBoxStyle.DropDown)
                    {
                        ((ComboBox)c).Text = "";
                    }
                }
                else if (c.GetType() == typeof(RichTextBox))
                {
                    ((RichTextBox)c).Clear();
                }

                if (c.HasChildren) // Als een element zelf elementen bevat wordt deze functie nog een keer uitgevoerd voor dat element
                {
                    clearForm(c);
                }
            }
            resetKerntaken();
            resetExams();
        }

        private void tab1_selecting(object sender, System.Windows.Forms.TabControlCancelEventArgs e)
        {
            if (tabControl1.SelectedIndex == 0 && aanpassing == true)
            {
                OpslaanButton.Click += new System.EventHandler(buttonOpslaan_Click);
                OpslaanButton.Click -= new System.EventHandler(aanpassenOpslaan);
                OpslaanPlusButton.Visible = true;
                ExamPlusButton.Visible = true;
                ExamMinButton.Visible = true;
                clearForm(tabPage1);
                aanpassing = false;
            }
        }

        private Boolean validateForm()
        {
            foreach (Control c in tabPage1.Controls)
            {
                if (c.GetType() == typeof(TextBox) && ((TextBox)c).Text == "") //Als het element een textbox is wordt deze leeg gemaakt
                {
                    MessageBox.Show("U heeft niet alle verplichte velden ingevuld. Het formulier is niet opgeslagen.\nControleer alle velden.");
                    return false;
                }
                else if (c.GetType() == typeof(ComboBox) && ((ComboBox)c).Text == "")
                {
                    MessageBox.Show("U heeft niet alle verplichte velden ingevuld. Het formulier is niet opgeslagen.\nControleer alle velden.");
                    return false;
                }
            }

            for (int i = 0; i < examenAantal; i++)
            {
                foreach (Control c in ExamenBlok[i].Controls)
                {
                    if (c.GetType() == typeof(TextBox) && ((TextBox)c).Text == "") //Als het element een textbox is wordt deze leeg gemaakt
                    {
                        MessageBox.Show("U heeft niet alle verplichte velden ingevuld. Het formulier is niet opgeslagen.\nControleer alle examenvelden.");
                        return false;
                    }
                    else if (c.GetType() == typeof(ComboBox) && ((ComboBox)c).Text == "")
                    {
                        MessageBox.Show("U heeft niet alle verplichte velden ingevuld. Het formulier is niet opgeslagen.\nControleer alle examenvelden.");
                        return false;
                    }
                }
                for (int j = 0; j < kerntaakAantal[i]; j++)
                {
                    foreach (Control c in KerntaakBlok[i, j].Controls)
                    {
                        if (c.GetType() == typeof(TextBox) && ((TextBox)c).Text == "")
                        {
                            MessageBox.Show("U heeft niet alle verplichte velden ingevuld. Het formulier is niet opgeslagen.\nControleer alle kerntaakvelden.");
                            return false;
                        }
                    }
                }
            }


            return true;
        }

        private void examenoverzichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Examenoverzicht scherm = new Examenoverzicht(dataGridView1.CurrentRow.Index,opleidingDataGridViewTextBoxColumn.Index,databaseDataSet);
           scherm.Show();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Examenoverzicht scherm = new Examenoverzicht(dataGridView1.CurrentRow.Index, opleidingDataGridViewTextBoxColumn.Index, databaseDataSet);
            scherm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string examNR(int i)
        {
            string nummer;

            string crebo = CreboBox.Text;
            string cohort = CohortBox.Text;

            string kerntaken = "KT";
            
            for (int j = 0; j < kerntaakAantal[i]; j++)
            {
                if (KerntaakNrBox[i, j].Text != "")
                {
                    kerntaken += KerntaakNrBox[i, j].Text;
                    kerntaken += "(";
                    if (WerkprocessenBox[i, j].Text != "")
                    {
                        kerntaken += WerkprocessenBox[i, j].Text.Replace(";", ",");
                    }
                    kerntaken += ")";
                }
                
            }

            nummer = crebo + "_" + cohort + "_" + kerntaken;
            
            return nummer;
        }

        private void gegevensImporterenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Selecteer een bestand om te importeren";
            fileDialog.Filter = "Database gegevens|*.xml";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream myFileStream = new FileStream(fileDialog.FileName, FileMode.Open);
                System.Xml.XmlTextReader myXmlReader = new System.Xml.XmlTextReader(myFileStream);
                databaseDataSet.Clear();
                databaseDataSet.ReadXml(myXmlReader);
                myXmlReader.Close();

                updateDatabase();
            }
        }

        private void gegevensExporterenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Database gegevens|*.xml";
                saveDialog.FileName = "Database gegevens.xml";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream myFileStream = new FileStream(saveDialog.FileName, FileMode.Create);
                    System.Xml.XmlTextWriter myXmlWriter = new System.Xml.XmlTextWriter(myFileStream, System.Text.Encoding.Unicode);
                    databaseDataSet.WriteXml(myXmlWriter);
                    myXmlWriter.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }   
}
