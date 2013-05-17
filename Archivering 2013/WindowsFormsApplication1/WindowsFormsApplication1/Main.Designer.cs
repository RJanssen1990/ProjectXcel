namespace WindowsFormsApplication1
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonOpslaan = new System.Windows.Forms.Button();
            this.buttonNieuw = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creboDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kwalificatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uitstroomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opleidingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niveauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leerrouteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kenniscentrumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cohortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdVersieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examenprofielDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.explanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portefeuillehouderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aanspreekpuntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gecontroleerdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overzichtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new WindowsFormsApplication1.DatabaseDataSet();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.handleidingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aanpassenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.overzichtTableAdapter = new WindowsFormsApplication1.DatabaseDataSetTableAdapters.overzichtTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overzichtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 453);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(725, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(725, 429);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonOpslaan);
            this.tabPage1.Controls.Add(this.buttonNieuw);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(717, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Formulier";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonOpslaan
            // 
            this.buttonOpslaan.Enabled = false;
            this.buttonOpslaan.Location = new System.Drawing.Point(47, 191);
            this.buttonOpslaan.Name = "buttonOpslaan";
            this.buttonOpslaan.Size = new System.Drawing.Size(75, 23);
            this.buttonOpslaan.TabIndex = 5;
            this.buttonOpslaan.Text = "Opslaan";
            this.buttonOpslaan.UseVisualStyleBackColor = true;
            this.buttonOpslaan.Visible = false;
            this.buttonOpslaan.Click += new System.EventHandler(this.buttonOpslaan_Click);
            // 
            // buttonNieuw
            // 
            this.buttonNieuw.Location = new System.Drawing.Point(47, 191);
            this.buttonNieuw.Name = "buttonNieuw";
            this.buttonNieuw.Size = new System.Drawing.Size(75, 23);
            this.buttonNieuw.TabIndex = 4;
            this.buttonNieuw.Text = "Nieuw";
            this.buttonNieuw.UseVisualStyleBackColor = true;
            this.buttonNieuw.Click += new System.EventHandler(this.buttonNieuw_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.bindingNavigator1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(717, 403);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Overzicht";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.creboDataGridViewTextBoxColumn,
            this.kwalificatieDataGridViewTextBoxColumn,
            this.uitstroomDataGridViewTextBoxColumn,
            this.opleidingDataGridViewTextBoxColumn,
            this.niveauDataGridViewTextBoxColumn,
            this.leerrouteDataGridViewTextBoxColumn,
            this.kenniscentrumDataGridViewTextBoxColumn,
            this.cohortDataGridViewTextBoxColumn,
            this.kdVersieDataGridViewTextBoxColumn,
            this.examenprofielDataGridViewTextBoxColumn,
            this.explanDataGridViewTextBoxColumn,
            this.portefeuillehouderDataGridViewTextBoxColumn,
            this.aanspreekpuntDataGridViewTextBoxColumn,
            this.managerDataGridViewTextBoxColumn,
            this.gecontroleerdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.overzichtBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(711, 372);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.updateDatabase_Change);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            this.dataGridView1.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.showContextMenuStrip);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.rowRemovedHandler);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creboDataGridViewTextBoxColumn
            // 
            this.creboDataGridViewTextBoxColumn.DataPropertyName = "crebo";
            this.creboDataGridViewTextBoxColumn.HeaderText = "crebo";
            this.creboDataGridViewTextBoxColumn.Name = "creboDataGridViewTextBoxColumn";
            // 
            // kwalificatieDataGridViewTextBoxColumn
            // 
            this.kwalificatieDataGridViewTextBoxColumn.DataPropertyName = "kwalificatie";
            this.kwalificatieDataGridViewTextBoxColumn.HeaderText = "kwalificatie";
            this.kwalificatieDataGridViewTextBoxColumn.Name = "kwalificatieDataGridViewTextBoxColumn";
            // 
            // uitstroomDataGridViewTextBoxColumn
            // 
            this.uitstroomDataGridViewTextBoxColumn.DataPropertyName = "uitstroom";
            this.uitstroomDataGridViewTextBoxColumn.HeaderText = "uitstroom";
            this.uitstroomDataGridViewTextBoxColumn.Name = "uitstroomDataGridViewTextBoxColumn";
            // 
            // opleidingDataGridViewTextBoxColumn
            // 
            this.opleidingDataGridViewTextBoxColumn.DataPropertyName = "opleiding";
            this.opleidingDataGridViewTextBoxColumn.HeaderText = "opleiding";
            this.opleidingDataGridViewTextBoxColumn.Name = "opleidingDataGridViewTextBoxColumn";
            // 
            // niveauDataGridViewTextBoxColumn
            // 
            this.niveauDataGridViewTextBoxColumn.DataPropertyName = "niveau";
            this.niveauDataGridViewTextBoxColumn.HeaderText = "niveau";
            this.niveauDataGridViewTextBoxColumn.Name = "niveauDataGridViewTextBoxColumn";
            // 
            // leerrouteDataGridViewTextBoxColumn
            // 
            this.leerrouteDataGridViewTextBoxColumn.DataPropertyName = "leerroute";
            this.leerrouteDataGridViewTextBoxColumn.HeaderText = "leerroute";
            this.leerrouteDataGridViewTextBoxColumn.Name = "leerrouteDataGridViewTextBoxColumn";
            // 
            // kenniscentrumDataGridViewTextBoxColumn
            // 
            this.kenniscentrumDataGridViewTextBoxColumn.DataPropertyName = "kenniscentrum";
            this.kenniscentrumDataGridViewTextBoxColumn.HeaderText = "kenniscentrum";
            this.kenniscentrumDataGridViewTextBoxColumn.Name = "kenniscentrumDataGridViewTextBoxColumn";
            // 
            // cohortDataGridViewTextBoxColumn
            // 
            this.cohortDataGridViewTextBoxColumn.DataPropertyName = "cohort";
            this.cohortDataGridViewTextBoxColumn.HeaderText = "cohort";
            this.cohortDataGridViewTextBoxColumn.Name = "cohortDataGridViewTextBoxColumn";
            // 
            // kdVersieDataGridViewTextBoxColumn
            // 
            this.kdVersieDataGridViewTextBoxColumn.DataPropertyName = "kd versie";
            this.kdVersieDataGridViewTextBoxColumn.HeaderText = "kd versie";
            this.kdVersieDataGridViewTextBoxColumn.Name = "kdVersieDataGridViewTextBoxColumn";
            // 
            // examenprofielDataGridViewTextBoxColumn
            // 
            this.examenprofielDataGridViewTextBoxColumn.DataPropertyName = "examenprofiel";
            this.examenprofielDataGridViewTextBoxColumn.HeaderText = "examenprofiel";
            this.examenprofielDataGridViewTextBoxColumn.Name = "examenprofielDataGridViewTextBoxColumn";
            // 
            // explanDataGridViewTextBoxColumn
            // 
            this.explanDataGridViewTextBoxColumn.DataPropertyName = "explan";
            this.explanDataGridViewTextBoxColumn.HeaderText = "explan";
            this.explanDataGridViewTextBoxColumn.Name = "explanDataGridViewTextBoxColumn";
            // 
            // portefeuillehouderDataGridViewTextBoxColumn
            // 
            this.portefeuillehouderDataGridViewTextBoxColumn.DataPropertyName = "portefeuillehouder";
            this.portefeuillehouderDataGridViewTextBoxColumn.HeaderText = "portefeuillehouder";
            this.portefeuillehouderDataGridViewTextBoxColumn.Name = "portefeuillehouderDataGridViewTextBoxColumn";
            // 
            // aanspreekpuntDataGridViewTextBoxColumn
            // 
            this.aanspreekpuntDataGridViewTextBoxColumn.DataPropertyName = "aanspreekpunt";
            this.aanspreekpuntDataGridViewTextBoxColumn.HeaderText = "aanspreekpunt";
            this.aanspreekpuntDataGridViewTextBoxColumn.Name = "aanspreekpuntDataGridViewTextBoxColumn";
            // 
            // managerDataGridViewTextBoxColumn
            // 
            this.managerDataGridViewTextBoxColumn.DataPropertyName = "manager";
            this.managerDataGridViewTextBoxColumn.HeaderText = "manager";
            this.managerDataGridViewTextBoxColumn.Name = "managerDataGridViewTextBoxColumn";
            // 
            // gecontroleerdDataGridViewTextBoxColumn
            // 
            this.gecontroleerdDataGridViewTextBoxColumn.DataPropertyName = "gecontroleerd";
            this.gecontroleerdDataGridViewTextBoxColumn.HeaderText = "gecontroleerd";
            this.gecontroleerdDataGridViewTextBoxColumn.Name = "gecontroleerdDataGridViewTextBoxColumn";
            this.gecontroleerdDataGridViewTextBoxColumn.Visible = false;
            // 
            // overzichtBindingSource
            // 
            this.overzichtBindingSource.DataMember = "overzicht";
            this.overzichtBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.overzichtBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(711, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(725, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openenToolStripMenuItem,
            this.exporterenToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.bestandToolStripMenuItem.Text = "Bestand";
            // 
            // openenToolStripMenuItem
            // 
            this.openenToolStripMenuItem.Name = "openenToolStripMenuItem";
            this.openenToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.openenToolStripMenuItem.Text = "Openen";
            // 
            // exporterenToolStripMenuItem
            // 
            this.exporterenToolStripMenuItem.Name = "exporterenToolStripMenuItem";
            this.exporterenToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exporterenToolStripMenuItem.Text = "Exporteren als..";
            this.exporterenToolStripMenuItem.Click += new System.EventHandler(this.exporteren_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exitToolStripMenuItem.Text = "Afsluiten";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.handleidingToolStripMenuItem,
            this.versieToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // handleidingToolStripMenuItem
            // 
            this.handleidingToolStripMenuItem.Name = "handleidingToolStripMenuItem";
            this.handleidingToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.handleidingToolStripMenuItem.Text = "Handleiding";
            // 
            // versieToolStripMenuItem
            // 
            this.versieToolStripMenuItem.Name = "versieToolStripMenuItem";
            this.versieToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.versieToolStripMenuItem.Text = "Versie";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.aanpassenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItem1.Text = "Gecontroleerd";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.gecontroleerd_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItem2.Text = "Niet gecontroleerd";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.niet_Gecontroleerd_Click);
            // 
            // aanpassenToolStripMenuItem
            // 
            this.aanpassenToolStripMenuItem.Name = "aanpassenToolStripMenuItem";
            this.aanpassenToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.aanpassenToolStripMenuItem.Text = "Aanpassen..";
            this.aanpassenToolStripMenuItem.Click += new System.EventHandler(this.aanpassen_Click);
            // 
            // overzichtTableAdapter
            // 
            this.overzichtTableAdapter.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 475);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Cohort Archivering 2013";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overzichtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem handleidingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versieToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem aanpassenToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNieuw;
        private System.Windows.Forms.Button buttonOpslaan;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource overzichtBindingSource;
        private DatabaseDataSetTableAdapters.overzichtTableAdapter overzichtTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creboDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kwalificatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uitstroomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opleidingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn niveauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leerrouteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kenniscentrumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cohortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdVersieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examenprofielDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn explanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portefeuillehouderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aanspreekpuntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gecontroleerdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}