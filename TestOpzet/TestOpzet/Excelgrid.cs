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
    
    public partial class Excelgrid : Form
    {
        public Form mainForm = TestOpzet.KerntaakForm.ActiveForm;
        private dataList formDataList = new dataList();
        public dataList FormDataList
        {
            set { formDataList = value;}
        }
        ////private KerntaakForm ktform;
        public Excelgrid(/*KerntaakForm form*/)
        {
            InitializeComponent();
           // ktform = form;
        }

        private void Excelgrid_Load(object sender, EventArgs e)
        {
            //fillList();
        }
         
        //public void fillList(/*string[] a*/)
        //{
        //    dataList dl = new dataList();
        //    ListViewItem item1 = new ListViewItem("", 0);
        //    for (int i = 0; i < dl.Count; i++)
        //    {
        //        item1.SubItems.Add(dl[i]);
        //    }
        //    ListViewItem item2 = new ListViewItem("Values :", 1);
        //    item2.SubItems.Add("12449");
        //    item2.SubItems.Add("05698");
        //    ListViewItem item3 = new ListViewItem("", 0);
        //    item3.SubItems.Add("12456");
        //    item3.SubItems.Add("06843");
        //    //for (int i = 0; i < a.Length; i++)
        //    //{
        //    //    listView1.Columns.Add(a[i], -2, HorizontalAlignment.Left);
        //    //}
        //    listView1.Columns.Add("", -2, HorizontalAlignment.Left);
        //    listView1.Columns.Add("Code domein", -2, HorizontalAlignment.Left);
        //    listView1.Columns.Add("Code dossier", -2, HorizontalAlignment.Left);
        //    listView1.Columns.Add("Naam kwalificatiedossier", -2, HorizontalAlignment.Left);
        //    listView1.Columns.Add("Crebocode kwalificatie", -2, HorizontalAlignment.Left);
        //    listView1.Columns.Add("Naam kwalificatie", -2, HorizontalAlignment.Left);
        //    listView1.Columns.Add("KD versie", -2, HorizontalAlignment.Left);
        //    listView1.Columns.Add("Opleidingsvariant", -2, HorizontalAlignment.Left);
        //    listView1.Columns.Add("Niveau", -2, HorizontalAlignment.Left);
        //    listView1.Columns.Add("Leerweg", -2, HorizontalAlignment.Left);
        //    listView1.Columns.Add("Kenniscentrum", -2, HorizontalAlignment.Left);
        //    listView1.Columns.Add("Startjaardeelnemers", -2, HorizontalAlignment.Left);
        //    listView1.Columns.Add("Examenprofiel", -2, HorizontalAlignment.Left);
        //    listView1.Columns.Add("Manager", -2, HorizontalAlignment.Left);
        //    listView1.Columns.Add("Portefeuillehouder", -2, HorizontalAlignment.Left);
        //    listView1.Columns.Add("Examencoördinator", -2, HorizontalAlignment.Left);
        //    this.listView1.Columns[0].Width = 100;
            //listView2.Columns.Add("Examennummer", -2, HorizontalAlignment.Left);
            //listView2.Columns.Add("Examennaam", -2, HorizontalAlignment.Left);
            //listView2.Columns.Add("Kerntaak", -2, HorizontalAlignment.Left);
            //listView2.Columns.Add("Werproces", -2, HorizontalAlignment.Left);
            //listView2.Columns.Add("Kerntaak", -2, HorizontalAlignment.Left);
            //listView2.Columns.Add("Werkproces", -2, HorizontalAlignment.Left);
            //listView2.Columns.Add("Constructeur", -2, HorizontalAlignment.Left);
            //listView2.Columns.Add("Status", -2, HorizontalAlignment.Left);
            //listView2.Columns.Add("Periode", -2, HorizontalAlignment.Left);
            //listView2.Columns.Add("Plaats", -2, HorizontalAlignment.Left);
            //this.listView2.Columns[0].Width = 100;
            //listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });
            //listView2.Items.AddRange(new ListViewItem[] { item1, item2, item3 });
        //}

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        //public void bullCrapTestFacility(string[] a)
        //{
        //    for (int i = 0; i < a.Length; i++ )
        //    {
        //        listView1.Columns.Add(a[i], -2, HorizontalAlignment.Left);   
        //    }
        //    examenForm ef = new examenForm();
        //    ef.Show();
        //}
    }
}
