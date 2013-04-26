namespace Cohort_Archivering
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private int examenAantal = 0;
        private int BlokHoogte = 270;
        
        private System.Windows.Forms.Panel[] ExamenBlok = new System.Windows.Forms.Panel[20];
        private System.Windows.Forms.Label[] ExamenTitle = new System.Windows.Forms.Label[20];
        private System.Windows.Forms.Label[] StatusOpdracht = new System.Windows.Forms.Label[20];
        private System.Windows.Forms.Label[] NaamOpdracht = new System.Windows.Forms.Label[20];
        private System.Windows.Forms.Label[] PeriodeAfname = new System.Windows.Forms.Label[20];
        private System.Windows.Forms.Label[] Werkprocessen = new System.Windows.Forms.Label[20];
        private System.Windows.Forms.Label[] Kerntaken = new System.Windows.Forms.Label[20];
        private System.Windows.Forms.Label[] Examen = new System.Windows.Forms.Label[20];
        private System.Windows.Forms.ComboBox[] StatusOpdrachtBox = new System.Windows.Forms.ComboBox[20];
        private System.Windows.Forms.ComboBox[] PeriodeAfnameBox = new System.Windows.Forms.ComboBox[20];
        private System.Windows.Forms.TextBox[] NaamOpdrachtBox = new System.Windows.Forms.TextBox[20];
        private System.Windows.Forms.TextBox[] WerkprocessenBox = new System.Windows.Forms.TextBox[20];
        private System.Windows.Forms.TextBox[] KerntakenBox = new System.Windows.Forms.TextBox[20];
        private System.Windows.Forms.TextBox[] ExamenBox = new System.Windows.Forms.TextBox[20];

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
            this.LeerlingAantal = new System.Windows.Forms.Label();
            this.ExamenProfiel = new System.Windows.Forms.Label();
            this.Teamvoorzitter = new System.Windows.Forms.Label();
            this.Aanspreekpunt = new System.Windows.Forms.Label();
            this.Manager = new System.Windows.Forms.Label();
            this.CreboBox = new System.Windows.Forms.TextBox();
            this.OpleidingBox = new System.Windows.Forms.TextBox();
            this.KwalificatieBox = new System.Windows.Forms.TextBox();
            this.UitstroomBox = new System.Windows.Forms.TextBox();
            this.CohortBox = new System.Windows.Forms.TextBox();
            this.KdVersieBox = new System.Windows.Forms.TextBox();
            this.LeerlingAantalBox = new System.Windows.Forms.TextBox();
            this.TeamvoorzitterBox = new System.Windows.Forms.TextBox();
            this.AanspreekBox = new System.Windows.Forms.TextBox();
            this.ManagerBox = new System.Windows.Forms.TextBox();
            this.NiveauBox = new System.Windows.Forms.ComboBox();
            this.LeerrouteBox = new System.Windows.Forms.ComboBox();
            this.KenniscentrumBox = new System.Windows.Forms.ComboBox();
            this.ExamenProfielBox = new System.Windows.Forms.ComboBox();
            this.OpslaanButton = new System.Windows.Forms.Button();
            this.OpslaanPlusButton = new System.Windows.Forms.Button();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ExamenPaneel = new System.Windows.Forms.Panel();
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
            this.menuStrip1.TabIndex = 0;
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
            this.CreboCode.TabIndex = 1;
            this.CreboCode.Text = "Crebocode";
            this.toolTips.SetToolTip(this.CreboCode, "De crebocode van de uitstroom zoals vermeld\r\nis in het kwalificatiedossier van he" +
        "t juiste jaar.");
            // 
            // OpleidingsNaam
            // 
            this.OpleidingsNaam.AutoSize = true;
            this.OpleidingsNaam.Location = new System.Drawing.Point(10, 70);
            this.OpleidingsNaam.Name = "OpleidingsNaam";
            this.OpleidingsNaam.Size = new System.Drawing.Size(82, 13);
            this.OpleidingsNaam.TabIndex = 2;
            this.OpleidingsNaam.Text = "Opleidingsnaam";
            this.toolTips.SetToolTip(this.OpleidingsNaam, "De opleidingsnaam zoals de naam op school\r\nwordt gehanteerd.");
            // 
            // Kwalificatie
            // 
            this.Kwalificatie.AutoSize = true;
            this.Kwalificatie.Location = new System.Drawing.Point(10, 100);
            this.Kwalificatie.Name = "Kwalificatie";
            this.Kwalificatie.Size = new System.Drawing.Size(60, 13);
            this.Kwalificatie.TabIndex = 2;
            this.Kwalificatie.Text = "Kwalificatie";
            this.toolTips.SetToolTip(this.Kwalificatie, "De officiële benaming van het kwalificatiedossier voor \r\nhet betrefende jaar.");
            // 
            // Uitstroom
            // 
            this.Uitstroom.AutoSize = true;
            this.Uitstroom.Location = new System.Drawing.Point(10, 130);
            this.Uitstroom.Name = "Uitstroom";
            this.Uitstroom.Size = new System.Drawing.Size(51, 13);
            this.Uitstroom.TabIndex = 2;
            this.Uitstroom.Text = "Uitstroom";
            this.toolTips.SetToolTip(this.Uitstroom, "De benaming van het uitstroomprofiel\r\nvanuit het kwalificatiedossier");
            // 
            // Niveau
            // 
            this.Niveau.AutoSize = true;
            this.Niveau.Location = new System.Drawing.Point(10, 160);
            this.Niveau.Name = "Niveau";
            this.Niveau.Size = new System.Drawing.Size(41, 13);
            this.Niveau.TabIndex = 2;
            this.Niveau.Text = "Niveau";
            this.toolTips.SetToolTip(this.Niveau, "Het MBO Niveau van de opleiding.");
            // 
            // Leerroute
            // 
            this.Leerroute.AutoSize = true;
            this.Leerroute.Location = new System.Drawing.Point(10, 190);
            this.Leerroute.Name = "Leerroute";
            this.Leerroute.Size = new System.Drawing.Size(52, 13);
            this.Leerroute.TabIndex = 2;
            this.Leerroute.Text = "Leerroute";
            this.toolTips.SetToolTip(this.Leerroute, "Het type leerroute dat gehanteerd wordt bij de opleiding.");
            // 
            // Kenniscentrum
            // 
            this.Kenniscentrum.AutoSize = true;
            this.Kenniscentrum.Location = new System.Drawing.Point(10, 220);
            this.Kenniscentrum.Name = "Kenniscentrum";
            this.Kenniscentrum.Size = new System.Drawing.Size(77, 13);
            this.Kenniscentrum.TabIndex = 1;
            this.Kenniscentrum.Text = "Kenniscentrum";
            this.toolTips.SetToolTip(this.Kenniscentrum, "Het kenniscentrum waartoe de opleiding behoort.");
            // 
            // Cohort
            // 
            this.Cohort.AutoSize = true;
            this.Cohort.Location = new System.Drawing.Point(10, 250);
            this.Cohort.Name = "Cohort";
            this.Cohort.Size = new System.Drawing.Size(38, 13);
            this.Cohort.TabIndex = 2;
            this.Cohort.Text = "Cohort";
            this.toolTips.SetToolTip(this.Cohort, "Start wanneer de student is begonnen met de\r\nopleiding (bijv. 2009).");
            // 
            // KdVersie
            // 
            this.KdVersie.AutoSize = true;
            this.KdVersie.Location = new System.Drawing.Point(10, 280);
            this.KdVersie.Name = "KdVersie";
            this.KdVersie.Size = new System.Drawing.Size(51, 13);
            this.KdVersie.TabIndex = 2;
            this.KdVersie.Text = "Kd versie";
            this.toolTips.SetToolTip(this.KdVersie, "Dit kan afwijken van het cohort.");
            // 
            // LeerlingAantal
            // 
            this.LeerlingAantal.AutoSize = true;
            this.LeerlingAantal.Location = new System.Drawing.Point(10, 310);
            this.LeerlingAantal.Name = "LeerlingAantal";
            this.LeerlingAantal.Size = new System.Drawing.Size(76, 13);
            this.LeerlingAantal.TabIndex = 2;
            this.LeerlingAantal.Text = "Leerling aantal";
            this.toolTips.SetToolTip(this.LeerlingAantal, "Het aantal leerlingen dat zich op deze opleiding bevindt.");
            // 
            // ExamenProfiel
            // 
            this.ExamenProfiel.AutoSize = true;
            this.ExamenProfiel.Location = new System.Drawing.Point(10, 340);
            this.ExamenProfiel.Name = "ExamenProfiel";
            this.ExamenProfiel.Size = new System.Drawing.Size(73, 13);
            this.ExamenProfiel.TabIndex = 2;
            this.ExamenProfiel.Text = "Examenprofiel";
            this.toolTips.SetToolTip(this.ExamenProfiel, "Het Examenprofiel van de opleiding.");
            // 
            // Teamvoorzitter
            // 
            this.Teamvoorzitter.AutoSize = true;
            this.Teamvoorzitter.Location = new System.Drawing.Point(10, 370);
            this.Teamvoorzitter.Name = "Teamvoorzitter";
            this.Teamvoorzitter.Size = new System.Drawing.Size(77, 13);
            this.Teamvoorzitter.TabIndex = 2;
            this.Teamvoorzitter.Text = "Teamvoorzitter";
            this.toolTips.SetToolTip(this.Teamvoorzitter, "De teamvoorzitter van de opleiding.");
            // 
            // Aanspreekpunt
            // 
            this.Aanspreekpunt.AutoSize = true;
            this.Aanspreekpunt.Location = new System.Drawing.Point(10, 400);
            this.Aanspreekpunt.Name = "Aanspreekpunt";
            this.Aanspreekpunt.Size = new System.Drawing.Size(79, 13);
            this.Aanspreekpunt.TabIndex = 2;
            this.Aanspreekpunt.Text = "Aanspreekpunt";
            this.toolTips.SetToolTip(this.Aanspreekpunt, "Het aanspreekpunt van de opleiding.");
            // 
            // Manager
            // 
            this.Manager.AutoSize = true;
            this.Manager.Location = new System.Drawing.Point(10, 430);
            this.Manager.Name = "Manager";
            this.Manager.Size = new System.Drawing.Size(49, 13);
            this.Manager.TabIndex = 2;
            this.Manager.Text = "Manager";
            this.toolTips.SetToolTip(this.Manager, "De manager van de opleiding.");
            // 
            // CreboBox
            // 
            this.CreboBox.Location = new System.Drawing.Point(110, 37);
            this.CreboBox.Name = "CreboBox";
            this.CreboBox.Size = new System.Drawing.Size(160, 20);
            this.CreboBox.TabIndex = 3;
            this.CreboBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // OpleidingBox
            // 
            this.OpleidingBox.Location = new System.Drawing.Point(110, 67);
            this.OpleidingBox.Name = "OpleidingBox";
            this.OpleidingBox.Size = new System.Drawing.Size(160, 20);
            this.OpleidingBox.TabIndex = 3;
            // 
            // KwalificatieBox
            // 
            this.KwalificatieBox.Location = new System.Drawing.Point(110, 97);
            this.KwalificatieBox.Name = "KwalificatieBox";
            this.KwalificatieBox.Size = new System.Drawing.Size(160, 20);
            this.KwalificatieBox.TabIndex = 3;
            // 
            // UitstroomBox
            // 
            this.UitstroomBox.Location = new System.Drawing.Point(110, 127);
            this.UitstroomBox.Name = "UitstroomBox";
            this.UitstroomBox.Size = new System.Drawing.Size(160, 20);
            this.UitstroomBox.TabIndex = 3;
            // 
            // CohortBox
            // 
            this.CohortBox.Location = new System.Drawing.Point(110, 247);
            this.CohortBox.Name = "CohortBox";
            this.CohortBox.Size = new System.Drawing.Size(160, 20);
            this.CohortBox.TabIndex = 3;
            // 
            // KdVersieBox
            // 
            this.KdVersieBox.Location = new System.Drawing.Point(110, 277);
            this.KdVersieBox.Name = "KdVersieBox";
            this.KdVersieBox.Size = new System.Drawing.Size(160, 20);
            this.KdVersieBox.TabIndex = 3;
            // 
            // LeerlingAantalBox
            // 
            this.LeerlingAantalBox.Location = new System.Drawing.Point(110, 307);
            this.LeerlingAantalBox.Name = "LeerlingAantalBox";
            this.LeerlingAantalBox.Size = new System.Drawing.Size(160, 20);
            this.LeerlingAantalBox.TabIndex = 3;
            // 
            // TeamvoorzitterBox
            // 
            this.TeamvoorzitterBox.Location = new System.Drawing.Point(110, 367);
            this.TeamvoorzitterBox.Name = "TeamvoorzitterBox";
            this.TeamvoorzitterBox.Size = new System.Drawing.Size(160, 20);
            this.TeamvoorzitterBox.TabIndex = 3;
            this.TeamvoorzitterBox.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // AanspreekBox
            // 
            this.AanspreekBox.Location = new System.Drawing.Point(110, 397);
            this.AanspreekBox.Name = "AanspreekBox";
            this.AanspreekBox.Size = new System.Drawing.Size(160, 20);
            this.AanspreekBox.TabIndex = 3;
            // 
            // ManagerBox
            // 
            this.ManagerBox.Location = new System.Drawing.Point(110, 427);
            this.ManagerBox.Name = "ManagerBox";
            this.ManagerBox.Size = new System.Drawing.Size(160, 20);
            this.ManagerBox.TabIndex = 3;
            // 
            // NiveauBox
            // 
            this.NiveauBox.FormattingEnabled = true;
            this.NiveauBox.Location = new System.Drawing.Point(110, 157);
            this.NiveauBox.Name = "NiveauBox";
            this.NiveauBox.Size = new System.Drawing.Size(160, 21);
            this.NiveauBox.TabIndex = 4;
            // 
            // LeerrouteBox
            // 
            this.LeerrouteBox.FormattingEnabled = true;
            this.LeerrouteBox.Location = new System.Drawing.Point(110, 187);
            this.LeerrouteBox.Name = "LeerrouteBox";
            this.LeerrouteBox.Size = new System.Drawing.Size(160, 21);
            this.LeerrouteBox.TabIndex = 4;
            // 
            // KenniscentrumBox
            // 
            this.KenniscentrumBox.FormattingEnabled = true;
            this.KenniscentrumBox.Location = new System.Drawing.Point(110, 217);
            this.KenniscentrumBox.Name = "KenniscentrumBox";
            this.KenniscentrumBox.Size = new System.Drawing.Size(160, 21);
            this.KenniscentrumBox.TabIndex = 4;
            // 
            // ExamenProfielBox
            // 
            this.ExamenProfielBox.FormattingEnabled = true;
            this.ExamenProfielBox.Location = new System.Drawing.Point(110, 337);
            this.ExamenProfielBox.Name = "ExamenProfielBox";
            this.ExamenProfielBox.Size = new System.Drawing.Size(160, 21);
            this.ExamenProfielBox.TabIndex = 4;
            // 
            // OpslaanButton
            // 
            this.OpslaanButton.Location = new System.Drawing.Point(110, 457);
            this.OpslaanButton.Name = "OpslaanButton";
            this.OpslaanButton.Size = new System.Drawing.Size(75, 23);
            this.OpslaanButton.TabIndex = 5;
            this.OpslaanButton.Text = "Opslaan ";
            this.toolTips.SetToolTip(this.OpslaanButton, "De ingevulde gegevens worden opgeslagen en krijgt u het overzicht te zien.");
            this.OpslaanButton.UseVisualStyleBackColor = true;
            // 
            // OpslaanPlusButton
            // 
            this.OpslaanPlusButton.Location = new System.Drawing.Point(220, 457);
            this.OpslaanPlusButton.Name = "OpslaanPlusButton";
            this.OpslaanPlusButton.Size = new System.Drawing.Size(173, 23);
            this.OpslaanPlusButton.TabIndex = 5;
            this.OpslaanPlusButton.Text = "Opslaan en Volgende Invoer";
            this.toolTips.SetToolTip(this.OpslaanPlusButton, "De ingevulde gegevens worden opgeslagen en het formulier wordt leeggemaakt");
            this.OpslaanPlusButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Voeg een examen toe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(622, 457);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Verwijder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ExamenPaneel
            // 
            this.ExamenPaneel.AutoScroll = true;
            this.ExamenPaneel.BackColor = System.Drawing.Color.Transparent;
            this.ExamenPaneel.Location = new System.Drawing.Point(400, 100);
            this.ExamenPaneel.Name = "ExamenPaneel";
            this.ExamenPaneel.Size = new System.Drawing.Size(360, 260);
            this.ExamenPaneel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ExamenPaneel);
            this.Controls.Add(this.OpslaanPlusButton);
            this.Controls.Add(this.OpslaanButton);
            this.Controls.Add(this.ExamenProfielBox);
            this.Controls.Add(this.KenniscentrumBox);
            this.Controls.Add(this.LeerrouteBox);
            this.Controls.Add(this.NiveauBox);
            this.Controls.Add(this.ManagerBox);
            this.Controls.Add(this.AanspreekBox);
            this.Controls.Add(this.TeamvoorzitterBox);
            this.Controls.Add(this.LeerlingAantalBox);
            this.Controls.Add(this.KdVersieBox);
            this.Controls.Add(this.CohortBox);
            this.Controls.Add(this.UitstroomBox);
            this.Controls.Add(this.KwalificatieBox);
            this.Controls.Add(this.OpleidingBox);
            this.Controls.Add(this.CreboBox);
            this.Controls.Add(this.Teamvoorzitter);
            this.Controls.Add(this.Leerroute);
            this.Controls.Add(this.Manager);
            this.Controls.Add(this.Aanspreekpunt);
            this.Controls.Add(this.ExamenProfiel);
            this.Controls.Add(this.LeerlingAantal);
            this.Controls.Add(this.Niveau);
            this.Controls.Add(this.KdVersie);
            this.Controls.Add(this.Uitstroom);
            this.Controls.Add(this.Cohort);
            this.Controls.Add(this.Kwalificatie);
            this.Controls.Add(this.Kenniscentrum);
            this.Controls.Add(this.OpleidingsNaam);
            this.Controls.Add(this.CreboCode);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Cohort Archivering";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.examenPlus();
       }

        #endregion

        public void examenPlus()
        {
            if (examenAantal < 20)
            {
                ExamenBlok[examenAantal] = new System.Windows.Forms.Panel();
                ExamenTitle[examenAantal] = new System.Windows.Forms.Label();
                StatusOpdracht[examenAantal] = new System.Windows.Forms.Label();
                NaamOpdracht[examenAantal] = new System.Windows.Forms.Label();
                PeriodeAfname[examenAantal] = new System.Windows.Forms.Label();
                Werkprocessen[examenAantal] = new System.Windows.Forms.Label();
                Kerntaken[examenAantal] = new System.Windows.Forms.Label();
                Examen[examenAantal] = new System.Windows.Forms.Label();
                StatusOpdrachtBox[examenAantal] = new System.Windows.Forms.ComboBox();
                PeriodeAfnameBox[examenAantal] = new System.Windows.Forms.ComboBox();
                NaamOpdrachtBox[examenAantal] = new System.Windows.Forms.TextBox();
                WerkprocessenBox[examenAantal] = new System.Windows.Forms.TextBox();
                KerntakenBox[examenAantal] = new System.Windows.Forms.TextBox();
                ExamenBox[examenAantal] = new System.Windows.Forms.TextBox();
                // 
                // ExamenBlok
                //
                this.ExamenBlok[examenAantal].BackColor = System.Drawing.Color.Silver;
                if (examenAantal == 0)
                {
                    this.ExamenBlok[examenAantal].Location = new System.Drawing.Point(10, 10);
                }
                else
                {
                    this.ExamenBlok[examenAantal].Location = new System.Drawing.Point(10, this.ExamenPaneel.AutoScrollPosition.Y + (BlokHoogte * examenAantal));
                }                
                this.ExamenBlok[examenAantal].Name = "ExamenPaneel";
                this.ExamenBlok[examenAantal].Size = new System.Drawing.Size(330, 250);
                this.ExamenBlok[examenAantal].TabIndex = 6;
                // 
                // StatusOpdracht
                // 
                this.StatusOpdracht[examenAantal].AutoSize = true;
                this.StatusOpdracht[examenAantal].Location = new System.Drawing.Point(15, 200);
                this.StatusOpdracht[examenAantal].Name = "StatusOpdracht";
                this.StatusOpdracht[examenAantal].Size = new System.Drawing.Size(84, 13);
                this.StatusOpdracht[examenAantal].TabIndex = 0;
                this.StatusOpdracht[examenAantal].Text = "Status Opdracht";
                toolTips.SetToolTip(this.StatusOpdracht[examenAantal], "Het status van de examenopdracht.");
                // 
                // NaamOpdracht
                // 
                this.NaamOpdracht[examenAantal].AutoSize = true;
                this.NaamOpdracht[examenAantal].Location = new System.Drawing.Point(15, 170);
                this.NaamOpdracht[examenAantal].Name = "NaamOpdracht";
                this.NaamOpdracht[examenAantal].Size = new System.Drawing.Size(82, 13);
                this.NaamOpdracht[examenAantal].TabIndex = 0;
                this.NaamOpdracht[examenAantal].Text = "Naam Opdracht";
                this.toolTips.SetToolTip(this.NaamOpdracht[examenAantal], "De naam van de examenopdracht.");
                // 
                // PeriodeAfname
                // 
                this.PeriodeAfname[examenAantal].AutoSize = true;
                this.PeriodeAfname[examenAantal].Location = new System.Drawing.Point(15, 140);
                this.PeriodeAfname[examenAantal].Name = "PeriodeAfname";
                this.PeriodeAfname[examenAantal].Size = new System.Drawing.Size(82, 13);
                this.PeriodeAfname[examenAantal].TabIndex = 0;
                this.PeriodeAfname[examenAantal].Text = "Periode Afname";
                this.toolTips.SetToolTip(this.PeriodeAfname[examenAantal], "De periode waarin het examen wordt afgenomen.");
                // 
                // Werkprocessen
                // 
                this.Werkprocessen[examenAantal].AutoSize = true;
                this.Werkprocessen[examenAantal].Location = new System.Drawing.Point(15, 110);
                this.Werkprocessen[examenAantal].Name = "Werkprocessen";
                this.Werkprocessen[examenAantal].Size = new System.Drawing.Size(82, 13);
                this.Werkprocessen[examenAantal].TabIndex = 0;
                this.Werkprocessen[examenAantal].Text = "Werkprocessen";
                this.toolTips.SetToolTip(this.Werkprocessen[examenAantal], "De werkprocessen die vereist zijn bij dit examen.");
                // 
                // Kerntaken
                // 
                this.Kerntaken[examenAantal].AutoSize = true;
                this.Kerntaken[examenAantal].Location = new System.Drawing.Point(15, 80);
                this.Kerntaken[examenAantal].Name = "Kerntaken";
                this.Kerntaken[examenAantal].Size = new System.Drawing.Size(56, 13);
                this.Kerntaken[examenAantal].TabIndex = 0;
                this.Kerntaken[examenAantal].Text = "Kerntaken";
                this.toolTips.SetToolTip(this.Kerntaken[examenAantal], "De kerntaken die vereist zijn bij dit examen.");
                // 
                // Examen
                // 
                this.Examen[examenAantal].AutoSize = true;
                this.Examen[examenAantal].Location = new System.Drawing.Point(15, 50);
                this.Examen[examenAantal].Name = "Examen";
                this.Examen[examenAantal].Size = new System.Drawing.Size(45, 13);
                this.Examen[examenAantal].TabIndex = 0;
                this.Examen[examenAantal].Text = "Examen";
                this.toolTips.SetToolTip(this.Examen[examenAantal], "De naam van het examen zoals bekend bij de opleiding.");
                // 
                // StatusOpdrachtBox
                // 
                this.StatusOpdrachtBox[examenAantal].FormattingEnabled = true;
                this.StatusOpdrachtBox[examenAantal].Location = new System.Drawing.Point(120, 197);
                this.StatusOpdrachtBox[examenAantal].Name = "StatusOpdrachtBox";
                this.StatusOpdrachtBox[examenAantal].Size = new System.Drawing.Size(160, 21);
                this.StatusOpdrachtBox[examenAantal].TabIndex = 4;
                // 
                // PeriodeAfnameBox
                // 
                this.PeriodeAfnameBox[examenAantal].FormattingEnabled = true;
                this.PeriodeAfnameBox[examenAantal].Location = new System.Drawing.Point(120, 137);
                this.PeriodeAfnameBox[examenAantal].Name = "PeriodeAfnameBox";
                this.PeriodeAfnameBox[examenAantal].Size = new System.Drawing.Size(160, 21);
                this.PeriodeAfnameBox[examenAantal].TabIndex = 4;
                // 
                // ExamenTitle
                // 
                this.ExamenTitle[examenAantal].AutoSize = true;
                this.ExamenTitle[examenAantal].Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.ExamenTitle[examenAantal].Location = new System.Drawing.Point(15, 20);
                this.ExamenTitle[examenAantal].Name = "ExamenTitle";
                this.ExamenTitle[examenAantal].Size = new System.Drawing.Size(63, 16);
                this.ExamenTitle[examenAantal].TabIndex = 0;
                this.ExamenTitle[examenAantal].Text = "Examen " + (examenAantal + 1);
                // 
                // NaamOpdrachtBox
                // 
                this.NaamOpdrachtBox[examenAantal].Location = new System.Drawing.Point(120, 167);
                this.NaamOpdrachtBox[examenAantal].Name = "NaamOpdrachtBox";
                this.NaamOpdrachtBox[examenAantal].Size = new System.Drawing.Size(160, 20);
                this.NaamOpdrachtBox[examenAantal].TabIndex = 3;
                // 
                // WerkprocessenBox
                // 
                this.WerkprocessenBox[examenAantal].Location = new System.Drawing.Point(120, 107);
                this.WerkprocessenBox[examenAantal].Name = "WerkprocessenBox";
                this.WerkprocessenBox[examenAantal].Size = new System.Drawing.Size(160, 20);
                this.WerkprocessenBox[examenAantal].TabIndex = 3;
                // 
                // KerntakenBox
                // 
                this.KerntakenBox[examenAantal].Location = new System.Drawing.Point(120, 77);
                this.KerntakenBox[examenAantal].Name = "KerntakenBox";
                this.KerntakenBox[examenAantal].Size = new System.Drawing.Size(160, 20);
                this.KerntakenBox[examenAantal].TabIndex = 3;
                // 
                // ExamenBox
                // 
                this.ExamenBox[examenAantal].Location = new System.Drawing.Point(120, 47);
                this.ExamenBox[examenAantal].Name = "ExamenBox";
                this.ExamenBox[examenAantal].Size = new System.Drawing.Size(160, 20);
                this.ExamenBox[examenAantal].TabIndex = 3;

                this.ExamenPaneel.Controls.Add(this.ExamenBlok[examenAantal]);
                this.ExamenBlok[examenAantal].Controls.Add(this.StatusOpdracht[examenAantal]);
                this.ExamenBlok[examenAantal].Controls.Add(this.NaamOpdracht[examenAantal]);
                this.ExamenBlok[examenAantal].Controls.Add(this.PeriodeAfname[examenAantal]);
                this.ExamenBlok[examenAantal].Controls.Add(this.Werkprocessen[examenAantal]);
                this.ExamenBlok[examenAantal].Controls.Add(this.Kerntaken[examenAantal]);
                this.ExamenBlok[examenAantal].Controls.Add(this.Examen[examenAantal]);
                this.ExamenBlok[examenAantal].Controls.Add(this.StatusOpdrachtBox[examenAantal]);
                this.ExamenBlok[examenAantal].Controls.Add(this.PeriodeAfnameBox[examenAantal]);
                this.ExamenBlok[examenAantal].Controls.Add(this.ExamenTitle[examenAantal]);
                this.ExamenBlok[examenAantal].Controls.Add(this.NaamOpdrachtBox[examenAantal]);
                this.ExamenBlok[examenAantal].Controls.Add(this.WerkprocessenBox[examenAantal]);
                this.ExamenBlok[examenAantal].Controls.Add(this.KerntakenBox[examenAantal]);
                this.ExamenBlok[examenAantal].Controls.Add(this.ExamenBox[examenAantal]);
                examenAantal++;
            }
        }

        private void examenMin()
        {
            if (examenAantal > 1)
            {
                this.ExamenPaneel.Controls.Remove(ExamenBlok[examenAantal - 1]);
                examenAantal--;
            }
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
        private System.Windows.Forms.Label LeerlingAantal;
        private System.Windows.Forms.Label ExamenProfiel;
        private System.Windows.Forms.Label Teamvoorzitter;
        private System.Windows.Forms.Label Aanspreekpunt;
        private System.Windows.Forms.Label Manager;
        private System.Windows.Forms.TextBox CreboBox;
        private System.Windows.Forms.TextBox OpleidingBox;
        private System.Windows.Forms.TextBox KwalificatieBox;
        private System.Windows.Forms.TextBox UitstroomBox;
        private System.Windows.Forms.TextBox CohortBox;
        private System.Windows.Forms.TextBox KdVersieBox;
        private System.Windows.Forms.TextBox LeerlingAantalBox;
        private System.Windows.Forms.TextBox TeamvoorzitterBox;
        private System.Windows.Forms.TextBox AanspreekBox;
        private System.Windows.Forms.TextBox ManagerBox;
        private System.Windows.Forms.ComboBox NiveauBox;
        private System.Windows.Forms.ComboBox LeerrouteBox;
        private System.Windows.Forms.ComboBox KenniscentrumBox;
        private System.Windows.Forms.ComboBox ExamenProfielBox;
        private System.Windows.Forms.Button OpslaanButton;
        private System.Windows.Forms.Button OpslaanPlusButton;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel ExamenPaneel;
    }
}

