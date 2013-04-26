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
    public partial class examenForm : Form
    {
        public examenForm()
        {
            InitializeComponent();
        }

        // All values that are send from the first screen
        public void initValues(/*int a*/)
        {
            //Label[] allLabels = new Label[] {this.ktlab1, this.ktlab2, this.ktlab3, this.ktlab4, this.ktlab5, this.ktlab6 };
            //if (sender == "bevestig")
            //{
            //    showAll();
            //}
        }

        public void handleData()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excelgrid test = new Excelgrid();
            test.Show();
        }

        private void Bevestigex_Click(object sender, EventArgs e)
        {
            
        }

        public void showAll()
        { 
            
        }

        private void examenForm_Load(object sender, EventArgs e)
        {

        }
    }
}
