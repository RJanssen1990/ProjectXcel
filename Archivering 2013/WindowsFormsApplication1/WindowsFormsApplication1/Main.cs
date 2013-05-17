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
        public Main()
        {
            InitializeComponent();
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

                textBox1.Text = opleiding;
                textBox2.Text = crebo;

                tabControl1.SelectTab("tabPage1");

                buttonNieuw.Visible = false;
                buttonNieuw.Enabled = false;
                buttonOpslaan.Visible = true;
                buttonOpslaan.Enabled = true;

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
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            String opleiding = textBox1.Text;
            String crebo = textBox2.Text;
            updateDataGridView(rowIndex, opleiding, crebo);

            //textbox leegmaken
            textBox1.Text = "";
            textBox2.Text = "";

            buttonNieuw.Visible = true;
            buttonNieuw.Enabled = true;
            buttonOpslaan.Visible = false;
            buttonOpslaan.Enabled = false;

            tabControl1.SelectTab("tabPage2");
        }

        private void buttonNieuw_Click(object sender, EventArgs e)
        {
            DatabaseDataSet.overzichtRow row = databaseDataSet.overzicht.NewoverzichtRow();
            row.crebo = textBox1.Text;
            row.opleiding = textBox2.Text;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void overzichtBindingSource_CurrentChanged(object sender, EventArgs e)
        {

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
            foreach (DataGridViewRow itemRow in dataGridView1.Rows)
            {
                for (int column = 0; column < dataGridView1.Columns.Count; column++)
                {
                    xlWorkSheet.Cells[row, column + 1] = itemRow.Cells[column].Value;

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
    }
}
