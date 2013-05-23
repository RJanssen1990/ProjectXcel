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
        private string[] columnNames = { "Crebocode",	"Kwalificatie",	"Uitstroom",	"Opleidingsnaam",	"Niveau",	"Leerroute",	"Kenniscentrum",	"Cohort",	"KD Versie",	"Examenprofiel",	"Examenplan",	"Portefeuillehouder",	"Aanspreekpunt",	"Manager"};
        
        public Main()
        {
            InitializeComponent();
            examenPlus();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.examens' table. You can move, or remove it, as needed.
            this.examensTableAdapter.Fill(this.databaseDataSet.examens);
            // TODO: This line of code loads data into the 'databaseDataSet.overzicht' table. You can move, or remove it, as needed.
            this.overzichtTableAdapter.Fill(this.databaseDataSet.overzicht);
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
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                string opleiding = dataGridView1.Rows[rowIndex].Cells[opleidingDataGridViewTextBoxColumn.Index].Value.ToString();
                string crebo = dataGridView1.Rows[rowIndex].Cells[creboDataGridViewTextBoxColumn.Index].Value.ToString();

                tabControl1.SelectTab("tabPage1");

                /*Formulier form = new Formulier(this, rowIndex, opleiding, crebo);
                form.Visible = true;
                form.Text = "Formulier - opleiding: " + opleiding + " | crebo: " + crebo;*/
            }
            else
            {
                MessageBox.Show("Er kan maar één rij worden geselecteerd");
            }

            //MessageBox.Show("Row " + rowIndex.ToString());
        }

        private void buttonOpslaan_Click(object sender, EventArgs e)
        {
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
                int id = (int)databaseDataSet.examens.Rows[databaseDataSet.examens.Rows.Count-1][0];
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
            else
            {
                OpleidingBox.Clear();
                CreboBox.Clear();
                KwalificatieBox.Clear();
                UitstroomBox.Clear();
                NiveauBox.SelectedIndex = -1;
                LeerrouteBox.SelectedIndex = -1;
                KenniscentrumBox.SelectedIndex = -1; KenniscentrumBox.Text = "";
                CohortBox.Clear();
                KdVersieBox.Clear();
                ExamenProfielBox.SelectedIndex = -1; ExamenProfielBox.Text = "";
                ExamenPlanBox.Clear();
                PortHouderBox.Clear();
                AanspreekBox.Clear();
                ManagerBox.Clear();
            }

        }

        private void buttonNieuw_Click(object sender, EventArgs e)
        {
            DatabaseDataSet.overzichtRow row = databaseDataSet.overzicht.NewoverzichtRow();

            databaseDataSet.overzicht.AddoverzichtRow(row);

            updateDatabase();

            this.overzichtTableAdapter.Fill(this.databaseDataSet.overzicht);
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

        //functie voor het formulier
        public void updateDataGridView(int rowIndex, String opleiding, String crebo)
        {
            //verandere de values
            dataGridView1.Rows[rowIndex].Cells[opleidingDataGridViewTextBoxColumn.Index].Value = opleiding;
            dataGridView1.Rows[rowIndex].Cells[creboDataGridViewTextBoxColumn.Index].Value = crebo;

            updateDatabase();
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

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Weet u zeker de geselecteerde item(s) te verwijderen?", "Verwijderen", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            //dataGridView1.SelectedRows.Count.ToString()

            //rows geselecteerd
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
            
            //cellen geselecteerd
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
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
    }
}
