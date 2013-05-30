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
        Dictionary<string, int> kerntaken = new Dictionary<string, int>();
        Dictionary<string, int> examens = new Dictionary<string, int>(); 


        public Examenoverzicht(int rowIndex, int opleidingColumnIndex, DatabaseDataSet dc)
        {
            data = dc;
            InitializeComponent();
            this.rowIndex = rowIndex;
            this.opleidingColumnIndex = opleidingColumnIndex;
            LeesGegevens();
            
        }

        private void LeesGegevens()
        {
            string opleidingsnaam = data.overzicht.Rows[rowIndex][opleidingColumnIndex].ToString();

            int[] examen_ids = new int[10];

            TreeNode root = new System.Windows.Forms.TreeNode(opleidingsnaam);
            
            
            for (int i = 0; i < 10; i++)
            {
                examen_ids[i] = getInt(data.overzicht.Rows[rowIndex][i + 15]);
                if (examen_ids[i] != 0)
                {
                    TreeNode examen = new TreeNode("Examen " + (i + 1));
                    int[] kerntaken_ids = new int[6];
                    
                        foreach(DatabaseDataSet.examensRow r in data.examens.Rows) 
                        {
                            if (examen_ids[i] == r.examen_id)
                            {
                                for (int j = 0; j < 6; j++)
                                {
                                    int[] kerntaak_nummers = new int[6];
                                     
                                    kerntaken_ids[j] = getInt(data.examens.Rows[data.examens.Rows.IndexOf(r)][j + 8]);
                                    foreach (DatabaseDataSet.kerntakenRow kr in data.kerntaken.Rows)
                                    {
                                        if (kerntaken_ids[j] == kr.kerntaak_id)
                                        {
                                            kerntaak_nummers[j] = getInt(data.kerntaken.Rows[data.kerntaken.Rows.IndexOf(kr)][2]);                                           
                                        }
                                    }

                                    if (kerntaak_nummers[j] != 0)
                                    {
                                        TreeNode kerntaak = new TreeNode("Kerntaak " + kerntaak_nummers[j]);
                                        kerntaak.Name = "kerntaak";
                                        examen.Nodes.Add(kerntaak);
                                        kerntaken.Add("Kerntaak " + kerntaak_nummers[j],kerntaken_ids[j]);
                                    }
                                
                            }
                        }
                    }
                    examen.Name = "examen";
                    root.Nodes.Add(examen);
                    examens.Add("Examen " + (i + 1), examen_ids[i]);
                }                
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
                int id;
                kerntaken.TryGetValue(e.Node.Text, out id);
                setKerntaakInfo(id);
            }
            else if (e.Node.Name == "examen")
            {
                int id;
                examens.TryGetValue(e.Node.Text, out id);
                setExamenInfo(id);
            }

        }

        private void setExamenInfo(int id)
        {

        }

        private void setKerntaakInfo(int id)
        {

        }

        private void Node_DoubleClick(object sender, TreeViewCancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
