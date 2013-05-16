namespace Cohort_Archivering
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private int examenAantal = 0;
        private int huidigExamen = 0;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreboCode = new System.Windows.Forms.Label();
            this.OpleidingsNaam = new System.Windows.Forms.Label();
            this.Kwalificatie = new System.Windows.Forms.Label();
            this.Uitstroom = new System.Windows.Forms.Label();
            this.Niveau = new System.Windows.Forms.Label();
            this.Leerroute = new System.Windows.Forms.Label();
            this.Kenniscentrum = new System.Windows.Forms.Label();
            this.Cohort = new System.Windows.Forms.Label();
            this.KdVersie = new System.Windows.Forms.Label();
            this.ExamenProfiel = new System.Windows.Forms.Label();
            this.Aanspreekpunt = new System.Windows.Forms.Label();
            this.Manager = new System.Windows.Forms.Label();
            this.PortHouder = new System.Windows.Forms.Label();
            this.ExamenPlan = new System.Windows.Forms.Label();
            this.ExamenPlanBox = new System.Windows.Forms.TextBox();
            this.CreboBox = new System.Windows.Forms.TextBox();
            this.OpleidingBox = new System.Windows.Forms.TextBox();
            this.KwalificatieBox = new System.Windows.Forms.TextBox();
            this.UitstroomBox = new System.Windows.Forms.TextBox();
            this.CohortBox = new System.Windows.Forms.TextBox();
            this.KdVersieBox = new System.Windows.Forms.TextBox();
            this.AanspreekBox = new System.Windows.Forms.TextBox();
            this.ManagerBox = new System.Windows.Forms.TextBox();
            this.PortHouderBox = new System.Windows.Forms.TextBox();
            this.NiveauBox = new System.Windows.Forms.ComboBox();
            this.LeerrouteBox = new System.Windows.Forms.ComboBox();
            this.KenniscentrumBox = new System.Windows.Forms.ComboBox();
            this.ExamenProfielBox = new System.Windows.Forms.ComboBox();
            this.OpslaanButton = new System.Windows.Forms.Button();
            this.OpslaanPlusButton = new System.Windows.Forms.Button();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.ExamPlusButton = new System.Windows.Forms.Button();
            this.ExamMinButton = new System.Windows.Forms.Button();
            this.ExamenPaneel = new System.Windows.Forms.Panel();
            this.nextExamButton = new System.Windows.Forms.Button();
            this.PrevExamButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.functiesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.bestandToolStripMenuItem.Text = "Bestand";
            // 
            // functiesToolStripMenuItem
            // 
            this.functiesToolStripMenuItem.Name = "functiesToolStripMenuItem";
            this.functiesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.functiesToolStripMenuItem.Text = "Functies";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // CreboCode
            // 
            this.CreboCode.AutoSize = true;
            this.CreboCode.Location = new System.Drawing.Point(10, 40);
            this.CreboCode.Name = "CreboCode";
            this.CreboCode.Size = new System.Drawing.Size(59, 13);
            this.CreboCode.TabIndex = 34;
            this.CreboCode.Text = "Crebocode";
            this.toolTips.SetToolTip(this.CreboCode, "De crebocode van de uitstroom zoals vermeld\r\nis in het kwalificatiedossier van he" +
        "t juiste jaar.");
            // 
            // OpleidingsNaam
            // 
            this.OpleidingsNaam.AutoSize = true;
            this.OpleidingsNaam.Location = new System.Drawing.Point(10, 130);
            this.OpleidingsNaam.Name = "OpleidingsNaam";
            this.OpleidingsNaam.Size = new System.Drawing.Size(82, 13);
            this.OpleidingsNaam.TabIndex = 33;
            this.OpleidingsNaam.Text = "Opleidingsnaam";
            this.toolTips.SetToolTip(this.OpleidingsNaam, "De opleidingsnaam zoals de naam op school\r\nwordt gehanteerd.");
            // 
            // Kwalificatie
            // 
            this.Kwalificatie.AutoSize = true;
            this.Kwalificatie.Location = new System.Drawing.Point(10, 70);
            this.Kwalificatie.Name = "Kwalificatie";
            this.Kwalificatie.Size = new System.Drawing.Size(60, 13);
            this.Kwalificatie.TabIndex = 31;
            this.Kwalificatie.Text = "Kwalificatie";
            this.toolTips.SetToolTip(this.Kwalificatie, "De officiële benaming van het kwalificatiedossier voor \r\nhet betrefende jaar.");
            // 
            // Uitstroom
            // 
            this.Uitstroom.AutoSize = true;
            this.Uitstroom.Location = new System.Drawing.Point(10, 100);
            this.Uitstroom.Name = "Uitstroom";
            this.Uitstroom.Size = new System.Drawing.Size(51, 13);
            this.Uitstroom.TabIndex = 29;
            this.Uitstroom.Text = "Uitstroom";
            this.toolTips.SetToolTip(this.Uitstroom, "De benaming van het uitstroomprofiel\r\nvanuit het kwalificatiedossier");
            // 
            // Niveau
            // 
            this.Niveau.AutoSize = true;
            this.Niveau.Location = new System.Drawing.Point(10, 160);
            this.Niveau.Name = "Niveau";
            this.Niveau.Size = new System.Drawing.Size(41, 13);
            this.Niveau.TabIndex = 27;
            this.Niveau.Text = "Niveau";
            this.toolTips.SetToolTip(this.Niveau, "Het MBO Niveau van de opleiding.");
            // 
            // Leerroute
            // 
            this.Leerroute.AutoSize = true;
            this.Leerroute.Location = new System.Drawing.Point(10, 190);
            this.Leerroute.Name = "Leerroute";
            this.Leerroute.Size = new System.Drawing.Size(52, 13);
            this.Leerroute.TabIndex = 22;
            this.Leerroute.Text = "Leerroute";
            this.toolTips.SetToolTip(this.Leerroute, "Het type leerroute dat gehanteerd wordt bij de opleiding.");
            // 
            // Kenniscentrum
            // 
            this.Kenniscentrum.AutoSize = true;
            this.Kenniscentrum.Location = new System.Drawing.Point(10, 220);
            this.Kenniscentrum.Name = "Kenniscentrum";
            this.Kenniscentrum.Size = new System.Drawing.Size(77, 13);
            this.Kenniscentrum.TabIndex = 32;
            this.Kenniscentrum.Text = "Kenniscentrum";
            this.toolTips.SetToolTip(this.Kenniscentrum, "Het kenniscentrum waartoe de opleiding behoort.");
            // 
            // Cohort
            // 
            this.Cohort.AutoSize = true;
            this.Cohort.Location = new System.Drawing.Point(10, 250);
            this.Cohort.Name = "Cohort";
            this.Cohort.Size = new System.Drawing.Size(38, 13);
            this.Cohort.TabIndex = 30;
            this.Cohort.Text = "Cohort";
            this.toolTips.SetToolTip(this.Cohort, "Start wanneer de student is begonnen met de\r\nopleiding (bijv. 2009).");
            // 
            // KdVersie
            // 
            this.KdVersie.AutoSize = true;
            this.KdVersie.Location = new System.Drawing.Point(10, 280);
            this.KdVersie.Name = "KdVersie";
            this.KdVersie.Size = new System.Drawing.Size(51, 13);
            this.KdVersie.TabIndex = 28;
            this.KdVersie.Text = "Kd versie";
            this.toolTips.SetToolTip(this.KdVersie, "Dit kan afwijken van het cohort.");
            // 
            // ExamenProfiel
            // 
            this.ExamenProfiel.AutoSize = true;
            this.ExamenProfiel.Location = new System.Drawing.Point(10, 310);
            this.ExamenProfiel.Name = "ExamenProfiel";
            this.ExamenProfiel.Size = new System.Drawing.Size(73, 13);
            this.ExamenProfiel.TabIndex = 25;
            this.ExamenProfiel.Text = "Examenprofiel";
            this.toolTips.SetToolTip(this.ExamenProfiel, "Het Examenplan van de opleiding.");
            // 
            // Aanspreekpunt
            // 
            this.Aanspreekpunt.AutoSize = true;
            this.Aanspreekpunt.Location = new System.Drawing.Point(10, 400);
            this.Aanspreekpunt.Name = "Aanspreekpunt";
            this.Aanspreekpunt.Size = new System.Drawing.Size(79, 13);
            this.Aanspreekpunt.TabIndex = 24;
            this.Aanspreekpunt.Text = "Aanspreekpunt";
            this.toolTips.SetToolTip(this.Aanspreekpunt, "Het aanspreekpunt van de opleiding.");
            // 
            // Manager
            // 
            this.Manager.AutoSize = true;
            this.Manager.Location = new System.Drawing.Point(10, 430);
            this.Manager.Name = "Manager";
            this.Manager.Size = new System.Drawing.Size(49, 13);
            this.Manager.TabIndex = 23;
            this.Manager.Text = "Manager";
            this.toolTips.SetToolTip(this.Manager, "De manager van de opleiding.");
            // 
            // PortHouder
            // 
            this.PortHouder.AutoSize = true;
            this.PortHouder.Location = new System.Drawing.Point(10, 370);
            this.PortHouder.Name = "PortHouder";
            this.PortHouder.Size = new System.Drawing.Size(92, 13);
            this.PortHouder.TabIndex = 34;
            this.PortHouder.Text = "Portefeuillehouder";
            this.toolTips.SetToolTip(this.PortHouder, "Degene die de portefeuille van deze opleiding beheert.");
            // 
            // ExamenPlan
            // 
            this.ExamenPlan.AutoSize = true;
            this.ExamenPlan.Location = new System.Drawing.Point(10, 340);
            this.ExamenPlan.Name = "ExamenPlan";
            this.ExamenPlan.Size = new System.Drawing.Size(69, 13);
            this.ExamenPlan.TabIndex = 25;
            this.ExamenPlan.Text = "Examen Plan";
            // 
            // ExamenPlanBox
            // 
            this.ExamenPlanBox.Location = new System.Drawing.Point(110, 337);
            this.ExamenPlanBox.Name = "ExamenPlanBox";
            this.ExamenPlanBox.Size = new System.Drawing.Size(160, 20);
            this.ExamenPlanBox.TabIndex = 7;
            // 
            // CreboBox
            // 
            this.CreboBox.Location = new System.Drawing.Point(110, 37);
            this.CreboBox.Name = "CreboBox";
            this.CreboBox.Size = new System.Drawing.Size(160, 20);
            this.CreboBox.TabIndex = 20;
            this.CreboBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // OpleidingBox
            // 
            this.OpleidingBox.Location = new System.Drawing.Point(110, 127);
            this.OpleidingBox.Name = "OpleidingBox";
            this.OpleidingBox.Size = new System.Drawing.Size(160, 20);
            this.OpleidingBox.TabIndex = 19;
            // 
            // KwalificatieBox
            // 
            this.KwalificatieBox.Location = new System.Drawing.Point(110, 67);
            this.KwalificatieBox.Name = "KwalificatieBox";
            this.KwalificatieBox.Size = new System.Drawing.Size(160, 20);
            this.KwalificatieBox.TabIndex = 18;
            // 
            // UitstroomBox
            // 
            this.UitstroomBox.Location = new System.Drawing.Point(110, 97);
            this.UitstroomBox.Name = "UitstroomBox";
            this.UitstroomBox.Size = new System.Drawing.Size(160, 20);
            this.UitstroomBox.TabIndex = 17;
            // 
            // CohortBox
            // 
            this.CohortBox.Location = new System.Drawing.Point(110, 247);
            this.CohortBox.Name = "CohortBox";
            this.CohortBox.Size = new System.Drawing.Size(160, 20);
            this.CohortBox.TabIndex = 16;
            // 
            // KdVersieBox
            // 
            this.KdVersieBox.Location = new System.Drawing.Point(110, 277);
            this.KdVersieBox.Name = "KdVersieBox";
            this.KdVersieBox.Size = new System.Drawing.Size(160, 20);
            this.KdVersieBox.TabIndex = 15;
            // 
            // AanspreekBox
            // 
            this.AanspreekBox.Location = new System.Drawing.Point(110, 397);
            this.AanspreekBox.Name = "AanspreekBox";
            this.AanspreekBox.Size = new System.Drawing.Size(160, 20);
            this.AanspreekBox.TabIndex = 12;
            // 
            // ManagerBox
            // 
            this.ManagerBox.Location = new System.Drawing.Point(110, 427);
            this.ManagerBox.Name = "ManagerBox";
            this.ManagerBox.Size = new System.Drawing.Size(160, 20);
            this.ManagerBox.TabIndex = 11;
            // 
            // PortHouderBox
            // 
            this.PortHouderBox.Location = new System.Drawing.Point(110, 367);
            this.PortHouderBox.Name = "PortHouderBox";
            this.PortHouderBox.Size = new System.Drawing.Size(160, 20);
            this.PortHouderBox.TabIndex = 20;
            this.PortHouderBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NiveauBox
            // 
            this.NiveauBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NiveauBox.FormattingEnabled = true;
            this.NiveauBox.Items.AddRange(new object[] {
            1,
            2,
            3,
            4});
            this.NiveauBox.Location = new System.Drawing.Point(110, 157);
            this.NiveauBox.Name = "NiveauBox";
            this.NiveauBox.Size = new System.Drawing.Size(160, 21);
            this.NiveauBox.TabIndex = 10;
            // 
            // LeerrouteBox
            // 
            this.LeerrouteBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LeerrouteBox.FormattingEnabled = true;
            this.LeerrouteBox.Items.AddRange(new object[] {
            "BBL",
            "BOL",
            "BOL-dt"});
            this.LeerrouteBox.Location = new System.Drawing.Point(110, 187);
            this.LeerrouteBox.Name = "LeerrouteBox";
            this.LeerrouteBox.Size = new System.Drawing.Size(160, 21);
            this.LeerrouteBox.TabIndex = 9;
            // 
            // KenniscentrumBox
            // 
            this.KenniscentrumBox.FormattingEnabled = true;
            this.KenniscentrumBox.Items.AddRange(new object[] {
            "Aequor",
            "Calibris",
            "ECABO",
            "Fundeon",
            "Kenniscentrum GOC",
            "Innovam Groep",
            "Kenniscentrum Handel",
            "Kenteq",
            "KOC Nederland",
            "Kenniscentrum PMLF",
            "Savantis",
            "Kenniscentrum SH&M",
            "SVGB kennis- en opleidingscentrum",
            "SVO",
            "VOC",
            "VTL"});
            this.KenniscentrumBox.Location = new System.Drawing.Point(110, 217);
            this.KenniscentrumBox.Name = "KenniscentrumBox";
            this.KenniscentrumBox.Size = new System.Drawing.Size(160, 21);
            this.KenniscentrumBox.TabIndex = 8;
            // 
            // ExamenProfielBox
            // 
            this.ExamenProfielBox.FormattingEnabled = true;
            this.ExamenProfielBox.Items.AddRange(new object[] {
            "AKA (Arbeidsmarktgekwalificeerd Assistent)",
            "BHI-Infra (Bouw, Hout, Interieur en Infratechniek)",
            "BOA/RPC (Bescherming, Onderhoud & Afbouw en Reclame, Presentatie & Communicatie)",
            "C&M (Communicatie & Media)",
            "ESB&I (Economisch-Administratieve beroepen, Sociaal-Juridische dienstverlening, B" +
                "eveiliging & ICT)",
            "GTB&A (Gezondheidstechnische Beroepen en Ambachten)",
            "Groen",
            "Handel en MITT  ",
            "HTVF (Horeca, Toerisme & Recreatie, Voeding en Facilitaire Dienstverlening)",
            "MCT (Motorvoertuigen-, Carrosserie- en Tweewielertechniek)",
            "MEI (Metaal, Elektrotechniek en Installatietechniek)",
            "PMLF (Procestechniek, Algemene Operationele Techniek, Milieutechniek, Laboratoriu" +
                "mtechniek, Fotonica en Textiel)",
            "SVO",
            "T&L (Transport en Logistiek)  ",
            "Uiterlijke verzorging (UV en Grimeurs)",
            "ZWS (Zorg, Welzijn en Sport)"});
            this.ExamenProfielBox.Location = new System.Drawing.Point(110, 307);
            this.ExamenProfielBox.Name = "ExamenProfielBox";
            this.ExamenProfielBox.Size = new System.Drawing.Size(160, 21);
            this.ExamenProfielBox.TabIndex = 7;
            // 
            // OpslaanButton
            // 
            this.OpslaanButton.Location = new System.Drawing.Point(14, 460);
            this.OpslaanButton.Name = "OpslaanButton";
            this.OpslaanButton.Size = new System.Drawing.Size(75, 23);
            this.OpslaanButton.TabIndex = 6;
            this.OpslaanButton.Text = "Opslaan ";
            this.toolTips.SetToolTip(this.OpslaanButton, "De ingevulde gegevens worden opgeslagen en krijgt u het overzicht te zien.");
            this.OpslaanButton.UseVisualStyleBackColor = true;
            // 
            // OpslaanPlusButton
            // 
            this.OpslaanPlusButton.Location = new System.Drawing.Point(110, 460);
            this.OpslaanPlusButton.Name = "OpslaanPlusButton";
            this.OpslaanPlusButton.Size = new System.Drawing.Size(173, 23);
            this.OpslaanPlusButton.TabIndex = 5;
            this.OpslaanPlusButton.Text = "Opslaan en Volgende Invoer";
            this.toolTips.SetToolTip(this.OpslaanPlusButton, "De ingevulde gegevens worden opgeslagen en het formulier wordt leeggemaakt");
            this.OpslaanPlusButton.UseVisualStyleBackColor = true;
            this.OpslaanPlusButton.Click += new System.EventHandler(this.OpslaanPlusButton_Click);
            // 
            // ExamPlusButton
            // 
            this.ExamPlusButton.Location = new System.Drawing.Point(440, 457);
            this.ExamPlusButton.Name = "ExamPlusButton";
            this.ExamPlusButton.Size = new System.Drawing.Size(138, 23);
            this.ExamPlusButton.TabIndex = 2;
            this.ExamPlusButton.Text = "Voeg een examen toe";
            this.ExamPlusButton.UseVisualStyleBackColor = true;
            this.ExamPlusButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExamMinButton
            // 
            this.ExamMinButton.Location = new System.Drawing.Point(598, 457);
            this.ExamMinButton.Name = "ExamMinButton";
            this.ExamMinButton.Size = new System.Drawing.Size(130, 23);
            this.ExamMinButton.TabIndex = 3;
            this.ExamMinButton.Text = "Verwijder een Examen";
            this.ExamMinButton.UseVisualStyleBackColor = true;
            this.ExamMinButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ExamenPaneel
            // 
            this.ExamenPaneel.AutoScroll = true;
            this.ExamenPaneel.BackColor = System.Drawing.Color.Silver;
            this.ExamenPaneel.Location = new System.Drawing.Point(400, 40);
            this.ExamenPaneel.Name = "ExamenPaneel";
            this.ExamenPaneel.Size = new System.Drawing.Size(360, 373);
            this.ExamenPaneel.TabIndex = 4;
            // 
            // nextExamButton
            // 
            this.nextExamButton.Enabled = false;
            this.nextExamButton.Location = new System.Drawing.Point(667, 419);
            this.nextExamButton.Name = "nextExamButton";
            this.nextExamButton.Size = new System.Drawing.Size(75, 23);
            this.nextExamButton.TabIndex = 1;
            this.nextExamButton.Text = "Volgende";
            this.nextExamButton.UseVisualStyleBackColor = true;
            this.nextExamButton.Visible = false;
            this.nextExamButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // PrevExamButton
            // 
            this.PrevExamButton.Enabled = false;
            this.PrevExamButton.Location = new System.Drawing.Point(420, 419);
            this.PrevExamButton.Name = "PrevExamButton";
            this.PrevExamButton.Size = new System.Drawing.Size(75, 23);
            this.PrevExamButton.TabIndex = 0;
            this.PrevExamButton.Text = "Vorige";
            this.PrevExamButton.UseVisualStyleBackColor = true;
            this.PrevExamButton.Visible = false;
            this.PrevExamButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.PrevExamButton);
            this.Controls.Add(this.nextExamButton);
            this.Controls.Add(this.ExamPlusButton);
            this.Controls.Add(this.ExamMinButton);
            this.Controls.Add(this.ExamenPaneel);
            this.Controls.Add(this.OpslaanPlusButton);
            this.Controls.Add(this.OpslaanButton);
            this.Controls.Add(this.ExamenProfielBox);
            this.Controls.Add(this.KenniscentrumBox);
            this.Controls.Add(this.LeerrouteBox);
            this.Controls.Add(this.NiveauBox);
            this.Controls.Add(this.ManagerBox);
            this.Controls.Add(this.AanspreekBox);
            this.Controls.Add(this.KdVersieBox);
            this.Controls.Add(this.CohortBox);
            this.Controls.Add(this.UitstroomBox);
            this.Controls.Add(this.KwalificatieBox);
            this.Controls.Add(this.OpleidingBox);
            this.Controls.Add(this.CreboBox);
            this.Controls.Add(this.Leerroute);
            this.Controls.Add(this.Manager);
            this.Controls.Add(this.Aanspreekpunt);
            this.Controls.Add(this.ExamenProfiel);
            this.Controls.Add(this.Niveau);
            this.Controls.Add(this.KdVersie);
            this.Controls.Add(this.Uitstroom);
            this.Controls.Add(this.Cohort);
            this.Controls.Add(this.Kwalificatie);
            this.Controls.Add(this.Kenniscentrum);
            this.Controls.Add(this.OpleidingsNaam);
            this.Controls.Add(this.CreboCode);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.PortHouder);
            this.Controls.Add(this.PortHouderBox);
            this.Controls.Add(this.ExamenPlan);
            this.Controls.Add(this.ExamenPlanBox);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Cohort Archivering";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            examenPlus();
       }

        #endregion

        private void examenPlus()
        {
            if (examenAantal < 10)
            {
                // Maakt objecten aan voor de nieuwe ui elementen.
                ExamenBlok[examenAantal] = new System.Windows.Forms.Panel();
                ExamenTitle[examenAantal] = new System.Windows.Forms.Label();
                ExamenNummer[examenAantal] = new System.Windows.Forms.Label();
                ExamenNummerBox[examenAantal] = new System.Windows.Forms.TextBox();
                Examen[examenAantal] = new System.Windows.Forms.Label();
                ExamenBox[examenAantal] = new System.Windows.Forms.TextBox();
                Constructeur[examenAantal] = new System.Windows.Forms.Label();
                ConstructeurBox[examenAantal] = new System.Windows.Forms.TextBox();
                PeriodeAfname[examenAantal] = new System.Windows.Forms.Label();
                PeriodeAfnameBox[examenAantal] = new System.Windows.Forms.ComboBox();
                Locatie[examenAantal] = new System.Windows.Forms.Label();
                LocatieBox[examenAantal] = new System.Windows.Forms.TextBox();
                NaamOpdracht[examenAantal] = new System.Windows.Forms.Label();
                NaamOpdrachtBox[examenAantal] = new System.Windows.Forms.TextBox();
                StatusOpdracht[examenAantal] = new System.Windows.Forms.Label();
                StatusOpdrachtBox[examenAantal] = new System.Windows.Forms.ComboBox();
                         
                
               
                
                // 
                // Examen Blok
                //
                if (examenAantal == 0)
                {
                    this.ExamenBlok[examenAantal].Location = new System.Drawing.Point(0, 0);
                }
                else
                {
                    this.ExamenBlok[examenAantal].Location = new System.Drawing.Point(this.ExamenPaneel.AutoScrollPosition.X + (360 * examenAantal), 0);
                }                
                this.ExamenBlok[examenAantal].Name = "ExamenBlok";
                this.ExamenBlok[examenAantal].Size = new System.Drawing.Size(360, 370);
                this.ExamenBlok[examenAantal].AutoSize = true;
                // 
                // Examen Titel
                // 
                this.ExamenTitle[examenAantal].AutoSize = true;
                this.ExamenTitle[examenAantal].Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.ExamenTitle[examenAantal].Location = new System.Drawing.Point(15, 20);
                this.ExamenTitle[examenAantal].Name = "ExamenTitle";
                this.ExamenTitle[examenAantal].Size = new System.Drawing.Size(63, 16);
                this.ExamenTitle[examenAantal].Text = "Examen " + (examenAantal + 1);
                // 
                // Examen Label
                // 
                this.Examen[examenAantal].AutoSize = true;
                this.Examen[examenAantal].Location = new System.Drawing.Point(15, 50);
                this.Examen[examenAantal].Name = "Examen";
                this.Examen[examenAantal].Size = new System.Drawing.Size(45, 13);
                this.Examen[examenAantal].Text = "Examenvak";
                this.toolTips.SetToolTip(this.Examen[examenAantal], "Het vak waartoe het examen behoort");
                // 
                // Examen Box
                // 
                this.ExamenBox[examenAantal].Location = new System.Drawing.Point(120, 47);
                this.ExamenBox[examenAantal].Name = "ExamenBox";
                this.ExamenBox[examenAantal].Size = new System.Drawing.Size(160, 20);
                //
                // Examen Nummer Label
                //
                this.ExamenNummer[examenAantal].AutoSize = true;
                this.ExamenNummer[examenAantal].Location = new System.Drawing.Point(15, 80);
                this.ExamenNummer[examenAantal].Name = "Examennummer";
                this.ExamenNummer[examenAantal].Size = new System.Drawing.Size(84, 13);
                this.ExamenNummer[examenAantal].Text = "Examennummer";
                toolTips.SetToolTip(this.ExamenNummer[examenAantal], "Het nummer dat tot het examen behoort");
                //
                // Examen Nummer Box
                //
                this.ExamenNummerBox[examenAantal].Location = new System.Drawing.Point(120, 77);
                this.ExamenNummerBox[examenAantal].Name = "ExamennummerBox";
                this.ExamenNummerBox[examenAantal].Size = new System.Drawing.Size(160, 20);
                
                //
                // Constructeur Label
                //
                this.Constructeur[examenAantal].AutoSize = true;
                this.Constructeur[examenAantal].Location = new System.Drawing.Point(15, 110);
                this.Constructeur[examenAantal].Name = "Constructeur";
                this.Constructeur[examenAantal].Size = new System.Drawing.Size(84, 13);
                this.Constructeur[examenAantal].Text = "Constructeur";
                toolTips.SetToolTip(this.Constructeur[examenAantal], "De Constructeur van het examen");
                //
                // Constructeur Box
                //
                this.ConstructeurBox[examenAantal].Location = new System.Drawing.Point(120, 107);
                this.ConstructeurBox[examenAantal].Name = "Constructeur";
                this.ConstructeurBox[examenAantal].Size = new System.Drawing.Size(160, 20);
                // 
                // Periode Afname Label
                // 
                this.PeriodeAfname[examenAantal].AutoSize = true;
                this.PeriodeAfname[examenAantal].Location = new System.Drawing.Point(15, 140);
                this.PeriodeAfname[examenAantal].Name = "PeriodeAfname";
                this.PeriodeAfname[examenAantal].Size = new System.Drawing.Size(82, 13);
                this.PeriodeAfname[examenAantal].Text = "Periode Afname";
                this.toolTips.SetToolTip(this.PeriodeAfname[examenAantal], "De periode waarin het examen wordt afgenomen.");
                // 
                // Periode Afname Box
                // 
                this.PeriodeAfnameBox[examenAantal].FormattingEnabled = true;
                this.PeriodeAfnameBox[examenAantal].DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.PeriodeAfnameBox[examenAantal].Items.AddRange(new object[] {
            "p1",
            "p2","p3","p4","p5","p6","p7","p8","p9","p10","p11","p12","p13","p14","p15","p16"});
                this.PeriodeAfnameBox[examenAantal].Location = new System.Drawing.Point(120, 137);
                this.PeriodeAfnameBox[examenAantal].Name = "PeriodeAfnameBox";
                this.PeriodeAfnameBox[examenAantal].Size = new System.Drawing.Size(160, 21);
                //
                // Locatie Label
                //
                this.Locatie[examenAantal].AutoSize = true;
                this.Locatie[examenAantal].Location = new System.Drawing.Point(15, 170);
                this.Locatie[examenAantal].Name = "Locatie";
                this.Locatie[examenAantal].Size = new System.Drawing.Size(84, 13);
                this.Locatie[examenAantal].Text = "Locatie";
                toolTips.SetToolTip(this.Locatie[examenAantal], "De Locatie waar het examen plaats zal vinden");
                //
                // Locatie Box
                //
                this.LocatieBox[examenAantal].Location = new System.Drawing.Point(120, 167);
                this.LocatieBox[examenAantal].Name = "Locatie";
                this.LocatieBox[examenAantal].Size = new System.Drawing.Size(160, 20);
                // 
                // Naam Opdracht Label
                // 
                this.NaamOpdracht[examenAantal].AutoSize = true;
                this.NaamOpdracht[examenAantal].Location = new System.Drawing.Point(15, 200);
                this.NaamOpdracht[examenAantal].Name = "NaamOpdracht";
                this.NaamOpdracht[examenAantal].Size = new System.Drawing.Size(82, 13);
                this.NaamOpdracht[examenAantal].Text = "Naam Opdracht";
                this.toolTips.SetToolTip(this.NaamOpdracht[examenAantal], "De naam van de examenopdracht.");
                // 
                // Naam Opdracht Box
                // 
                this.NaamOpdrachtBox[examenAantal].Location = new System.Drawing.Point(120, 197);
                this.NaamOpdrachtBox[examenAantal].Name = "NaamOpdrachtBox";
                this.NaamOpdrachtBox[examenAantal].Size = new System.Drawing.Size(160, 20);
                // 
                // Status Opdracht Label
                // 
                this.StatusOpdracht[examenAantal].AutoSize = true;
                this.StatusOpdracht[examenAantal].Location = new System.Drawing.Point(15, 230);
                this.StatusOpdracht[examenAantal].Name = "StatusOpdracht";
                this.StatusOpdracht[examenAantal].Size = new System.Drawing.Size(84, 13);
                this.StatusOpdracht[examenAantal].Text = "Status Opdracht";
                toolTips.SetToolTip(this.StatusOpdracht[examenAantal], "Het status van de examenopdracht.");
                // 
                // Status Opdracht Box
                // 
                this.StatusOpdrachtBox[examenAantal].FormattingEnabled = true;
                this.StatusOpdrachtBox[examenAantal].Items.AddRange(new object[] {
            
                "Niet aanwezig",
                "Geconstrueerd",
                "Gecontroleerd",
                "Vastgesteld"});
                this.StatusOpdrachtBox[examenAantal].Location = new System.Drawing.Point(120, 227);
                this.StatusOpdrachtBox[examenAantal].Name = "StatusOpdrachtBox";
                this.StatusOpdrachtBox[examenAantal].Size = new System.Drawing.Size(160, 21);                
                

                // De elementen worden toegevoegd aan de userinterface
                this.ExamenPaneel.Controls.Add(this.ExamenBlok[examenAantal]);
                this.ExamenBlok[examenAantal].Controls.Add(this.ExamenTitle[examenAantal]);
                this.ExamenBlok[examenAantal].Controls.Add(this.ExamenNummer[examenAantal]);
                this.ExamenBlok[examenAantal].Controls.Add(this.ExamenNummerBox[examenAantal]);
                this.ExamenBlok[examenAantal].Controls.Add(this.Examen[examenAantal]);
                this.ExamenBlok[examenAantal].Controls.Add(this.ExamenBox[examenAantal]);
                this.ExamenBlok[examenAantal].Controls.Add(this.Constructeur[examenAantal]);
                this.ExamenBlok[examenAantal].Controls.Add(this.ConstructeurBox[examenAantal]);
                this.ExamenBlok[examenAantal].Controls.Add(this.PeriodeAfname[examenAantal]);
                this.ExamenBlok[examenAantal].Controls.Add(this.PeriodeAfnameBox[examenAantal]);
                this.ExamenBlok[examenAantal].Controls.Add(this.Locatie[examenAantal]);
                this.ExamenBlok[examenAantal].Controls.Add(this.LocatieBox[examenAantal]);
                this.ExamenBlok[examenAantal].Controls.Add(this.NaamOpdracht[examenAantal]);
                this.ExamenBlok[examenAantal].Controls.Add(this.NaamOpdrachtBox[examenAantal]);
                this.ExamenBlok[examenAantal].Controls.Add(this.StatusOpdracht[examenAantal]);
                this.ExamenBlok[examenAantal].Controls.Add(this.StatusOpdrachtBox[examenAantal]);
                
                // Voert de functie uit om kerntaken toe te voegen
                kerntaakPlus(examenAantal);
                
                //Scrollt naar het nieuw gemaakte examen
                this.ExamenPaneel.ScrollControlIntoView(this.ExamenBlok[examenAantal]);
                if (examenAantal == 1)
                {
                    this.nextExamButton.Visible = true;
                    this.nextExamButton.Enabled = true;
                    this.PrevExamButton.Visible = true;
                    this.PrevExamButton.Enabled = true;
                }  
                huidigExamen = examenAantal;
                examenAantal++;                              
            }
        }

        // Met deze knop kan een examen verwijderen van de ui
        private void examenMin()
        {
            if (examenAantal > 1)
            {
                this.ExamenPaneel.Controls.Remove(ExamenBlok[examenAantal - 1]);
                examenAantal--;
                this.ExamenPaneel.ScrollControlIntoView(this.ExamenBlok[examenAantal - 1]);
                if (examenAantal == 1)
                {
                    this.nextExamButton.Visible = false;
                    this.nextExamButton.Enabled = false;
                    this.PrevExamButton.Visible = false;
                    this.PrevExamButton.Enabled = false;
                }
            }
        }

        // Dit is de knop die naar de volgende examen in het ui gaat
        private void NextExam()
        {
            if (huidigExamen < examenAantal - 1 && examenAantal > 1)
            {
                huidigExamen += 1;
                this.ExamenPaneel.ScrollControlIntoView(this.ExamenBlok[huidigExamen]);
            }
        }

        // Dit is de knop die naar de vorige examen in het ui gaat
        private void PrevExam()
        {
            if (huidigExamen > 0 && examenAantal > 1)
            {
                huidigExamen -= 1;
                this.ExamenPaneel.ScrollControlIntoView(this.ExamenBlok[huidigExamen]);
            }
        }

        // deze functie zorgt ervoor dat er 6 kerntaak-invulvelden aan een examen wordt toegevoegd
        private void kerntaakPlus(int exAantal)
        {
            for (int i = 0; i < 6; i++)
            {
                KerntaakBlok[exAantal, i] = new System.Windows.Forms.Panel();
                Kerntaken[exAantal, i] = new System.Windows.Forms.Label();
                KerntakenBox[exAantal, i] = new System.Windows.Forms.TextBox();
                KerntaakNr[exAantal, i] = new System.Windows.Forms.Label();
                KerntaakNrBox[exAantal, i] = new System.Windows.Forms.TextBox();
                Werkprocessen[exAantal, i] = new System.Windows.Forms.Label();
                WerkprocessenBox[exAantal, i] = new System.Windows.Forms.TextBox();

                //
                // Kerntaak Blok
                //
                if (i == 0)
                {
                    this.KerntaakBlok[exAantal, i].Location = new System.Drawing.Point(0, 230);
                }
                else
                {
                    this.KerntaakBlok[exAantal, i].Location = new System.Drawing.Point(0,(230 + (90 * i)));
                }
                this.KerntaakBlok[exAantal, i].Name = "KerntaakBlok";
                this.KerntaakBlok[exAantal, i].Size = new System.Drawing.Size(360, 120);
                // 
                // Kerntaken Label
                // 
                this.Kerntaken[exAantal, i].AutoSize = true;
                this.Kerntaken[exAantal, i].Location = new System.Drawing.Point(15, 30);
                this.Kerntaken[exAantal, i].Name = "Kerntaak";
                this.Kerntaken[exAantal, i].Size = new System.Drawing.Size(56, 13);
                this.Kerntaken[exAantal, i].Text = "Kerntaak " + (i + 1);
                this.toolTips.SetToolTip(this.Kerntaken[exAantal, i], "Een kerntaak die vereist is bij dit examen.");
                // 
                // Kerntaken Box
                // 
                this.KerntakenBox[exAantal, i].Location = new System.Drawing.Point(120, 27);
                this.KerntakenBox[exAantal, i].Name = "KerntakenBox";
                this.KerntakenBox[exAantal, i].Size = new System.Drawing.Size(160, 20);
                // 
                // Kerntaak Nr Label
                // 
                this.KerntaakNr[exAantal, i].AutoSize = true;
                this.KerntaakNr[exAantal, i].Location = new System.Drawing.Point(15, 60);
                this.KerntaakNr[exAantal, i].Name = "Kerntaak nr";
                this.KerntaakNr[exAantal, i].Size = new System.Drawing.Size(56, 13);
                this.KerntaakNr[exAantal, i].Text = "Kerntaak nr";
                this.toolTips.SetToolTip(this.KerntaakNr[exAantal, i], "Het nummer van de kerntaak.");
                // 
                // Kerntaken Nr Box
                // 
                this.KerntaakNrBox[exAantal, i].Location = new System.Drawing.Point(120, 57);
                this.KerntaakNrBox[exAantal, i].Name = "KerntakenBox";
                this.KerntaakNrBox[exAantal, i].Size = new System.Drawing.Size(160, 20);
                // 
                // Werkprocessen Label
                // 
                this.Werkprocessen[exAantal, i].AutoSize = true;
                this.Werkprocessen[exAantal, i].Location = new System.Drawing.Point(15, 90);
                this.Werkprocessen[exAantal, i].Name = "Werkprocessen";
                this.Werkprocessen[exAantal, i].Size = new System.Drawing.Size(82, 13);
                this.Werkprocessen[exAantal, i].Text = "Werkprocessen";
                this.toolTips.SetToolTip(this.Werkprocessen[exAantal, i], "De werkprocessen die vereist zijn bij dit examen.");
                // 
                // Werkprocessen Box
                // 
                this.WerkprocessenBox[exAantal, i].Location = new System.Drawing.Point(120, 87);
                this.WerkprocessenBox[exAantal, i].Name = "WerkprocessenBox";
                this.WerkprocessenBox[exAantal, i].Size = new System.Drawing.Size(160, 20);

                this.ExamenBlok[exAantal].Controls.Add(this.KerntaakBlok[exAantal, i]);
                this.KerntaakBlok[exAantal, i].Controls.Add(this.Kerntaken[exAantal, i]);
                this.KerntaakBlok[exAantal, i].Controls.Add(this.KerntakenBox[exAantal, i]);
                this.KerntaakBlok[exAantal, i].Controls.Add(this.KerntaakNr[exAantal, i]);
                this.KerntaakBlok[exAantal, i].Controls.Add(this.KerntaakNrBox[exAantal, i]);
                this.KerntaakBlok[exAantal, i].Controls.Add(this.Werkprocessen[exAantal, i]);
                this.KerntaakBlok[exAantal, i].Controls.Add(this.WerkprocessenBox[exAantal, i]);                            
            }

        }

        private void WipeForm()
        {
            while (Controls.Count > 0)
            {
                Controls[0].Dispose();
                examenAantal = 0;
            }
            InitializeComponent();
        }
        
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label CreboCode;
        private System.Windows.Forms.Label OpleidingsNaam;
        private System.Windows.Forms.Label Kwalificatie;
        private System.Windows.Forms.Label Uitstroom;
        private System.Windows.Forms.Label Niveau;
        private System.Windows.Forms.Label Leerroute;
        private System.Windows.Forms.Label Kenniscentrum;
        private System.Windows.Forms.Label Cohort;
        private System.Windows.Forms.Label KdVersie;
        private System.Windows.Forms.Label ExamenProfiel;
        private System.Windows.Forms.Label Aanspreekpunt;
        private System.Windows.Forms.Label Manager;
        private System.Windows.Forms.Label PortHouder;
        private System.Windows.Forms.Label ExamenPlan;
        private System.Windows.Forms.TextBox ExamenPlanBox;
        private System.Windows.Forms.TextBox PortHouderBox;
        private System.Windows.Forms.TextBox CreboBox;
        private System.Windows.Forms.TextBox OpleidingBox;
        private System.Windows.Forms.TextBox KwalificatieBox;
        private System.Windows.Forms.TextBox UitstroomBox;
        private System.Windows.Forms.TextBox CohortBox;
        private System.Windows.Forms.TextBox KdVersieBox;
        private System.Windows.Forms.TextBox AanspreekBox;
        private System.Windows.Forms.TextBox ManagerBox;
        private System.Windows.Forms.ComboBox NiveauBox;
        private System.Windows.Forms.ComboBox LeerrouteBox;
        private System.Windows.Forms.ComboBox KenniscentrumBox;
        private System.Windows.Forms.ComboBox ExamenProfielBox;
        private System.Windows.Forms.Button OpslaanButton;
        private System.Windows.Forms.Button OpslaanPlusButton;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.Button ExamMinButton;
        private System.Windows.Forms.Button ExamPlusButton;
        private System.Windows.Forms.Panel ExamenPaneel;
        private System.Windows.Forms.Button nextExamButton;
        private System.Windows.Forms.Button PrevExamButton;


        // Hier worden arrays aangemaakt die nodig zijn om dynamysche elementen in op te slaan
        private System.Windows.Forms.Panel[] ExamenBlok = new System.Windows.Forms.Panel[10];
        private System.Windows.Forms.Label[] ExamenTitle = new System.Windows.Forms.Label[10];
        private System.Windows.Forms.Label[] StatusOpdracht = new System.Windows.Forms.Label[10];
        private System.Windows.Forms.Label[] NaamOpdracht = new System.Windows.Forms.Label[10];
        private System.Windows.Forms.Label[] PeriodeAfname = new System.Windows.Forms.Label[10];
        private System.Windows.Forms.Panel[,] KerntaakBlok = new System.Windows.Forms.Panel[10, 6];
        private System.Windows.Forms.Label[,] Werkprocessen = new System.Windows.Forms.Label[10, 6];
        private System.Windows.Forms.Label[,] KerntaakNr = new System.Windows.Forms.Label[10, 6];
        private System.Windows.Forms.Label[,] Kerntaken = new System.Windows.Forms.Label[10, 6];
        private System.Windows.Forms.Label[] Examen = new System.Windows.Forms.Label[10];
        private System.Windows.Forms.Label[] Constructeur = new System.Windows.Forms.Label[10];
        private System.Windows.Forms.Label[] Locatie = new System.Windows.Forms.Label[10];
        private System.Windows.Forms.Label[] ExamenNummer = new System.Windows.Forms.Label[10];
        private System.Windows.Forms.ComboBox[] StatusOpdrachtBox = new System.Windows.Forms.ComboBox[10];
        private System.Windows.Forms.ComboBox[] PeriodeAfnameBox = new System.Windows.Forms.ComboBox[10];
        private System.Windows.Forms.TextBox[] NaamOpdrachtBox = new System.Windows.Forms.TextBox[10];
        private System.Windows.Forms.TextBox[,] WerkprocessenBox = new System.Windows.Forms.TextBox[10, 6];
        private System.Windows.Forms.TextBox[,] KerntaakNrBox = new System.Windows.Forms.TextBox[10, 6];
        private System.Windows.Forms.TextBox[,] KerntakenBox = new System.Windows.Forms.TextBox[10, 6];
        private System.Windows.Forms.TextBox[] ExamenBox = new System.Windows.Forms.TextBox[10];
        private System.Windows.Forms.TextBox[] ConstructeurBox = new System.Windows.Forms.TextBox[10];
        private System.Windows.Forms.TextBox[] LocatieBox = new System.Windows.Forms.TextBox[10];
        private System.Windows.Forms.TextBox[] ExamenNummerBox = new System.Windows.Forms.TextBox[10];
    }
}

