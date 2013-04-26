namespace WindowsFormsApplication1
{
    partial class Form1
    {
        int amount = 0;
        System.Windows.Forms.Panel[] panels = new System.Windows.Forms.Panel[20];
        System.Windows.Forms.Label[] label = new System.Windows.Forms.Label[20];
        System.Windows.Forms.TextBox[] textBox = new System.Windows.Forms.TextBox[20];
        System.Windows.Forms.Button[] button = new System.Windows.Forms.Button[20];
        
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "add field";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "delete field";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(24, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 366);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        public void addField()
        {
            if (amount < 20)
            {
                int labely = 30 + 30 * amount;
                int boxy = 27 + 30 * amount;

                panels[amount] = new System.Windows.Forms.Panel();
                label[amount] = new System.Windows.Forms.Label();
                textBox[amount] = new System.Windows.Forms.TextBox();
                //
                // panels
                //
                panels[amount].AutoScroll = true;
                panels[amount].Location = new System.Drawing.Point(0, panel1.AutoScrollPosition.Y + (100 * amount));
                panels[amount].Name = "panel1";
                panels[amount].Size = new System.Drawing.Size(408, 100);
                panels[amount].TabIndex = 1;
                panels[amount].BackColor = System.Drawing.Color.DarkGray;
                // 
                // label1
                // 
                label[amount].AutoSize = true;
                label[amount].Location = new System.Drawing.Point(100, 43);
                label[amount].Name = "label" + (amount + 1);
                label[amount].Size = new System.Drawing.Size(40, 14);
                label[amount].TabIndex = 0;
                label[amount].Text = "Examen " + (amount + 1);
                // 
                // textBox1
                // 
                textBox[amount].Location = new System.Drawing.Point(160, 40);
                textBox[amount].Name = "textBox" + (amount + 1);
                textBox[amount].Size = new System.Drawing.Size(100, 20);
                textBox[amount].TabIndex = 1;

                this.panel1.Controls.Add(panels[amount]);
                this.panels[amount].Controls.Add(textBox[amount]);
                this.panels[amount].Controls.Add(label[amount]);

                amount++;
            }
        }

        private void deleteField()
        {
            if (amount > 1)
            {
                this.panel1.Controls.Remove(panels[amount - 1]);
                amount--;
            }
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}

