using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestOpzet
{
    public partial class KerntaakForm : Form
    {
        Excelgrid excelgrid= new Excelgrid();
        dataList formDataList = new dataList();
        public bool fieldOK = false;
       
        public KerntaakForm()
        {
            InitializeComponent();
            excelgrid = new Excelgrid(/*this*/);
        }

        // this function is our main function, all click events call upon this one.
        public void createArray(object sender)
        {
         // A constant int that holds the value of all the boxes who need to be invisible
            const int hideAmount = 6;
        
         // This integer will hold the value of how many Kerntaken need to be filled in

            int aantalkt = Ktaantal.Text != "" ? Convert.ToInt32(Ktaantal.Text) : 0;
           
         // Array with all text boxes, needed to store the values from the form, and needed for the reset function.
            string[] values = new string[] 
            { this.nakwdtb.Text, this.nakwtb.Text, this.lwtb.Text, this.kctb.Text, this.exprtb.Text, this.matb.Text, this.phtb.Text, this.epctb.Text,
                this.codotb.Text, this.codostb.Text, this.crkwtb.Text, this.kdtb.Text, this.stjrtb.Text,this.opvacb.Text, this.nicb.Text};
            
        // TextBox and ComboBox arrays to handle resetFields();
            TextBox[] allBoxes = new TextBox[] { this.nakwdtb, this.nakwtb, this.lwtb, this.kctb, this.exprtb, this.matb, this.phtb, this.epctb,
                this.codotb, this.codostb, this.crkwtb, this.kdtb, this.stjrtb, this.ktbox1, this.ktbox2, this.ktbox3, this.ktbox4, this.ktbox5, this.ktbox6,
                    this.wpbox1, this.wpbox2, this.wpbox3, this.wpbox4, this.wpbox5, this.wpbox6,  this.ktnbox1, this.ktnbox2, this.ktnbox3, this.ktnbox4, this.ktnbox5, this.ktnbox6};
            string[] allcBoxes = new string[] { this.opvacb.Text, this.nicb.Text };
            
         // These array's are made to maintain the visibility of the label's and textboxes
            Label[] kerntakenLabel = new Label[] { null, this.ktlab1, this.wplab1, this.ktnlab1, this.ktlab2, this.wplab2, this.ktnlab2, this.ktlab3, this.wplab3, this.ktnlab3,
            this.ktlab4, this.wplab4, this.ktnlab4, this.ktlab5, this.wplab5, this.ktnlab5, this.ktlab6, this.wplab6, this.ktnlab6};
            TextBox[] kerntakenBoxes = new TextBox[] {null, this.ktbox1, this.wpbox1, this.ktnbox1, this.ktbox2, this.wpbox2, this.ktnbox2, this.ktbox3, this.wpbox3, this.ktnbox3,
            this.ktbox4, this.wpbox4, this.ktnbox4, this.ktbox5, this.wpbox5, this.ktnbox5, this.ktbox6, this.wpbox6, this.ktnbox6};
            Label[] kerntakenNr = new Label[] {null, this.ktnrlab1, this.ktnrlab2, this.ktnrlab3, this.ktnrlab4, this.ktnrlab5, this.ktnrlab6};
            
         // An array holding al the values given in this form.
            string[] allValues = new string[] {this.nakwdtb.Text, this.nakwtb.Text, this.opvacb.Text, this.lwtb.Text, this.kctb.Text, this.exprtb.Text, this.matb.Text, this.phtb.Text, this.epctb.Text,
            this.codotb.Text, this.codostb.Text, this.crkwtb.Text, this.kdtb.Text, this.nicb.Text, this.stjrtb.Text, this.ktbox1.Text, this.wpbox1.Text, this.ktnbox1.Text, this.ktbox2.Text, this.wpbox2.Text, this.ktnbox2.Text,
              this.ktbox3.Text, this.wpbox3.Text, this.ktnbox3.Text, this.ktbox4.Text, this.wpbox4.Text, this.ktnbox4.Text, this.ktbox5.Text, this.wpbox5.Text,
              this.ktnbox5.Text, this.ktbox6.Text, this.wpbox6.Text, this.ktnbox6.Text};

         // An array with all the textboxes from the kerntaak section
              string[] allkt = new string[] { null, this.ktbox1.Text, this.wpbox1.Text, this.ktnbox1.Text, this.ktbox2.Text, this.wpbox2.Text, this.ktnbox2.Text,
              this.ktbox3.Text, this.wpbox3.Text, this.ktnbox3.Text, this.ktbox4.Text, this.wpbox4.Text, this.ktnbox4.Text, this.ktbox5.Text, this.wpbox5.Text,
              this.ktnbox5.Text, this.ktbox6.Text, this.wpbox6.Text, this.ktnbox6.Text  };


              string[] allLabelText = new string[] { this.opleidingsdomein.Text, this.codedossier.Text, this.naamkwado.Text, this.crebokwali.Text };
         // Checks which button called the function and calls the function which is needed.
            if (sender == Bevestig)
            {
                hideAll(kerntakenLabel, kerntakenBoxes, hideAmount, kerntakenNr);
                showKT(kerntakenLabel, kerntakenBoxes, aantalkt, kerntakenNr);
            }
            if (sender == Reset)
            {
                resetFields(allBoxes);
                hideAll(kerntakenLabel, kerntakenBoxes, aantalkt, kerntakenNr);
            }
            if (sender == Volgende)
            {
                checkFields(values, aantalkt, allkt, allcBoxes);
                if (fieldOK == true)
                {
                    
                }
            }
        }

        // Here are the 3 event listeners for a button click event, if an event is called, it will be redirected to createArray()
        private void button1_Click(object sender, EventArgs e)
        {
            createArray(sender); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            createArray(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            createArray(sender);
        }

        // Function where all the kerntaken labels and textboxed are made visible
        public void showKT(Label[] a, TextBox[] b, int c, Label[] d)
        {
            if (c <= 6)
            {
                for (int i = 1; i <= c; i++)
                {
                    d[i].Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Er kunnen maar maximaal 6 kerntaken ingevuld worden!");
            }
                c = c * 3;
            if (c <= 18)
            {
                for (int i = 1; i <= c; i++)
                {
                    a[i].Visible = true;
                    b[i].Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Er kunnen maar 6 kerntaken maximaal ingevuld worden!");
            }

         }
        
        // Function that hides the label en textboxes of kerntaken when needed.
        public void hideAll(Label[]a, TextBox[]b, int c, Label[]d)
        {
            for (int i = 1; i <= c; i++)
            {
                d[i].Visible = false;
            }
                c = c * 3;
            if (c == 0)
            {
                MessageBox.Show("De kerntaken zijn leeg, deze zullen niet gereset worden!");
            }
            else
            {
                for (int i = 1; i <= c; i++)
                {
                    a[i].Visible = false;
                    b[i].Visible = false;
                    
                }
            }
        }

        // simple, Here i reset the input given in the textboxes
        public void resetFields(TextBox[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i].Text = "";
            }
        }

        // Here i check if there are any fields who haven't been filled yet.
        public void checkFields(string[] a, int b, string[]c, string[]d)
        {
            b = b * 3;
            bool field1 = false;
            bool field2 = false;
            bool field3 = false;

            
            for (int i = 0; i < a.Length; i++)
            {
                 if (a[i] != "")
                 {
                     field1 = true;
                 }
                 else
                 {
                     MessageBox.Show("Er is een veld niet ingevuld");
                     fieldOK = false;
                 }
            }
            for (int i = 0; i < b; i++)
            {
                if (c[i] != "")
                {
                    field2 = true;
                }
                else
                {
                    MessageBox.Show("Er is een kerntaak niet voldoende ingevuld!");
                    fieldOK = false;
                }
            }
            for (int i = 0; i < d.Length; i++)
            {
                if (d[i] != "Kies een optie")
                {
                    field3 = true;
                }
                else
                {
                    MessageBox.Show("Er is een selectieveld niet ingevuld");
                }
            }

            if (b == 0)
            {
                MessageBox.Show("Er zijn geen kerntaken ingevuld!");
                field1 = false;
            }
            else
            {
                field1 = true;
            }

            if (field1 == true && field2 == true && field3 == true)
            {
                fieldOK = true;
                nextPage();
            }
        }

        // Sends you to the second screen
        public void nextPage()
        { 
            examenForm ef = new examenForm();
            saveValues();
            ef.Show();
        }

         // Void for saving all the values in order to show them in Excelgrid
        public void saveValues() 
        {
            dataClass dc = new dataClass();
            dc.Opldomcode = codotb.Text;
            dc.Doscode = codostb.Text;
            dc.Nakwados = nakwdtb.Text;
            dc.Crebcokwali = crkwtb.Text;
            dc.Naamkwali = nakwtb.Text;
            dc.Kdversie = kdtb.Text;
            dc.Opleivari = opvacb.Text;
            dc.Niveau = nicb.Text;
            dc.Leerweg = lwtb.Text;
            dc.Kenncentr = kctb.Text;
            dc.Startdeeln = stjrtb.Text;
            dc.Examprof = exprtb.Text;
            dc.Manager = matb.Text;
            dc.Portehoud = phtb.Text;
            dc.Exmnplanco = epctb.Text;
            dc.Kt1 = ktnbox1.Text;
            dc.Ktnm1 = ktbox1.Text;
            dc.Wp1 = wpbox1.Text;
            dc.Kt2 = ktnbox2.Text;
            dc.Ktnm2 = ktbox2.Text;
            dc.Wp2 = wpbox2.Text;
            dc.Kt3 = ktnbox3.Text;
            dc.Ktnm3 = ktbox3.Text;
            dc.Wp3 = wpbox3.Text;
            dc.Kt4 = ktnbox4.Text;
            dc.Ktnm4 = ktbox4.Text;
            dc.Wp4 = wpbox4.Text;
            dc.Kt5 = ktnbox5.Text;
            dc.Ktnm5 = ktbox5.Text;
            dc.Wp5 = wpbox5.Text;
            dc.Kt6 = ktnbox6.Text;
            dc.Ktnm6 = ktbox6.Text;
            dc.Wp6 = wpbox6.Text;

            excelgrid.Show();
            formDataList.Add(dc);
            excelgrid.FormDataList = formDataList;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            examenForm ef = new examenForm();
            saveValues();
            ef.Show();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
