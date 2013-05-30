using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        private int examenAantal = 0;
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
            this.examensTableAdapter.Fill(this.databaseDataSet.examens);
            this.overzichtTableAdapter.Fill(this.databaseDataSet.overzicht);
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
            dataGridView1.ClearSelection();
            dataGridView1.Rows[e.RowIndex].Selected = true;
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
            resetExams();

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
                ExamenPlanBox.Text = dataGridView1.Rows[rowIndex].Cells[explanDataGridViewTextBoxColumn.Index].Value.ToString();
                PortHouderBox.Text = dataGridView1.Rows[rowIndex].Cells[portefeuillehouderDataGridViewTextBoxColumn.Index].Value.ToString();
                AanspreekBox.Text = dataGridView1.Rows[rowIndex].Cells[aanspreekpuntDataGridViewTextBoxColumn.Index].Value.ToString();
                ManagerBox.Text = dataGridView1.Rows[rowIndex].Cells[managerDataGridViewTextBoxColumn.Index].Value.ToString();

                //examen ids
                int[] examen_ids = new int[10];
                examen_ids[0] = getInt(dataGridView1.Rows[rowIndex].Cells[examen1DataGridViewTextBoxColumn.Index].Value);
                examen_ids[1] = getInt(dataGridView1.Rows[rowIndex].Cells[examen2DataGridViewTextBoxColumn.Index].Value);
                examen_ids[2] = getInt(dataGridView1.Rows[rowIndex].Cells[examen3DataGridViewTextBoxColumn.Index].Value);
                examen_ids[3] = getInt(dataGridView1.Rows[rowIndex].Cells[examen4DataGridViewTextBoxColumn.Index].Value);
                examen_ids[4] = getInt(dataGridView1.Rows[rowIndex].Cells[examen5DataGridViewTextBoxColumn.Index].Value);
                examen_ids[5] = getInt(dataGridView1.Rows[rowIndex].Cells[examen6DataGridViewTextBoxColumn.Index].Value);
                examen_ids[6] = getInt(dataGridView1.Rows[rowIndex].Cells[examen7DataGridViewTextBoxColumn.Index].Value);
                examen_ids[7] = getInt(dataGridView1.Rows[rowIndex].Cells[examen8DataGridViewTextBoxColumn.Index].Value);
                examen_ids[8] = getInt(dataGridView1.Rows[rowIndex].Cells[examen9DataGridViewTextBoxColumn.Index].Value);
                examen_ids[9] = getInt(dataGridView1.Rows[rowIndex].Cells[examen10DataGridViewTextBoxColumn.Index].Value);

                for (int i = 0; i < examen_ids.Count(); i++)
                {
                    if (examen_ids[i] != 0)
                    {
                        if (i == 1 || i > 1)
                        {                            
                            examenPlus();
                        }

                        int[] kerntaken_ids = new int[6];

                        foreach (DataGridViewRow examenRow in dataGridView2.Rows)
                        {
                            if (Convert.ToInt32(examenRow.Cells[examenidDataGridViewTextBoxColumn.Index].Value) == examen_ids[i])
                            {
                                ExamenBox[i].Text = examenRow.Cells[examenvakDataGridViewTextBoxColumn.Index].Value.ToString();
                                ExamenNummerBox[i].Text = examenRow.Cells[examennummerDataGridViewTextBoxColumn.Index].Value.ToString();
                                ConstructeurBox[i].Text = examenRow.Cells[examenconstructeurDataGridViewTextBoxColumn.Index].Value.ToString();
                                PeriodeAfnameBox[i].Text = examenRow.Cells[examenperiodeafnameDataGridViewTextBoxColumn.Index].Value.ToString();
                                LocatieBox[i].Text = examenRow.Cells[examenlocatieDataGridViewTextBoxColumn.Index].Value.ToString();
                                NaamOpdrachtBox[i].Text = examenRow.Cells[examennaamopdrachtDataGridViewTextBoxColumn.Index].Value.ToString();
                                StatusOpdrachtBox[i].Text = examenRow.Cells[examenstatusopdrachtDataGridViewTextBoxColumn.Index].Value.ToString();
                                OpmerkingBox[i].Text = examenRow.Cells[examenOpmerkingenDataGridViewTextBoxColumn.Index].Value.ToString();

                                kerntaken_ids[0] = getInt(examenRow.Cells[examenkerntaak1DataGridViewTextBoxColumn.Index].Value);
                                kerntaken_ids[1] = getInt(examenRow.Cells[examenkerntaak2DataGridViewTextBoxColumn.Index].Value);
                                kerntaken_ids[2] = getInt(examenRow.Cells[examenkerntaak3DataGridViewTextBoxColumn.Index].Value);
                                kerntaken_ids[3] = getInt(examenRow.Cells[examenkerntaak4DataGridViewTextBoxColumn.Index].Value);
                                kerntaken_ids[4] = getInt(examenRow.Cells[examenkerntaak5DataGridViewTextBoxColumn.Index].Value);
                                kerntaken_ids[5] = getInt(examenRow.Cells[examenkerntaak6DataGridViewTextBoxColumn.Index].Value);

                                for (int j = 0; j < kerntaken_ids.Count(); j++)
                                {
                                    if (kerntaken_ids[j] != 0)
                                    {
                                        foreach (DataGridViewRow kerntaakRow in dataGridView3.Rows)
                                        {
                                            if (Convert.ToInt32(kerntaakRow.Cells[kerntaakidDataGridViewTextBoxColumn.Index].Value) == kerntaken_ids[j])
                                            {
                                                KerntakenBox[i, j].Text = kerntaakRow.Cells[kerntaaknaamDataGridViewTextBoxColumn.Index].Value.ToString();
                                                KerntaakNrBox[i, j].Text = kerntaakRow.Cells[kerntaaknummerDataGridViewTextBoxColumn.Index].Value.ToString();
                                                WerkprocessenBox[i, j].Text = kerntaakRow.Cells[kerntaakwerkprocessenDataGridViewTextBoxColumn.Index].Value.ToString();
                                            }
                                        }
                                    }
                                }
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
            dataGridView1.Rows[rowIndex].Cells[explanDataGridViewTextBoxColumn.Index].Value = ExamenPlanBox.Text;
            dataGridView1.Rows[rowIndex].Cells[portefeuillehouderDataGridViewTextBoxColumn.Index].Value = PortHouderBox.Text;
            dataGridView1.Rows[rowIndex].Cells[aanspreekpuntDataGridViewTextBoxColumn.Index].Value = AanspreekBox.Text;
            dataGridView1.Rows[rowIndex].Cells[managerDataGridViewTextBoxColumn.Index].Value = ManagerBox.Text;

            //examen ids
            int[] examen_ids = new int[10];
            examen_ids[0] = getInt(dataGridView1.Rows[rowIndex].Cells[examen1DataGridViewTextBoxColumn.Index].Value);
            examen_ids[1] = getInt(dataGridView1.Rows[rowIndex].Cells[examen2DataGridViewTextBoxColumn.Index].Value);
            examen_ids[2] = getInt(dataGridView1.Rows[rowIndex].Cells[examen3DataGridViewTextBoxColumn.Index].Value);
            examen_ids[3] = getInt(dataGridView1.Rows[rowIndex].Cells[examen4DataGridViewTextBoxColumn.Index].Value);
            examen_ids[4] = getInt(dataGridView1.Rows[rowIndex].Cells[examen5DataGridViewTextBoxColumn.Index].Value);
            examen_ids[5] = getInt(dataGridView1.Rows[rowIndex].Cells[examen6DataGridViewTextBoxColumn.Index].Value);
            examen_ids[6] = getInt(dataGridView1.Rows[rowIndex].Cells[examen7DataGridViewTextBoxColumn.Index].Value);
            examen_ids[7] = getInt(dataGridView1.Rows[rowIndex].Cells[examen8DataGridViewTextBoxColumn.Index].Value);
            examen_ids[8] = getInt(dataGridView1.Rows[rowIndex].Cells[examen9DataGridViewTextBoxColumn.Index].Value);
            examen_ids[9] = getInt(dataGridView1.Rows[rowIndex].Cells[examen10DataGridViewTextBoxColumn.Index].Value);



            for (int i = 0; i < examen_ids.Count(); i++)
            {
                foreach (DataGridViewRow examenRow in dataGridView2.Rows)
                {
                    if (Convert.ToInt32(examenRow.Cells[examenidDataGridViewTextBoxColumn.Index].Value) == examen_ids[i])
                    {
                        examenRow.Cells[examenvakDataGridViewTextBoxColumn.Index].Value = ExamenBox[i].Text;
                        examenRow.Cells[examennummerDataGridViewTextBoxColumn.Index].Value = ExamenNummerBox[i].Text;
                        examenRow.Cells[examenconstructeurDataGridViewTextBoxColumn.Index].Value = ConstructeurBox[i].Text;
                        examenRow.Cells[examenperiodeafnameDataGridViewTextBoxColumn.Index].Value = PeriodeAfnameBox[i].Text;
                        examenRow.Cells[examenlocatieDataGridViewTextBoxColumn.Index].Value = LocatieBox[i].Text;
                        examenRow.Cells[examennaamopdrachtDataGridViewTextBoxColumn.Index].Value = NaamOpdrachtBox[i].Text;
                        examenRow.Cells[examenstatusopdrachtDataGridViewTextBoxColumn.Index].Value = StatusOpdrachtBox[i].Text;
                        examenRow.Cells[examenOpmerkingenDataGridViewTextBoxColumn.Index].Value = OpmerkingBox[i].Text;

                        int[] kerntaken_ids = new int[6];

                        kerntaken_ids[0] = getInt(examenRow.Cells[examenkerntaak1DataGridViewTextBoxColumn.Index].Value);
                        kerntaken_ids[1] = getInt(examenRow.Cells[examenkerntaak2DataGridViewTextBoxColumn.Index].Value);
                        kerntaken_ids[2] = getInt(examenRow.Cells[examenkerntaak3DataGridViewTextBoxColumn.Index].Value);
                        kerntaken_ids[3] = getInt(examenRow.Cells[examenkerntaak4DataGridViewTextBoxColumn.Index].Value);
                        kerntaken_ids[4] = getInt(examenRow.Cells[examenkerntaak5DataGridViewTextBoxColumn.Index].Value);
                        kerntaken_ids[5] = getInt(examenRow.Cells[examenkerntaak6DataGridViewTextBoxColumn.Index].Value);

                        for (int j = 0; j < kerntaken_ids.Count(); j++)
                        {
                            foreach (DataGridViewRow kerntaakRow in dataGridView3.Rows)
                            {
                                if (Convert.ToInt32(kerntaakRow.Cells[kerntaakidDataGridViewTextBoxColumn.Index].Value) == kerntaken_ids[j])
                                {
                                    kerntaakRow.Cells[kerntaaknaamDataGridViewTextBoxColumn.Index].Value = KerntakenBox[i, j].Text;
                                    kerntaakRow.Cells[kerntaaknummerDataGridViewTextBoxColumn.Index].Value = KerntaakNrBox[i, j].Text;
                                    kerntaakRow.Cells[kerntaakwerkprocessenDataGridViewTextBoxColumn.Index].Value = WerkprocessenBox[i, j].Text;
                                }
                            }
                        }
                    }
                }
            }

            updateDatabase();

            OpslaanButton.Click += new System.EventHandler(buttonOpslaan_Click);
            OpslaanButton.Click -= new System.EventHandler(aanpassenOpslaan);
            OpslaanPlusButton.Visible = true;
            ExamPlusButton.Visible = true;
            ExamMinButton.Visible = true;
            resetExams();
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
            String examenplan = ExamenPlanBox.Text;
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
            overzichtRow.explan = examenplan;
            overzichtRow.portefeuillehouder = portefeuillehouder;
            overzichtRow.aanspreekpunt = aanspreekpunt;
            overzichtRow.manager = manager;

            //examen id's array voor de overzichtRow
            int[] ids = new int[examenAantal];
            //kerntaken id's array voor de examenRow
            int[] ktids = new int[6];

            //examentabel
            for (int i = 0; i < examenAantal; i++)
            {
                DatabaseDataSet.examensRow examenRow = databaseDataSet.examens.NewexamensRow();
                examenRow.examen_vak = ExamenBox[i].Text;
                examenRow.examen_nummer = ExamenNummerBox[i].Text;
                examenRow.examen_constructeur = ConstructeurBox[i].Text;
                examenRow.examen_periode_afname = PeriodeAfnameBox[i].Text;
                examenRow.examen_locatie = LocatieBox[i].Text;
                examenRow.examen_naam_opdracht = NaamOpdrachtBox[i].Text;
                examenRow.examen_status_opdracht = StatusOpdrachtBox[i].Text;
                examenRow.examen_opmerkingen = OpmerkingBox[i].Text;

                for (int j = 0; j < 6; j++)
                {
                    DatabaseDataSet.kerntakenRow kerntaakRow = databaseDataSet.kerntaken.NewkerntakenRow();
                    kerntaakRow.kerntaak_naam = KerntakenBox[i, j].Text;
                    kerntaakRow.kerntaak_nummer = KerntaakNrBox[i, j].Text;
                    kerntaakRow.kerntaak_werkprocessen = WerkprocessenBox[i, j].Text;

                    databaseDataSet.kerntaken.AddkerntakenRow(kerntaakRow);

                    //update database etc
                    updateDatabase();
                    this.kerntakenTableAdapter.Fill(this.databaseDataSet.kerntaken);

                    //verkrijg de "nieuwe" ids
                    int ktid = (int)databaseDataSet.kerntaken.Rows[databaseDataSet.kerntaken.Rows.Count - 1][0];
                    ktids[j] = ktid;
                }

                //voeg kerntaken ids toe aan de examenRow
                for (int k = 0; k < ktids.Count(); k++)
                {
                    switch (k)
                    {
                        case 0: examenRow.examen_kerntaak1 = ktids[k]; break;
                        case 1: examenRow.examen_kerntaak2 = ktids[k]; break;
                        case 2: examenRow.examen_kerntaak3 = ktids[k]; break;
                        case 3: examenRow.examen_kerntaak4 = ktids[k]; break;
                        case 4: examenRow.examen_kerntaak5 = ktids[k]; break;
                        case 5: examenRow.examen_kerntaak6 = ktids[k]; break;
                    }
                }

                databaseDataSet.examens.AddexamensRow(examenRow);

                //update database etc
                updateDatabase();
                this.examensTableAdapter.Fill(this.databaseDataSet.examens);

                //verkrijg de "nieuwe" ids
                int id = (int)databaseDataSet.examens.Rows[databaseDataSet.examens.Rows.Count - 1][0];
                ids[i] = id;
                //MessageBox.Show(id.ToString());
            }

            //voeg examen ids toe aan de overzicht row
            for (int i = 0; i < ids.Count(); i++)
            {
                switch (i)
                {
                    case 0: overzichtRow.examen1 = ids[i]; break;
                    case 1: overzichtRow.examen2 = ids[i]; break;
                    case 2: overzichtRow.examen3 = ids[i]; break;
                    case 3: overzichtRow.examen4 = ids[i]; break;
                    case 4: overzichtRow.examen5 = ids[i]; break;
                    case 5: overzichtRow.examen6 = ids[i]; break;
                    case 6: overzichtRow.examen7 = ids[i]; break;
                    case 7: overzichtRow.examen8 = ids[i]; break;
                    case 8: overzichtRow.examen9 = ids[i]; break;
                    case 9: overzichtRow.examen10 = ids[i]; break;
                }
            }

            //voegt overzicht row toe nadat de examens gemaakt zijn
            databaseDataSet.overzicht.AddoverzichtRow(overzichtRow);

            updateDatabase();

            this.overzichtTableAdapter.Fill(this.databaseDataSet.overzicht);

            if (sender.Equals(OpslaanButton))
            {
                tabControl1.SelectTab("tabPage2");
            }
            // Het form wordt gereset naar lege staat.
            clearForm(tabPage1);
            resetExams();
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
            //open e
            ExcelStatus es = new ExcelStatus();
            es.progressBar1.Maximum = dataGridView1.Rows.Count;
            es.progressBar1.Minimum = 0;
            es.Show();

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            int row = 1;
            int c = 1;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Visible == true)
                    xlWorkSheet.Cells[1, c] = column.HeaderText;
                c++;
            }
            foreach (DataGridViewRow itemRow in dataGridView1.Rows)
            {
                for (int column = 0; column < dataGridView1.Columns.Count; column++)
                {
                    if (itemRow.Cells[column].Visible == true)
                    {
                        xlWorkSheet.Cells[row + 1, column + 1] = itemRow.Cells[column].Value;
                    }
                }
                row++;
                es.progressBar1.Value++;
            }
            xlWorkSheet.Cells.Columns.AutoFit();

            Excel.Range usedRange = xlWorkSheet.UsedRange;
            Excel.Range rows = usedRange.Rows;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                //Excel.Range firstCell = r.Cells[1];
                //string firstCellValue = firstCell.Value as string;
                if (dataGridView1.Rows[i].Cells[gecontroleerdDataGridViewTextBoxColumn.Index].Value != null && dataGridView1.Rows[i].Cells[gecontroleerdDataGridViewTextBoxColumn.Index].Value.Equals(1))
                {
                    rows[i + 2].Interior.Color = Color.YellowGreen;
                }
                else
                {
                    rows[i + 2].Interior.Color = Color.Tomato;
                }
            }

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

            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet);
            xlWorkSheet = null;
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);
            xlWorkBook = null;
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
            xlApp = null;

            GC.Collect();
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

        private void resetExams()
        {
            int aantal = examenAantal;
            for (int i = 0; i < aantal; i++)
            {
                this.examenMin();
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
            int[] examen_ids = new int[10];

            examen_ids[0] = getInt(dataGridView1.Rows[rowIndex].Cells[examen1DataGridViewTextBoxColumn.Index].Value);
            examen_ids[1] = getInt(dataGridView1.Rows[rowIndex].Cells[examen2DataGridViewTextBoxColumn.Index].Value);
            examen_ids[2] = getInt(dataGridView1.Rows[rowIndex].Cells[examen3DataGridViewTextBoxColumn.Index].Value);
            examen_ids[3] = getInt(dataGridView1.Rows[rowIndex].Cells[examen4DataGridViewTextBoxColumn.Index].Value);
            examen_ids[4] = getInt(dataGridView1.Rows[rowIndex].Cells[examen5DataGridViewTextBoxColumn.Index].Value);
            examen_ids[5] = getInt(dataGridView1.Rows[rowIndex].Cells[examen6DataGridViewTextBoxColumn.Index].Value);
            examen_ids[6] = getInt(dataGridView1.Rows[rowIndex].Cells[examen7DataGridViewTextBoxColumn.Index].Value);
            examen_ids[7] = getInt(dataGridView1.Rows[rowIndex].Cells[examen8DataGridViewTextBoxColumn.Index].Value);
            examen_ids[8] = getInt(dataGridView1.Rows[rowIndex].Cells[examen9DataGridViewTextBoxColumn.Index].Value);
            examen_ids[9] = getInt(dataGridView1.Rows[rowIndex].Cells[examen10DataGridViewTextBoxColumn.Index].Value);

            for (int i = 0; i < examen_ids.Count(); i++)
            {
                foreach (DataGridViewRow r in dataGridView2.Rows)
                {
                    //MessageBox.Show(r.Cells[examenidDataGridViewTextBoxColumn.Index].Value.ToString());
                    if (Convert.ToInt32(r.Cells[examenidDataGridViewTextBoxColumn.Index].Value) == examen_ids[i] && Convert.ToInt32(r.Cells[examenidDataGridViewTextBoxColumn.Index].Value) != 0)
                    {
                        deleteKerntaken(r.Index);

                        dataGridView2.Rows.RemoveAt(r.Index);
                    }
                }
            }
        }

        private void deleteKerntaken(int rowIndex)
        {
            int[] kerntaken_ids = new int[6];
            kerntaken_ids[0] = getInt(dataGridView2.Rows[rowIndex].Cells[examenkerntaak1DataGridViewTextBoxColumn.Index].Value);
            kerntaken_ids[1] = getInt(dataGridView2.Rows[rowIndex].Cells[examenkerntaak2DataGridViewTextBoxColumn.Index].Value);
            kerntaken_ids[2] = getInt(dataGridView2.Rows[rowIndex].Cells[examenkerntaak3DataGridViewTextBoxColumn.Index].Value);
            kerntaken_ids[3] = getInt(dataGridView2.Rows[rowIndex].Cells[examenkerntaak4DataGridViewTextBoxColumn.Index].Value);
            kerntaken_ids[4] = getInt(dataGridView2.Rows[rowIndex].Cells[examenkerntaak5DataGridViewTextBoxColumn.Index].Value);
            kerntaken_ids[5] = getInt(dataGridView2.Rows[rowIndex].Cells[examenkerntaak6DataGridViewTextBoxColumn.Index].Value);

            for (int i = 0; i < kerntaken_ids.Count(); i++)
            {
                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    if (Convert.ToInt32(row.Cells[kerntaakidDataGridViewTextBoxColumn.Index].Value) == kerntaken_ids[i] && Convert.ToInt32(row.Cells[examenidDataGridViewTextBoxColumn.Index].Value) != 0)
                    {
                        dataGridView3.Rows.RemoveAt(row.Index);
                    }
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
                if (c.HasChildren) // Als een element zelf elementen bevat wordt deze functie nog een keer uitgevoerd voor dat element
                {
                    clearForm(c);
                }
            }
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
                resetExams();
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
            }


            return true;
        }

        private void examenoverzichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Examenoverzicht scherm = new Examenoverzicht(dataGridView1.CurrentRow.Index,opleidingDataGridViewTextBoxColumn.Index,databaseDataSet);
           scherm.Show();
        }
    }   
}
