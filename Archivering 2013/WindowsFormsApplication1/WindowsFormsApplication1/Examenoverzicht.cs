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

        // Deze functie leest de gegevens van een opleiding in de database en plaatst ze in de UI.
        private void LeesGegevens()
        {
            string opleidingsnaam = data.overzicht.Rows[rowIndex][opleidingColumnIndex].ToString(); // Haalt de naam van de opleiding uit de database
            string uitstroom = data.overzicht.Rows[rowIndex][3].ToString(); // Haalt de uitstroom van de opleiding uit de database
            this.Text = "Examenoverzicht " + uitstroom; // Zorgt ervoor dat de titel van het scherm wordt verandert.

            int opleiding_id;

            TreeNode root = new System.Windows.Forms.TreeNode(opleidingsnaam); // Aan de treeview wordt een Node toegevoegt.
            opleiding_id = getInt(data.overzicht.Rows[rowIndex][0]);
            root.Name = "opleiding";
            root.Tag = opleiding_id;

            int examen_id;

            // Alle examens in de database worden doorgelopen.
            for (int i = 0; i < data.examens.Rows.Count; i++)
            {
                if (opleiding_id == getInt(data.examens.Rows[i][11])) // Wordt uitgevoerd als het opleiding_id gelijk is aan de id die is meegegeven aan de examen tabel.
                {
                    TreeNode examen = new TreeNode(data.examens.Rows[i][1].ToString());
                    examen.Name = "examen";
                    examen.Tag = data.examens.Rows[i][0];
                    root.Nodes.Add(examen);
                    
                    int kerntaak_nummer = 0;

                    // Alle kerntaken in de database worden doorgelopen.
                    for (int j = 0; j < data.kerntaken.Rows.Count; j++) 
                    {
                        examen_id = getInt(data.examens.Rows[i][0]);
                        if (examen_id == getInt(data.kerntaken.Rows[j][4])) // Wordt uitgevoerd als het examen_id gelijk is aan de id die is meegegeven aan de kerntaken tabel.
                        {
                            kerntaak_nummer = getInt(data.kerntaken.Rows[j][2]);
                            TreeNode kerntaak = new TreeNode("Kerntaak " + kerntaak_nummer);
                            kerntaak.Name = "kerntaak";
                            kerntaak.Tag = data.kerntaken.Rows[j][0];
                            examen.Nodes.Add(kerntaak);
                        }
                    }
                }
                setOpleidingInfo(opleiding_id);
            }

            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            root}); // Voegt alle nodes toe aan een treeview.
            this.treeView1.ExpandAll(); // Zorgt ervoor dat de hele tree uitgeklapt is.
        }

        // Probeert een object value om te zetten naar een int.
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

        // Haalt de gegevens van de opleiding uit de database en slaat ze op in een array
        private void setOpleidingInfo(int id)
        {
            foreach (DatabaseDataSet.overzichtRow r in data.overzicht.Rows) // Loopt alle opleidingen door.
            {
                if (id == r.id) // Wordt uitgevoerd als de meegegeven id gelijk is aan een id in de tabel.
                {
                    gegevens_opleiding[0] = r.crebo;
                    gegevens_opleiding[1] = r.cohort;
                    gegevens_opleiding[2] = r.niveau;
                    gegevens_opleiding[3] = r.kenniscentrum;
                    VulInfoOpleiding(); // Voert de functie uit die de gegevens in de UI zet.
                }
            }
        }

        // Haalt de gegevens van het examen uit de database en slaat ze op in een array
        private void setExamenInfo(int id)
        {
            foreach (DatabaseDataSet.examensRow r in data.examens.Rows) // Loopt alle examens door.
            {
                if (id == r.examen_id) // Wordt uitgevoerd als de meegegeven id gelijk is aan een id in de tabel.
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

        // Haalt de gegevens van de kerntaak uit de database en slaat ze op in een array
        private void setKerntaakInfo(int id)
        {
            foreach (DatabaseDataSet.kerntakenRow r in data.kerntaken.Rows) // Loopt alle kerntaken door
            {
                if (id == r.kerntaak_id) // Wordt uitgevoerd als de meegegeven id gelijk is aan een id in de tabel.
                {
                    //Di wordt extra uitgevoerd om de naam van de opdracht mee te geven met de gegevens van de kerntaken.
                    foreach(DatabaseDataSet.examensRow row in data.examens.Rows) // Loop alle examens nog een keer door
                    {
                        if(r.examen_id == row.examen_id)  // Kijkt of het id van het examen overeen komt met het id dat is meegegeven aan de kerntaak
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

        // Zorgt ervoor dat de treeNodes niet in- of uitgeklapt kunnen worden door middel van dubbelklik.
        private void Node_DoubleClick(object sender, TreeViewCancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
