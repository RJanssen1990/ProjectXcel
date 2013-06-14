using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Examenoverzicht : Form
    {
        int rowIndex;
        int opleidingColumnIndex;
        private DatabaseDataSet data;
        string[] gegevens_opleiding = new string[4];
        string[] gegevens_examen = new string[9];
        string[] gegevens_kerntaken = new string[3];

        public Examenoverzicht(int rowIndex, int opleidingColumnIndex, DatabaseDataSet dc)
        {
            data = dc;
            InitializeComponent();
            maakElementen();
            this.rowIndex = rowIndex;
            this.opleidingColumnIndex = opleidingColumnIndex;
            LeesGegevens();            
        }

        private void LeesGegevens()
        {
            string opleidingsnaam = data.overzicht.Rows[rowIndex][opleidingColumnIndex].ToString();
            string uitstroom = data.overzicht.Rows[rowIndex][3].ToString();
            this.Text = "Examenoverzicht " + uitstroom;

            int opleiding_id;

            TreeNode root = new System.Windows.Forms.TreeNode(opleidingsnaam);
            opleiding_id = getInt(data.overzicht.Rows[rowIndex][0]);
            root.Name = "opleiding";
            root.Tag = opleiding_id;

            int examen_id;

            for (int i = 0; i < data.examens.Rows.Count; i++)
            {
                if (opleiding_id == getInt(data.examens.Rows[i][11]))
                {
                    TreeNode examen = new TreeNode(data.examens.Rows[i][1].ToString());
                    examen.Name = "examen";
                    examen.Tag = data.examens.Rows[i][0];
                    root.Nodes.Add(examen);
                    
                    int kerntaak_nummer = 0;


                    for (int j = 0; j < data.kerntaken.Rows.Count; j++)
                    {
                        examen_id = getInt(data.examens.Rows[i][0]);
                        if (examen_id == getInt(data.kerntaken.Rows[j][4]))
                        {
                            kerntaak_nummer = getInt(data.kerntaken.Rows[j][2]);
                            if (kerntaak_nummer != 0)
                            {
                                TreeNode kerntaak = new TreeNode("Kerntaak " + kerntaak_nummer);
                                kerntaak.Name = "kerntaak";
                                kerntaak.Tag = data.kerntaken.Rows[j][0];
                                examen.Nodes.Add(kerntaak);
                            }
                        }
                    }
                }
                setOpleidingInfo(opleiding_id);
            }

            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            root});
            this.treeView1.ExpandAll();
        }

        private int getInt(Object value)
        {
            int newValue;
            int.TryParse(value.ToString(), out newValue);
            return newValue;
        }

        private void Node_Click(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Name == "kerntaak")
            {
                int id = (int)e.Node.Tag;
                setKerntaakInfo(id);
            }
            else if (e.Node.Name == "examen")
            {
                int id = (int)e.Node.Tag;
                setExamenInfo(id);
            }
            else if (e.Node.Name == "opleiding")
            {
                int id = (int)e.Node.Tag;
                setOpleidingInfo(id);
            }
            else
            {
                Clear();
            }
        }

        private void setOpleidingInfo(int id)
        {
            foreach (DatabaseDataSet.overzichtRow r in data.overzicht.Rows)
            {
                if (id == r.id)
                {
                    gegevens_opleiding[0] = r.crebo;
                    gegevens_opleiding[1] = r.cohort;
                    gegevens_opleiding[2] = r.niveau;
                    gegevens_opleiding[3] = r.kenniscentrum;
                    VulInfoOpleiding();
                }
            }
        }
        
        private void setExamenInfo(int id)
        {
            foreach (DatabaseDataSet.examensRow r in data.examens.Rows)
            {
                if (id == r.examen_id)
                {
                    gegevens_examen[0] = r.examen_nummer;
                    gegevens_examen[1] = r.examen_constructeur;
                    gegevens_examen[2] = r.examen_start_periode;
                    gegevens_examen[3] = r.examen_eind_periode;
                    gegevens_examen[4] = r.examen_locatie;
                    gegevens_examen[5] = r.examen_naam_opdracht;
                    gegevens_examen[6] = r.examen_status_opdracht;
                    gegevens_examen[7] = r.examen_beoordeling;
                    gegevens_examen[8] = r.examen_opmerking;
                    VulInfoExamen();
                }
            }
        }

        private void setKerntaakInfo(int id)
        {
            foreach (DatabaseDataSet.kerntakenRow r in data.kerntaken.Rows)
            {
                if (id == r.kerntaak_id)
                {
                    foreach(DatabaseDataSet.examensRow row in data.examens.Rows)
                    {
                        if(r.examen_id == row.examen_id)
                        {
                            gegevens_kerntaken[0] = row.examen_naam_opdracht;
                        }
                    }     
                    gegevens_kerntaken[1] = r.kerntaak_naam;
                    gegevens_kerntaken[2] = r.kerntaak_werkprocessen.Replace(';', ',');
                    VulInfoKerntaken();
                }
            }
        }

        private void Node_DoubleClick(object sender, TreeViewCancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
