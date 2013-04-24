using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Cohort_Archivering
{
    public partial class OverzichtFormulier : Form
    {
        public AddToList addToListVariable;
        /*private ControlIndexer<TextBox> ciTextBox;
        private ControlIndexer<ComboBox> ciComboBox;
        private int counter = 0;*/

        public OverzichtFormulier(AddToList addToListVariable/*, ControlIndexer<TextBox> ciTextBox, ControlIndexer<ComboBox> ciComboBox, int rCounter*/)
        {
            InitializeComponent();

            this.addToListVariable = addToListVariable;
            //this.ciTextBox = ciTextBox;
            //this.ciComboBox = ciComboBox;
            
            //if(this.counter > 0)
            //this.counter = rCounter;

            //dataGridView1.DataSource = addToListVariable.GetExamenPlanList();
            //dataGridView1.Show();

            //DataGridViewColumn col;

            foreach (ExamenPlan i in this.getListContent())
            {
                //Maak een object van de crebocode
                ListViewItem crebocode = new ListViewItem(i.CreboCode.ToString());

                //Plaats de items in de subitems
                ListViewItem.ListViewSubItem opleidingsnaam = new ListViewItem.ListViewSubItem(crebocode, i.Opleidingsnaam);
                ListViewItem.ListViewSubItem kwalificatie = new ListViewItem.ListViewSubItem(crebocode, i.Kwalificatie);
                ListViewItem.ListViewSubItem uitstroom = new ListViewItem.ListViewSubItem(crebocode, i.Uitstroom);
                ListViewItem.ListViewSubItem niveau = new ListViewItem.ListViewSubItem(crebocode, i.Niveau.ToString());
                ListViewItem.ListViewSubItem leerroute = new ListViewItem.ListViewSubItem(crebocode, i.LeerRoute);
                ListViewItem.ListViewSubItem kenniscentrum = new ListViewItem.ListViewSubItem(crebocode, i.KennisCentrum);
                ListViewItem.ListViewSubItem cohort = new ListViewItem.ListViewSubItem(crebocode, i.Cohort.ToString());
                ListViewItem.ListViewSubItem kdversie = new ListViewItem.ListViewSubItem(crebocode, i.KdVersie.ToString());
                ListViewItem.ListViewSubItem leerlingaantal = new ListViewItem.ListViewSubItem(crebocode, i.AantalLeerlingen.ToString());
                ListViewItem.ListViewSubItem examenprofiel = new ListViewItem.ListViewSubItem(crebocode, i.ExamenProfiel);
                ListViewItem.ListViewSubItem voorzitter = new ListViewItem.ListViewSubItem(crebocode, i.TeamVoorzitter);
                ListViewItem.ListViewSubItem aanspreekpunt = new ListViewItem.ListViewSubItem(crebocode, i.AanspreekPunt);
                ListViewItem.ListViewSubItem manager = new ListViewItem.ListViewSubItem(crebocode, i.Manager);
                ListViewItem.ListViewSubItem examen = new ListViewItem.ListViewSubItem(crebocode, i.Examen);
                ListViewItem.ListViewSubItem kerntaken = new ListViewItem.ListViewSubItem(crebocode, i.Kerntaken);
                ListViewItem.ListViewSubItem werkproces = new ListViewItem.ListViewSubItem(crebocode, i.WerkProcessen);
                ListViewItem.ListViewSubItem afnameperiode = new ListViewItem.ListViewSubItem(crebocode, i.PeriodeAfnamen);
                ListViewItem.ListViewSubItem opdrachtnaam = new ListViewItem.ListViewSubItem(crebocode, i.NaamOpdracht);
                ListViewItem.ListViewSubItem opdrachtstatus = new ListViewItem.ListViewSubItem(crebocode, i.StatusOpdracht);
                ListViewItem.ListViewSubItem examen2 = new ListViewItem.ListViewSubItem(crebocode, i.Examen2);
                ListViewItem.ListViewSubItem kerntaken2 = new ListViewItem.ListViewSubItem(crebocode, i.KernTaken2);
                ListViewItem.ListViewSubItem werkproces2 = new ListViewItem.ListViewSubItem(crebocode, i.WerkProcessen2);
                ListViewItem.ListViewSubItem afnameperiode2 = new ListViewItem.ListViewSubItem(crebocode, i.PeriodeAfnamen2);
                ListViewItem.ListViewSubItem opdrachtnaam2 = new ListViewItem.ListViewSubItem(crebocode, i.NaamOpdracht2);
                ListViewItem.ListViewSubItem opdrachtstatus2 = new ListViewItem.ListViewSubItem(crebocode, i.StatusOpdracht2);
                ListViewItem.ListViewSubItem examen3 = new ListViewItem.ListViewSubItem(crebocode, i.Examen3);
                ListViewItem.ListViewSubItem kerntaken3 = new ListViewItem.ListViewSubItem(crebocode, i.KernTaken3);
                ListViewItem.ListViewSubItem werkproces3 = new ListViewItem.ListViewSubItem(crebocode, i.WerkProcessen3);
                ListViewItem.ListViewSubItem afnameperiode3 = new ListViewItem.ListViewSubItem(crebocode, i.PeriodeAfnamen3);
                ListViewItem.ListViewSubItem opdrachtnaam3 = new ListViewItem.ListViewSubItem(crebocode, i.NaamOpdracht3);
                ListViewItem.ListViewSubItem opdrachtstatus3 = new ListViewItem.ListViewSubItem(crebocode, i.StatusOpdracht3);
                ListViewItem.ListViewSubItem examen4 = new ListViewItem.ListViewSubItem(crebocode, i.Examen4);
                ListViewItem.ListViewSubItem kerntaken4 = new ListViewItem.ListViewSubItem(crebocode, i.KernTaken4);
                ListViewItem.ListViewSubItem werkproces4 = new ListViewItem.ListViewSubItem(crebocode, i.WerkProcessen4);
                ListViewItem.ListViewSubItem afnameperiode4 = new ListViewItem.ListViewSubItem(crebocode, i.PeriodeAfnamen4);
                ListViewItem.ListViewSubItem opdrachtnaam4 = new ListViewItem.ListViewSubItem(crebocode, i.NaamOpdracht4);
                ListViewItem.ListViewSubItem opdrachtstatus4 = new ListViewItem.ListViewSubItem(crebocode, i.StatusOpdracht4);
                ListViewItem.ListViewSubItem examen5 = new ListViewItem.ListViewSubItem(crebocode, i.Examen5);
                ListViewItem.ListViewSubItem kerntaken5 = new ListViewItem.ListViewSubItem(crebocode, i.KernTaken5);
                ListViewItem.ListViewSubItem werkproces5 = new ListViewItem.ListViewSubItem(crebocode, i.WerkProcessen5);
                ListViewItem.ListViewSubItem afnameperiode5 = new ListViewItem.ListViewSubItem(crebocode, i.PeriodeAfnamen5);
                ListViewItem.ListViewSubItem opdrachtnaam5 = new ListViewItem.ListViewSubItem(crebocode, i.NaamOpdracht5);
                ListViewItem.ListViewSubItem opdrachtstatus5 = new ListViewItem.ListViewSubItem(crebocode, i.StatusOpdracht5);
                ListViewItem.ListViewSubItem examen6 = new ListViewItem.ListViewSubItem(crebocode, i.Examen6);
                ListViewItem.ListViewSubItem kerntaken6 = new ListViewItem.ListViewSubItem(crebocode, i.KernTaken6);
                ListViewItem.ListViewSubItem werkproces6 = new ListViewItem.ListViewSubItem(crebocode, i.WerkProcessen6);
                ListViewItem.ListViewSubItem afnameperiode6 = new ListViewItem.ListViewSubItem(crebocode, i.PeriodeAfnamen6);
                ListViewItem.ListViewSubItem opdrachtnaam6 = new ListViewItem.ListViewSubItem(crebocode, i.NaamOpdracht6);
                ListViewItem.ListViewSubItem opdrachtstatus6 = new ListViewItem.ListViewSubItem(crebocode, i.StatusOpdracht6);

                //Plaats de subitems in het item
                crebocode.SubItems.Add(opleidingsnaam);
                crebocode.SubItems.Add(kwalificatie);
                crebocode.SubItems.Add(uitstroom);
                crebocode.SubItems.Add(niveau);
                crebocode.SubItems.Add(leerroute);
                crebocode.SubItems.Add(kenniscentrum);
                crebocode.SubItems.Add(cohort);
                crebocode.SubItems.Add(kdversie);
                crebocode.SubItems.Add(leerlingaantal);
                crebocode.SubItems.Add(examenprofiel);
                crebocode.SubItems.Add(voorzitter);
                crebocode.SubItems.Add(aanspreekpunt);
                crebocode.SubItems.Add(manager);
                crebocode.SubItems.Add(examen);
                crebocode.SubItems.Add(kerntaken);
                crebocode.SubItems.Add(werkproces);
                crebocode.SubItems.Add(afnameperiode);
                crebocode.SubItems.Add(opdrachtnaam);
                crebocode.SubItems.Add(opdrachtstatus);
                crebocode.SubItems.Add(examen2);
                crebocode.SubItems.Add(kerntaken2);
                crebocode.SubItems.Add(werkproces2);
                crebocode.SubItems.Add(afnameperiode2);
                crebocode.SubItems.Add(opdrachtnaam2);
                crebocode.SubItems.Add(opdrachtstatus2);
                crebocode.SubItems.Add(examen3);
                crebocode.SubItems.Add(kerntaken3);
                crebocode.SubItems.Add(werkproces3);
                crebocode.SubItems.Add(afnameperiode3);
                crebocode.SubItems.Add(opdrachtnaam3);
                crebocode.SubItems.Add(opdrachtstatus3);
                crebocode.SubItems.Add(examen4);
                crebocode.SubItems.Add(kerntaken4);
                crebocode.SubItems.Add(werkproces4);
                crebocode.SubItems.Add(afnameperiode4);
                crebocode.SubItems.Add(opdrachtnaam4);
                crebocode.SubItems.Add(opdrachtstatus4);
                crebocode.SubItems.Add(examen5);
                crebocode.SubItems.Add(kerntaken5);
                crebocode.SubItems.Add(werkproces5);
                crebocode.SubItems.Add(afnameperiode5);
                crebocode.SubItems.Add(opdrachtnaam5);
                crebocode.SubItems.Add(opdrachtstatus5);
                crebocode.SubItems.Add(examen6);
                crebocode.SubItems.Add(kerntaken6);
                crebocode.SubItems.Add(werkproces6);
                crebocode.SubItems.Add(afnameperiode6);
                crebocode.SubItems.Add(opdrachtnaam6);
                crebocode.SubItems.Add(opdrachtstatus6);
                // Plaats de variabele velden
                /*for (int c = 0; c < counter; //c++)
                {

                    if (ciTextBox[c] != null /*&& ciComboBox[0] != null/)
                    {
                        if (ciTextBox[c].Text != string.Empty)
                        {
                            ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem(crebocode, ciTextBox[c].Text);
                            ColumnHeader ch = new ColumnHeader();
                            ch.Text = "Examen";

                            lvsi.Text = ciTextBox[c].Text;

                            overzichtListView.Columns.Add(ch);
                            crebocode.SubItems.Add(lvsi);
                        }

                        c++;

                        if (ciTextBox[c].Text != string.Empty)
                        {
                            ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem(crebocode, ciTextBox[c].Text);
                            ColumnHeader ch = new ColumnHeader();
                            ch.Text = "Kerntaken";

                            lvsi.Text = ciTextBox[c].Text;

                            overzichtListView.Columns.Add(ch);
                            crebocode.SubItems.Add(lvsi);
                        }

                        c++;

                        if (ciTextBox[c].Text != string.Empty)
                        {
                            ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem(crebocode, ciTextBox[c].Text);
                            ColumnHeader ch = new ColumnHeader();
                            ch.Text = "Werk processen";

                            lvsi.Text = ciTextBox[c].Text;

                            overzichtListView.Columns.Add(ch);
                            crebocode.SubItems.Add(lvsi);
                        }

                        c++;

                        if (ciComboBox[c].Text != string.Empty)
                        {
                            ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem(crebocode, ciComboBox[c].Text);
                            ColumnHeader ch = new ColumnHeader();
                            ch.Text = "Periode afname";

                            lvsi.Text = ciComboBox[c].Text;

                            overzichtListView.Columns.Add(ch);
                            crebocode.SubItems.Add(lvsi);
                        }

                        c++;

                        if (ciTextBox[c].Text != string.Empty)
                        {
                            ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem(crebocode, ciTextBox[c].Text);
                            ColumnHeader ch = new ColumnHeader();
                            ch.Text = "Naam opdracht";

                            lvsi.Text = ciTextBox[c].Text;

                            overzichtListView.Columns.Add(ch);
                            crebocode.SubItems.Add(lvsi);
                        }

                        c++;

                        if (ciComboBox[c].Text != string.Empty)
                        {
                            ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem(crebocode, ciComboBox[c].Text);
                            ColumnHeader ch = new ColumnHeader();
                            ch.Text = "Status opdracht";

                            lvsi.Text = ciComboBox[c].Text;

                            overzichtListView.Columns.Add(ch);
                            crebocode.SubItems.Add(lvsi);
                        }

                        c++;
                    }
                }*/

                //plaats de volledige lijst in de listview
                overzichtListView.Items.Add(crebocode);
            }

        }

        public ExamenPlanList getListContent()
        {
            ExamenPlanList examenplanList = this.addToListVariable.GetExamenPlanList();
            return examenplanList;
        }

        private void exporterenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Worksheets|*.xls";
            sfd.ShowDialog();
            
            SaveExcel(sfd.FileName);
        }

        public void SaveExcel(string Path)
        {
            ExcelStatus es = new ExcelStatus();

            es.progressBar1.Maximum = overzichtListView.Columns.Count;
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
            foreach (ListViewItem itemRow in overzichtListView.Items)
            {
                for (int column = 0; column < overzichtListView.Columns.Count; column++)
                {
                    xlWorkSheet.Cells[row, column + 1] = itemRow.SubItems[column].Text;
                    
                }
                row++;
                es.progressBar1.Value++;
            }

            try
            {
                xlWorkBook.SaveAs(Path, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            }
            catch { }
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
    }
}
