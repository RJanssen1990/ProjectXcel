namespace WindowsFormsApplication1
{
    partial class Examenoverzicht
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Infotext = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.ShowPlusMinus = false;
            this.treeView1.Size = new System.Drawing.Size(226, 424);
            this.treeView1.TabIndex = 0;
            this.treeView1.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.Node_DoubleClick);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Node_Click);
            // 
            // Infotext
            // 
            this.Infotext.Location = new System.Drawing.Point(245, 12);
            this.Infotext.Name = "Infotext";
            this.Infotext.Size = new System.Drawing.Size(482, 424);
            this.Infotext.TabIndex = 1;
            // 
            // Examenoverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 448);
            this.Controls.Add(this.Infotext);
            this.Controls.Add(this.treeView1);
            this.Name = "Examenoverzicht";
            this.ResumeLayout(false);

        }      

        #endregion

        private void maakElementen()
        {
            for (int i = 0; i < gegevens_examen.Length; i++)
            {
                examenLabel[i] = new System.Windows.Forms.Label();
                examenInfo[i] = new System.Windows.Forms.Label();
                //
                // Labels examen
                //
                this.examenLabel[i].AutoSize = true;
                this.examenLabel[i].Location = new System.Drawing.Point(15, 15 + (i * 30));
                this.examenLabel[i].Name = "ExamenLabel" + i;
                this.examenLabel[i].Size = new System.Drawing.Size(82, 13);
                this.examenLabel[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 11, System.Drawing.FontStyle.Underline);
                //
                // Text examen
                //
                this.examenInfo[i].AutoSize = true;
                this.examenInfo[i].Location = new System.Drawing.Point(160, 15 + (i * 30));
                this.examenInfo[i].Name = "ExamenInfo" + i;
                this.examenInfo[i].Size = new System.Drawing.Size(82, 13);
                this.examenInfo[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 11);

                this.Infotext.Controls.Add(this.examenLabel[i]);
                this.Infotext.Controls.Add(this.examenInfo[i]);
                if (i < gegevens_kerntaken.Length)
                {
                    this.kerntaakLabel[i] = new System.Windows.Forms.Label();
                    this.kerntaakInfo[i] = new System.Windows.Forms.Label();
                    //
                    // Labels kerntaken
                    //                    
                    this.kerntaakLabel[i].AutoSize = true;
                    this.kerntaakLabel[i].Location = new System.Drawing.Point(15, 15 + (i * 30));
                    this.kerntaakLabel[i].Name = "KerntaakLabel" + i;
                    this.kerntaakLabel[i].Size = new System.Drawing.Size(82, 13);
                    this.kerntaakLabel[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 11, System.Drawing.FontStyle.Underline);
                    //
                    // Text kerntaken
                    //
                    this.kerntaakInfo[i].AutoSize = true;
                    this.kerntaakInfo[i].Location = new System.Drawing.Point(160, 15 + (i * 30));
                    this.kerntaakInfo[i].Name = "KerntaakInfo" + i;
                    this.kerntaakInfo[i].Size = new System.Drawing.Size(82, 13);
                    this.kerntaakInfo[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 11);

                    this.Infotext.Controls.Add(this.kerntaakLabel[i]);
                    this.Infotext.Controls.Add(this.kerntaakInfo[i]);
                }
                if (i < gegevens_opleiding.Length)
                {
                    this.opleidingLabel[i] = new System.Windows.Forms.Label();
                    this.opleidingInfo[i] = new System.Windows.Forms.Label();
                    //
                    // Labels kerntaken
                    //                    
                    this.opleidingLabel[i].AutoSize = true;
                    this.opleidingLabel[i].Location = new System.Drawing.Point(15, 15 + (i * 30));
                    this.opleidingLabel[i].Name = "opleidingLabel" + i;
                    this.opleidingLabel[i].Size = new System.Drawing.Size(82, 13);
                    this.opleidingLabel[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 11, System.Drawing.FontStyle.Underline);
                    //
                    // Text kerntaken
                    //
                    this.opleidingInfo[i].AutoSize = true;
                    this.opleidingInfo[i].Location = new System.Drawing.Point(160, 15 + (i * 30));
                    this.opleidingInfo[i].Name = "opleidingInfo" + i;
                    this.opleidingInfo[i].Size = new System.Drawing.Size(82, 13);
                    this.opleidingInfo[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 11);

                    this.Infotext.Controls.Add(this.opleidingLabel[i]);
                    this.Infotext.Controls.Add(this.opleidingInfo[i]);
                }

            }
        }

        private void Clear()
        {
            for (int i = 0; i < gegevens_examen.Length; i++)
            {
                if (i < gegevens_kerntaken.Length)
                {
                    this.kerntaakLabel[i].Text = "";
                    this.kerntaakInfo[i].Text = "";
                }
                if (i < gegevens_opleiding.Length)
                {
                    this.opleidingLabel[i].Text = "";
                    this.opleidingInfo[i].Text = "";
                }
                this.examenLabel[i].Text = "";
                this.examenInfo[i].Text = "";
            }
        }

        private void VulInfoOpleiding()
        {
            string[] labels_opleiding = { "Crebo:","Cohort:","Niveau:","Kenniscentrum:" };

            Clear();
            
            for (int i = 0; i < gegevens_opleiding.Length; i++)
            {
                this.opleidingLabel[i].Text = labels_opleiding[i];
                this.opleidingInfo[i].Text = gegevens_opleiding[i];
            }
        }
        
        private void VulInfoExamen()
        {
            string[] labels_examen = { "Nummer:", "Constructeur:", "Start Periode","Einde Periode", "Locatie Afname:", "Naam Opdracht:", "Status Opdracht:","Beoordelingsschaal:", "Opmerkingen:" };

            Clear();
            
            for (int i = 0; i < gegevens_examen.Length; i++)
            {
                this.examenLabel[i].Text = labels_examen[i];
                this.examenInfo[i].Text = gegevens_examen[i];
            }
        }

        private void VulInfoKerntaken()
        {
            string[] labels_kerntaak = {"Kerntaak Titel:","Kerntaak Nummer:","Werkprocessen:" };

            Clear();
            
            for (int i = 0; i < gegevens_kerntaken.Length; i++)
            {
                this.kerntaakLabel[i].Text = labels_kerntaak[i];
                this.kerntaakInfo[i].Text = gegevens_kerntaken[i];
            }
        }


        private System.Windows.Forms.Label[] examenLabel = new System.Windows.Forms.Label[9];
        private System.Windows.Forms.Label[] examenInfo = new System.Windows.Forms.Label[9];
        private System.Windows.Forms.Label[] opleidingLabel = new System.Windows.Forms.Label[4];
        private System.Windows.Forms.Label[] opleidingInfo = new System.Windows.Forms.Label[4];
        private System.Windows.Forms.Label[] kerntaakLabel = new System.Windows.Forms.Label[3];
        private System.Windows.Forms.Label[] kerntaakInfo = new System.Windows.Forms.Label[3];


        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel Infotext;
        
    }
}