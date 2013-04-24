using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelFormsApplication1
{
    public partial class Form1 : Form
    {
        public int space = 26;
        public TextBoxIndexer<TextBox> tbi = new TextBoxIndexer<TextBox>();
        public int removeCounter = 0;
        int i = 0,  j = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object misValue = System.Reflection.Missing.Value;
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Add(misValue);
            Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            // add data
            xlWorkSheet.Cells[1, 1] = "Student";
            xlWorkSheet.Cells[1, 2] = studentTextBox.Text;

            xlWorkSheet.Cells[2, 1] = "Wiskunde";
            xlWorkSheet.Cells[2, 2] = wiskundeTextBox.Text;

            xlWorkSheet.Cells[3, 1] = "Engels";
            xlWorkSheet.Cells[3, 2] = engelsTextBox.Text;

            xlWorkSheet.Cells[4, 1] = "Nederlands";
            xlWorkSheet.Cells[4, 2] = nederlandsTextBox.Text;

            // save / export
            xlWorkBook.SaveAs("E:\\testdata2.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            MessageBox.Show("Ge-exporteerd!");

            // release objects
            ReleaseObject(xlWorkBook);
            ReleaseObject(xlWorkSheet);
            ReleaseObject(xlApp);
        }

        private void ReleaseObject(object o)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(o);
                o = null;
            }

            catch (Exception ex)
            {
                o = null;
                MessageBox.Show("Er is iets fout gegaan: " + ex.ToString());
            }

            finally
            {
                GC.Collect();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNewFields();
        }

        public void AddNewFields()
        {
            // create the new fields
            TextBox examen = new TextBox();
            TextBox kerntaak = new TextBox();
            TextBox werkprocessen = new TextBox();
            TextBox naamOpdracht = new TextBox();
            TextBox afname = new TextBox();

            if (tbi[0] == null)
            {
                j = 0;
                i = 0;
            }

            tbi[j] = examen;
            j++;

            tbi[j] = kerntaak;
            j++;

            tbi[j] = werkprocessen;
            j++;

            tbi[j] = naamOpdracht;
            j++;

            tbi[j] = afname;
            j++;

            for ( ; i < j; i++)
            {
                tbi[i].Location = new System.Drawing.Point(nederlandsTextBox.Location.X, nederlandsTextBox.Location.Y + space);
                tbi[i].Parent = this;
                tbi[i].Size = nederlandsTextBox.Size;

                // update the space between each textfield and location of the buttons
                space += 26;
                this.Height += 26;

                button1.Location = new System.Drawing.Point(button1.Location.X, this.ClientRectangle.Bottom - 26);
                button2.Location = new System.Drawing.Point(button2.Location.X, this.ClientRectangle.Bottom - 52);
                button3.Location = new System.Drawing.Point(button3.Location.X, this.ClientRectangle.Bottom - 78);
            }

            removeCounter += 5;
        }

        public void RemoveFields()
        {
            int counter = 0;

            if (tbi != null)
            {
                for (int k = removeCounter ; k >= 0 ; k--)
                {
                    if (tbi[k] != null)
                    {
                        tbi[k].Clear();
                        tbi[k].Dispose();
                        tbi[k] = null;
                    }

                    counter++;

                    if (counter == 6) break;
                }

                // update the space between each textfield and location of the buttons
                space = 26;
                this.Height -= (26 * 5);

                button1.Location = new System.Drawing.Point(button1.Location.X, this.ClientRectangle.Bottom - 26);
                button2.Location = new System.Drawing.Point(button2.Location.X, this.ClientRectangle.Bottom - 52);
                button3.Location = new System.Drawing.Point(button3.Location.X, this.ClientRectangle.Bottom - 78);

                if (removeCounter > 0) removeCounter  -= 5;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (removeCounter != 0)
            {
                RemoveFields();
            }
        }
    }
}
