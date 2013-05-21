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
            // TODO: This line of code loads data into the 'databaseDataSet.overzicht' table. You can move, or remove it, as needed.
            this.overzichtTableAdapter.Fill(this.databaseDataSet.overzicht);
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
            DatabaseDataSet.overzichtRow row = databaseDataSet.overzicht.NewoverzichtRow();
            //int rowIndex = dataGridView1.CurrentCell.RowIndex;
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
            //updateDataGridView(rowIndex, opleiding, crebo);

            row.opleiding = opleiding;
            row.crebo = crebo;
            row.kwalificatie = kwalificatie;
            row.uitstroom = uitstroom;
            row.niveau = niveau;
            row.leerroute = leerroute;
            row.kenniscentrum = kenniscentrum;
            row.cohort = cohort;
            row.kd_versie = kdversie;
            row.examenprofiel = examenprofiel;
            row.explan = examenplan;
            row.portefeuillehouder = portefeuillehouder;
            row.aanspreekpunt = aanspreekpunt;
            row.manager = manager;

            databaseDataSet.overzicht.AddoverzichtRow(row);

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
                KenniscentrumBox.SelectedIndex = -1;
                CohortBox.Clear();
                KdVersieBox.Clear();
                ExamenProfielBox.SelectedIndex = -1;
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
                this.overzichtTableAdapter.Update(this.databaseDataSet.overzicht);
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
            int c = 2;
            foreach (string title in columnNames)
            {
                xlWorkSheet.Cells[1, c] = title;
                c++;
            }
            foreach (DataGridViewRow itemRow in dataGridView1.Rows)
            {
                for (int column = 0; column < dataGridView1.Columns.Count; column++)
                {
                    xlWorkSheet.Cells[row + 1, column + 1] = itemRow.Cells[column].Value;

                }
                row++;
                es.progressBar1.Value++;
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
            MessageBox.Show(dataGridView1.SelectedRows.Count.ToString());

            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
            
            
            
            updateDatabase();
        }
    }
}
