using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Cohort_Archivering
{
    public partial class Formulier : Form
    {
        string pathPDF = Application.StartupPath + "\\Handleiding.pdf";
        //string pathPDF = "..\\..\\Handleiding.pdf";
        /*public int space = 26;
        public ControlIndexer<TextBox> tbi = new ControlIndexer<TextBox>();
        public ControlIndexer<Label> lbli = new ControlIndexer<Label>();
        public ControlIndexer<ComboBox> cmbi = new ControlIndexer<ComboBox>();
        public int removeCounter = 0;
        int i = 0, j = 0;
        int rfVar = 0;*/
        AddToList addToList = new AddToList();
        bool check = false;

        public Formulier()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.VerticalScroll.Maximum = 2000;
        }

        /*private void PlusLabel_Click(object sender, EventArgs e)
        {
            AddNewFields();
        }*/

        ///// <summary>
        ///// Deze methode is voor het toevoegen van de extra velden. Deze velden komen uit de
        ///// indexers. Deze methode zorgt ook voor de positioneering van de onderste knoppen.
        ///// </summary>
        //public void AddNewFields()
        //{
        //    // create the new fields
        //    TextBox examen = new TextBox();
        //    TextBox kerntaak = new TextBox();
        //    TextBox werkprocessen = new TextBox();
            
        //    ComboBox periodeAfname = new ComboBox();  // Drop down
        //    periodeAfname.DropDownStyle = ComboBoxStyle.DropDownList;
        //    periodeAfname.Items.Add("P1");
        //    periodeAfname.Items.Add("P2");
        //    periodeAfname.Items.Add("P3");
        //    periodeAfname.Items.Add("P4");
        //    periodeAfname.Items.Add("P5");
        //    periodeAfname.Items.Add("P6");
        //    periodeAfname.Items.Add("P7");
        //    periodeAfname.Items.Add("P8");
        //    periodeAfname.Items.Add("P9");
        //    periodeAfname.Items.Add("P10");
        //    periodeAfname.Items.Add("P11");
        //    periodeAfname.Items.Add("P12");

        //    TextBox naamOpdracht = new TextBox();

        //    ComboBox statusOpdracht = new ComboBox(); // Drop down
        //    statusOpdracht.DropDownStyle = ComboBoxStyle.DropDownList;
        //    statusOpdracht.Items.Add("Niet aanwezig");
        //    statusOpdracht.Items.Add("Geconstrueerd");
        //    statusOpdracht.Items.Add("Gecontroleerd");
        //    statusOpdracht.Items.Add("Vastgesteld");

        //    // create the labels
        //    Label examenLabel = new Label();
        //    examenLabel.Text = "Examen*";

        //    Label kerntaakLabel = new Label();
        //    kerntaakLabel.Text = "Kerntaken*";

        //    Label werkprocessenLabel = new Label();
        //    werkprocessenLabel.Text = "Werkprocessen*";

        //    Label periodeAfnameLabel = new Label();
        //    periodeAfnameLabel.Text = "Periode afname*";

        //    Label naamOpdrachtLabel = new Label();
        //    naamOpdrachtLabel.Text = "Naam opdracht";

        //    Label statusOpdrachtLabel = new Label();
        //    statusOpdrachtLabel.Text = "Status opdracht*";

        //    if (tbi[0] == null)
        //    {
        //        j = 0;
        //        i = 0;
        //    }

        //    // put the fields and labels in the indexer
        //    tbi[j] = examen;
        //    lbli[j] = examenLabel;
        //    j++;

        //    tbi[j] = kerntaak;
        //    lbli[j] = kerntaakLabel;
        //    j++;

        //    tbi[j] = werkprocessen;
        //    lbli[j] = werkprocessenLabel;
        //    j++;

        //    cmbi[j] = periodeAfname;         // drop-down
        //    lbli[j] = periodeAfnameLabel;
        //    j++;

        //    tbi[j] = naamOpdracht;
        //    lbli[j] = naamOpdrachtLabel;
        //    j++;

        //    cmbi[j] = statusOpdracht;        // drop-down
        //    lbli[j] = statusOpdrachtLabel;
        //    j++;

        //    for (; i < j; i++)
        //    {
        //        if (tbi[i] == null)
        //        {
        //            cmbi[i].Location = new System.Drawing.Point(StatusOpdrachtDropDown.Location.X, StatusOpdrachtDropDown.Location.Y + space);
        //            cmbi[i].Parent = this;
        //            cmbi[i].Size = StatusOpdrachtDropDown.Size;
        //            cmbi[i].Width = StatusOpdrachtDropDown.Width;

        //            lbli[i].Location = new System.Drawing.Point(label22.Location.X, StatusOpdrachtDropDown.Location.Y + space);
        //            lbli[i].Parent = this;
        //            lbli[i].Size = StatusOpdrachtDropDown.Size;
        //            lbli[i].Width = NaamOpdrachtTextBox.Width;
        //        }

        //        else
        //        {
        //            tbi[i].Location = new System.Drawing.Point(StatusOpdrachtDropDown.Location.X, StatusOpdrachtDropDown.Location.Y + space);
        //            tbi[i].Parent = this;
        //            tbi[i].Size = StatusOpdrachtDropDown.Size;
        //            tbi[i].Width = NaamOpdrachtTextBox.Width;
        //            tbi[i].Focus();

        //            lbli[i].Location = new System.Drawing.Point(label22.Location.X, StatusOpdrachtDropDown.Location.Y + space);
        //            lbli[i].Parent = this;
        //            lbli[i].Size = StatusOpdrachtDropDown.Size;
        //            lbli[i].Width = NaamOpdrachtTextBox.Width;
        //        }

        //        // update the space between each textfield and location of the buttons
        //        space += 26;

        //        this.VerticalScroll.LargeChange += 220;
        //        this.VerticalScroll.Value += 220; //80;

        //        volgendeinvoerbut.Location = new System.Drawing.Point(volgendeinvoerbut.Location.X, this.ClientRectangle.Bottom + 5/*- 26*/);
        //        klaaroverzichtbut.Location = new System.Drawing.Point(klaaroverzichtbut.Location.X, volgendeinvoerbut.Location.Y /*this.ClientRectangle.Bottom + 3*/);
        //        questionmarkvolgendeinvoer.Location = new System.Drawing.Point(questionmarkvolgendeinvoer.Location.X, volgendeinvoerbut.Location.Y + 5 /*this.ClientRectangle.Bottom*/);
        //        questionmarkKlaarnoverzicht.Location = new System.Drawing.Point(questionmarkKlaarnoverzicht.Location.X, volgendeinvoerbut.Location.Y + 5 /*this.ClientRectangle.Bottom*/);

        //        questionmark11.Location = new System.Drawing.Point(questionmark11.Location.X, volgendeinvoerbut.Location.Y - 24 /*this.ClientRectangle.Bottom - 15*/);
        //        XLabel.Location = new System.Drawing.Point(XLabel.Location.X, volgendeinvoerbut.Location.Y - 24 /*this.ClientRectangle.Bottom - 15*/);
        //        PlusLabel.Location = new System.Drawing.Point(PlusLabel.Location.X, volgendeinvoerbut.Location.Y - 27 /*this.ClientRectangle.Bottom - 19*/);
        //    }

        //   removeCounter += 6;
        //    rfVar += 100;
        //}

        //private void XLabel_Click(object sender, EventArgs e)
        //{
        //    if (removeCounter != 0) RemoveFields();
        //}

        ///// <summary>
        ///// Deze methode is voor het verwijderen van de extra velden en voor de positioneering
        ///// van de onderste knoppen.
        ///// </summary>
        //public void RemoveFields()
        //{
        //    int counter = 0;

        //    if (tbi != null)
        //    {
        //        for (int k = removeCounter; k >= 0; k--)
        //        {
        //            if (tbi[k] != null)
        //            {
        //                tbi[k].Clear();
        //                tbi[k].Dispose();
        //                tbi[k] = null;
        //            }

        //            else
        //            {
        //                if(cmbi[k] != null)
        //                    cmbi[k].Dispose();

        //                cmbi[k] = null;
        //            }

        //            if (lbli[k] != null)
        //            {
        //                lbli[k].Text = "";
        //                lbli[k].Dispose();
        //                lbli[k] = null;
        //            }

        //            counter++;

        //            if (counter == 7) break;
        //        }

        //        // update the space between each textfield and location of the buttons
        //        space = 26;

        //        this.VerticalScroll.Value += 50; // 140

        //        volgendeinvoerbut.Location = new System.Drawing.Point(volgendeinvoerbut.Location.X, this.ClientRectangle.Bottom + rfVar);
        //        klaaroverzichtbut.Location = new System.Drawing.Point(klaaroverzichtbut.Location.X, volgendeinvoerbut.Location.Y);
        //        questionmarkvolgendeinvoer.Location = new System.Drawing.Point(questionmarkvolgendeinvoer.Location.X, volgendeinvoerbut.Location.Y);
        //        questionmarkKlaarnoverzicht.Location = new System.Drawing.Point(questionmarkKlaarnoverzicht.Location.X, volgendeinvoerbut.Location.Y);

        //        questionmark11.Location = new System.Drawing.Point(questionmark11.Location.X, volgendeinvoerbut.Location.Y - 17);
        //        XLabel.Location = new System.Drawing.Point(XLabel.Location.X, volgendeinvoerbut.Location.Y - 17);
        //        PlusLabel.Location = new System.Drawing.Point(PlusLabel.Location.X, volgendeinvoerbut.Location.Y - 22);

        //        if (removeCounter > 0) removeCounter -= 6; // 5

        //        rfVar -= 100;
        //    }
        //}

        /// <summary>
        /// method voor het invoeren
        /// </summary>
        private void invoeren()
        {
            int cCode = 0;
            int nDropdown = 0;
            int cHort = 0;
            int kdVers = 0;
            int lAantal = 0;

            string veldenNietinGevuld = "Niet alle velden zijn ingevuld";
            try
            {
                // echte loop
                TextBox[] Fields = {CrebocodeTextBox,CohortTextBox,KdversieTextBox,LeerlingAantalTB };
                
                for (int i = 0; i < 4; i++)
                {
                    if (Fields[i].Text == "")
                    {
                        check = false;
                        MessageBox(veldenNietinGevuld);
                        return;
                    }
                    else
                    {

                    }
                }

                    //loop die kijkt of er geen text in de velden staat waar ints inmoeten
                    if (CrebocodeTextBox.Text == "")
                    {
                        check = false;
                        MessageBox.Show(veldenNietinGevuld);
                        return;
                    }
                    else
                    {
                        cCode = testParse(CrebocodeTextBox.Text);
                        if (NiveauDropDown.Text == "")
                        {
                            check = false;
                            MessageBox.Show(veldenNietinGevuld);
                        }
                        else
                        {
                            nDropdown = testParse(NiveauDropDown.Text);
                            if (CohortTextBox.Text == "")
                            {
                                check = false;
                                MessageBox.Show(veldenNietinGevuld);
                            }
                            else
                            {
                                cHort = testParse(CohortTextBox.Text);
                                if (KdversieTextBox.Text == "")
                                {
                                    check = false;
                                    MessageBox.Show(veldenNietinGevuld);
                                }
                                else
                                {
                                    kdVers = testParse(KdversieTextBox.Text);
                                    if (LeerlingAantalTB.Text == "")
                                    {
                                        check = false;
                                        MessageBox.Show(veldenNietinGevuld);
                                    }
                                    else
                                    {
                                        lAantal = testParse(LeerlingAantalTB.Text);
                                    }
                                }
                            }
                        }
                    }

                //addToList = new AddToList();

                addToList.fillExamenlist(cCode, this.OpleidingTextbox.Text, this.KwalificatieTextBox.Text, this.UitstroomTextBox.Text,
                nDropdown, this.LeerrouteDropDown.Text, this.KCdropDown.Text, cHort, kdVers, lAantal, this.ExamenProfielDropDown.Text,
                this.VoorzitterTextBox.Text, this.AanspreekpuntTB.Text, this.ManagerTextBox.Text, this.ExamenTextBox.Text,
                this.KerntakenTextBox.Text, this.WerkProcessenTextBox.Text, this.Periodeafnamedropdown.Text, this.NaamOpdrachtTextBox.Text,
                this.StatusOpdrachtDropDown.Text, this.ExamenTextBox2.Text,
                this.KerntakenTextBox2.Text, this.WerkProcessenTextBox2.Text, this.Periodeafnamedropdown2.Text, this.NaamOpdrachtTextBox2.Text,
                this.StatusOpdrachtDropDown2.Text, this.ExamenTextBox3.Text,
                this.KerntakenTextBox3.Text, this.WerkProcessenTextBox3.Text, this.Periodeafnamedropdown3.Text, this.NaamOpdrachtTextBox3.Text,
                this.StatusOpdrachtDropDown3.Text, this.ExamenTextBox4.Text,
                this.KerntakenTextBox4.Text, this.WerkProcessenTextBox4.Text, this.Periodeafnamedropdown4.Text, this.NaamOpdrachtTextBox4.Text,
                this.StatusOpdrachtDropDown4.Text,
                this.ExamenTextBox5.Text,
                this.KerntakenTextBox5.Text, this.WerkProcessenTextBox5.Text, this.Periodeafnamedropdown5.Text, this.NaamOpdrachtTextBox5.Text,
                this.StatusOpdrachtDropDown5.Text,
                this.ExamenTextBox6.Text,
                this.KerntakenTextBox6.Text, this.WerkProcessenTextBox6.Text, this.Periodeafnamedropdown6.Text, this.NaamOpdrachtTextBox6.Text,
                this.StatusOpdrachtDropDown6.Text);


                
                this.CrebocodeTextBox.Clear();
                this.OpleidingTextbox.Clear();
                this.KwalificatieTextBox.Clear();
                this.UitstroomTextBox.Clear();
                //this.NiveauDropDown.SelectedIndex = 0;
                //this.LeerrouteDropDown = null;
                //this.KCdropDown = null;
                this.CohortTextBox.Clear();
                this.KdversieTextBox.Clear();
                this.LeerlingAantalTB.Clear();
                //this.ExamenProfielDropDown = null;
                this.VoorzitterTextBox.Clear();
                this.AanspreekpuntTB.Clear();
                this.ManagerTextBox.Clear();
                this.ExamenTextBox.Clear();
                this.KerntakenTextBox.Clear();
                this.WerkProcessenTextBox.Clear();
                //this.Periodeafnamedropdown = null;
                this.NaamOpdrachtTextBox.Clear();
                //this.StatusOpdrachtDropDown = null;
                this.ExamenTextBox2.Clear();
                this.KerntakenTextBox2.Clear();
                this.WerkProcessenTextBox2.Clear();
                this.Periodeafnamedropdown2.SelectedIndex = 0;
                this.NaamOpdrachtTextBox2.Clear();
                this.StatusOpdrachtDropDown2.SelectedIndex = 0;
                this.ExamenTextBox3.Clear();
                this.KerntakenTextBox3.Clear();
                this.WerkProcessenTextBox3.Clear();
                this.Periodeafnamedropdown3.SelectedIndex = 0;
                this.NaamOpdrachtTextBox3.Clear();
                this.StatusOpdrachtDropDown3.SelectedIndex = 0;
                this.ExamenTextBox4.Clear();
                this.KerntakenTextBox4.Clear();
                this.WerkProcessenTextBox4.Clear();
                this.Periodeafnamedropdown4.SelectedIndex = 0;
                this.NaamOpdrachtTextBox4.Clear();
                this.StatusOpdrachtDropDown4.SelectedIndex = 0;
                this.ExamenTextBox5.Clear();
                this.KerntakenTextBox5.Clear();
                this.WerkProcessenTextBox5.Clear();
                this.Periodeafnamedropdown5.SelectedIndex = 0;
                this.NaamOpdrachtTextBox5.Clear();
                this.StatusOpdrachtDropDown5.SelectedIndex = 0;
                this.ExamenTextBox6.Clear();
                this.KerntakenTextBox6.Clear();
                this.WerkProcessenTextBox6.Clear();
                this.Periodeafnamedropdown6.SelectedIndex = 0;
                this.NaamOpdrachtTextBox6.Clear();
                this.StatusOpdrachtDropDown6.SelectedIndex = 0;

                /*foreach (TextBox t in tbi)
                {

                }*/

                //Control.ControlCollection coll = this.Controls;

                /*foreach(Control c in coll)
                {
                    if (c is TextBox)
                    {
                        if (((TextBox)c).Text == string.Empty)
                            check = false;
                        else 
                            check = true;
                    }
                }*/

                check = true;
            }

            catch (Exception x)
            {
                check = false;
                MessageBox.Show(veldenNietinGevuld + " Error!!" + x.ToString());

            }
        }
        //sluit de applicatie af met een weet u het zeker yes no dialoog
        private void klikAfsluiten_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Weet u het zeker dat u het programma wilt afsluiten? \nAlle niet opgeslagen gegevens gaan verloren!", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //zing hier maar een liedje
            }

        }

        private void klaarenoverzicht_Click(object sender, EventArgs e)
        {
            invoeren();
            if (check == true)
            {
                OverzichtFormulier overzichtFormulier = new OverzichtFormulier(addToList/*, tbi, cmbi, removeCounter*/);
                overzichtFormulier.Show();
            }

        }
        //check voor ints
        private int testParse(string testText)
        {
            int returnint;
            bool test = int.TryParse(testText, out returnint);

            if (test == false)
            {
                MessageBox.Show(testText + ", Hier heeft u niet de goede waarde ingevuld!");
            }

            return returnint;
        }
        //open pdf file deze staat altijd op een vaste plaats na de installatie
        private void openpdf_Click(object sender, EventArgs e)
        {
            try
            {
                //Process.Start("C:\\Users\\Naron\\Dropbox\\Eindproject GUI\\Applicatie\\CohortArchivering\\Cohort Archivering\\Handleiding.pdf");
                Process.Start(pathPDF);
            }
            catch
            {
                MessageBox.Show("Er is een probleem ontstaan! \nKijk of u wel een PDF reader heeft geinstalleerd.");
            }
        }
        /*private void XLabel_MouseHover(object sender, EventArgs e)
        {
            XLabel.BackColor = Color.Gray;
        }

        private void XLabel_MouseLeave(object sender, EventArgs e)
        {
            XLabel.BackColor = this.BackColor;
        }

        private void PlusLabel_MouseHover(object sender, EventArgs e)
        {
            PlusLabel.BackColor = Color.Gray;
        }

        private void PlusLabel_MouseLeave(object sender, EventArgs e)
        {
            PlusLabel.BackColor = this.BackColor;
        }*/

        private void volgendeinvoer_Click(object sender, EventArgs e)
        {
            invoeren();
        }

    }
}
