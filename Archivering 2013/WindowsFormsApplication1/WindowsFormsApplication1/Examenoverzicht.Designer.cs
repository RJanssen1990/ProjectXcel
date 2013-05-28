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
            this.databaseDataSet = new WindowsFormsApplication1.DatabaseDataSet();
            this.examensTableAdapter = new WindowsFormsApplication1.DatabaseDataSetTableAdapters.examensTableAdapter();
            this.overzichtTableAdapter = new WindowsFormsApplication1.DatabaseDataSetTableAdapters.overzichtTableAdapter();
            this.kerntakenTableAdapter = new WindowsFormsApplication1.DatabaseDataSetTableAdapters.kerntakenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(156, 389);
            this.treeView1.TabIndex = 0;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examensTableAdapter
            // 
            this.examensTableAdapter.ClearBeforeFill = true;
            // 
            // overzichtTableAdapter
            // 
            this.overzichtTableAdapter.ClearBeforeFill = true;
            // 
            // kerntakenTableAdapter
            // 
            this.kerntakenTableAdapter.ClearBeforeFill = true;
            // 
            // Examenoverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 448);
            this.Controls.Add(this.treeView1);
            this.Name = "Examenoverzicht";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Examenoverzicht_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private void LeesGegevens()
        {
            string opleidingsnaam = databaseDataSet.overzicht.Rows[rowIndex][opleidingColumnIndex].ToString();
            System.Windows.Forms.MessageBox.Show(opleidingsnaam);
            
            //System.Windows.Forms.TreeNode root = new System.Windows.Forms.TreeNode(opleidingsnaam);


            //this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            //root});
        }

        private System.Windows.Forms.TreeView treeView1;
        private DatabaseDataSet databaseDataSet;
        private DatabaseDataSetTableAdapters.examensTableAdapter examensTableAdapter;
        private DatabaseDataSetTableAdapters.overzichtTableAdapter overzichtTableAdapter;
        private DatabaseDataSetTableAdapters.kerntakenTableAdapter kerntakenTableAdapter;
    }
}