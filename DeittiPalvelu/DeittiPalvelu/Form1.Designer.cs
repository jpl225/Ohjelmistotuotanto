namespace DeittiPalvelu
{
    partial class Lomake
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
            this.nimiOtsikko = new System.Windows.Forms.Label();
            this.SyntymaAikaOtsikko = new System.Windows.Forms.Label();
            this.EtsinOtsikko = new System.Windows.Forms.Label();
            this.nimiLaatikko = new System.Windows.Forms.TextBox();
            this.Ryhmaboksi1 = new System.Windows.Forms.GroupBox();
            this.SyntymaAikaLaatikko = new System.Windows.Forms.DateTimePicker();
            this.EtsinLaatikko = new System.Windows.Forms.ComboBox();
            this.HakuLomake = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.VastausLomake = new System.Windows.Forms.Panel();
            this.NimiOtsikkoS2 = new System.Windows.Forms.Label();
            this.SyntymaAikaOtsikkoS2 = new System.Windows.Forms.Label();
            this.HaenOtsikkoS2 = new System.Windows.Forms.Label();
            this.nimiVastaus = new System.Windows.Forms.Label();
            this.SyntymaAikaVastaus = new System.Windows.Forms.Label();
            this.HaenVastaus = new System.Windows.Forms.Label();
            this.RyhmaLaatikko2 = new System.Windows.Forms.GroupBox();
            this.OKPainike = new System.Windows.Forms.Button();
            this.Ryhmaboksi1.SuspendLayout();
            this.HakuLomake.SuspendLayout();
            this.VastausLomake.SuspendLayout();
            this.SuspendLayout();
            // 
            // nimiOtsikko
            // 
            this.nimiOtsikko.AutoSize = true;
            this.nimiOtsikko.Location = new System.Drawing.Point(19, 37);
            this.nimiOtsikko.Name = "nimiOtsikko";
            this.nimiOtsikko.Size = new System.Drawing.Size(30, 13);
            this.nimiOtsikko.TabIndex = 0;
            this.nimiOtsikko.Text = "Nimi:";
            // 
            // SyntymaAikaOtsikko
            // 
            this.SyntymaAikaOtsikko.AutoSize = true;
            this.SyntymaAikaOtsikko.Location = new System.Drawing.Point(19, 70);
            this.SyntymaAikaOtsikko.Name = "SyntymaAikaOtsikko";
            this.SyntymaAikaOtsikko.Size = new System.Drawing.Size(70, 13);
            this.SyntymaAikaOtsikko.TabIndex = 1;
            this.SyntymaAikaOtsikko.Text = "Syntymäaika:";
            // 
            // EtsinOtsikko
            // 
            this.EtsinOtsikko.AutoSize = true;
            this.EtsinOtsikko.Location = new System.Drawing.Point(22, 105);
            this.EtsinOtsikko.Name = "EtsinOtsikko";
            this.EtsinOtsikko.Size = new System.Drawing.Size(33, 13);
            this.EtsinOtsikko.TabIndex = 2;
            this.EtsinOtsikko.Text = "Etsin:";
            // 
            // nimiLaatikko
            // 
            this.nimiLaatikko.Location = new System.Drawing.Point(107, 34);
            this.nimiLaatikko.Name = "nimiLaatikko";
            this.nimiLaatikko.Size = new System.Drawing.Size(221, 20);
            this.nimiLaatikko.TabIndex = 3;
            // 
            // Ryhmaboksi1
            // 
            this.Ryhmaboksi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Ryhmaboksi1.Controls.Add(this.EtsinLaatikko);
            this.Ryhmaboksi1.Controls.Add(this.SyntymaAikaLaatikko);
            this.Ryhmaboksi1.Controls.Add(this.nimiLaatikko);
            this.Ryhmaboksi1.Controls.Add(this.EtsinOtsikko);
            this.Ryhmaboksi1.Controls.Add(this.nimiOtsikko);
            this.Ryhmaboksi1.Controls.Add(this.SyntymaAikaOtsikko);
            this.Ryhmaboksi1.Location = new System.Drawing.Point(12, 11);
            this.Ryhmaboksi1.Name = "Ryhmaboksi1";
            this.Ryhmaboksi1.Size = new System.Drawing.Size(388, 167);
            this.Ryhmaboksi1.TabIndex = 4;
            this.Ryhmaboksi1.TabStop = false;
            // 
            // SyntymaAikaLaatikko
            // 
            this.SyntymaAikaLaatikko.Location = new System.Drawing.Point(107, 70);
            this.SyntymaAikaLaatikko.Name = "SyntymaAikaLaatikko";
            this.SyntymaAikaLaatikko.Size = new System.Drawing.Size(221, 20);
            this.SyntymaAikaLaatikko.TabIndex = 4;
            // 
            // EtsinLaatikko
            // 
            this.EtsinLaatikko.FormattingEnabled = true;
            this.EtsinLaatikko.Items.AddRange(new object[] {
            "Mies etsii miestä",
            "Mies etsii naista",
            "Nainen etsii naista",
            "Nainen etsii miestä",
            "Eipä ole niin väliä"});
            this.EtsinLaatikko.Location = new System.Drawing.Point(107, 105);
            this.EtsinLaatikko.Name = "EtsinLaatikko";
            this.EtsinLaatikko.Size = new System.Drawing.Size(221, 21);
            this.EtsinLaatikko.TabIndex = 5;
            this.EtsinLaatikko.SelectedIndexChanged += new System.EventHandler(this.EtsinLaatikko_SelectedIndexChanged);
            // 
            // HakuLomake
            // 
            this.HakuLomake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.HakuLomake.Controls.Add(this.button2);
            this.HakuLomake.Controls.Add(this.Ryhmaboksi1);
            this.HakuLomake.Controls.Add(this.button1);
            this.HakuLomake.Location = new System.Drawing.Point(12, 12);
            this.HakuLomake.Name = "HakuLomake";
            this.HakuLomake.Size = new System.Drawing.Size(418, 224);
            this.HakuLomake.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hae nyt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Peruuta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VastausLomake
            // 
            this.VastausLomake.Controls.Add(this.OKPainike);
            this.VastausLomake.Controls.Add(this.HaenVastaus);
            this.VastausLomake.Controls.Add(this.SyntymaAikaVastaus);
            this.VastausLomake.Controls.Add(this.nimiVastaus);
            this.VastausLomake.Controls.Add(this.HaenOtsikkoS2);
            this.VastausLomake.Controls.Add(this.SyntymaAikaOtsikkoS2);
            this.VastausLomake.Controls.Add(this.NimiOtsikkoS2);
            this.VastausLomake.Controls.Add(this.RyhmaLaatikko2);
            this.VastausLomake.Location = new System.Drawing.Point(12, 12);
            this.VastausLomake.Name = "VastausLomake";
            this.VastausLomake.Size = new System.Drawing.Size(326, 193);
            this.VastausLomake.TabIndex = 6;
            this.VastausLomake.Visible = false;
            // 
            // NimiOtsikkoS2
            // 
            this.NimiOtsikkoS2.AutoSize = true;
            this.NimiOtsikkoS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NimiOtsikkoS2.Location = new System.Drawing.Point(64, 39);
            this.NimiOtsikkoS2.Name = "NimiOtsikkoS2";
            this.NimiOtsikkoS2.Size = new System.Drawing.Size(35, 13);
            this.NimiOtsikkoS2.TabIndex = 0;
            this.NimiOtsikkoS2.Text = "Nimi:";
            this.NimiOtsikkoS2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SyntymaAikaOtsikkoS2
            // 
            this.SyntymaAikaOtsikkoS2.AutoSize = true;
            this.SyntymaAikaOtsikkoS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SyntymaAikaOtsikkoS2.Location = new System.Drawing.Point(17, 68);
            this.SyntymaAikaOtsikkoS2.Name = "SyntymaAikaOtsikkoS2";
            this.SyntymaAikaOtsikkoS2.Size = new System.Drawing.Size(82, 13);
            this.SyntymaAikaOtsikkoS2.TabIndex = 1;
            this.SyntymaAikaOtsikkoS2.Text = "Syntymäaika:";
            this.SyntymaAikaOtsikkoS2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // HaenOtsikkoS2
            // 
            this.HaenOtsikkoS2.AutoSize = true;
            this.HaenOtsikkoS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HaenOtsikkoS2.Location = new System.Drawing.Point(58, 95);
            this.HaenOtsikkoS2.Name = "HaenOtsikkoS2";
            this.HaenOtsikkoS2.Size = new System.Drawing.Size(41, 13);
            this.HaenOtsikkoS2.TabIndex = 2;
            this.HaenOtsikkoS2.Text = "Haen:";
            this.HaenOtsikkoS2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nimiVastaus
            // 
            this.nimiVastaus.AutoSize = true;
            this.nimiVastaus.Location = new System.Drawing.Point(106, 39);
            this.nimiVastaus.Name = "nimiVastaus";
            this.nimiVastaus.Size = new System.Drawing.Size(0, 13);
            this.nimiVastaus.TabIndex = 3;
            // 
            // SyntymaAikaVastaus
            // 
            this.SyntymaAikaVastaus.AutoSize = true;
            this.SyntymaAikaVastaus.Location = new System.Drawing.Point(106, 68);
            this.SyntymaAikaVastaus.Name = "SyntymaAikaVastaus";
            this.SyntymaAikaVastaus.Size = new System.Drawing.Size(0, 13);
            this.SyntymaAikaVastaus.TabIndex = 4;
            // 
            // HaenVastaus
            // 
            this.HaenVastaus.AutoSize = true;
            this.HaenVastaus.Location = new System.Drawing.Point(106, 95);
            this.HaenVastaus.Name = "HaenVastaus";
            this.HaenVastaus.Size = new System.Drawing.Size(0, 13);
            this.HaenVastaus.TabIndex = 5;
            // 
            // RyhmaLaatikko2
            // 
            this.RyhmaLaatikko2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RyhmaLaatikko2.Location = new System.Drawing.Point(6, 3);
            this.RyhmaLaatikko2.Name = "RyhmaLaatikko2";
            this.RyhmaLaatikko2.Size = new System.Drawing.Size(320, 126);
            this.RyhmaLaatikko2.TabIndex = 6;
            this.RyhmaLaatikko2.TabStop = false;
            // 
            // OKPainike
            // 
            this.OKPainike.Location = new System.Drawing.Point(132, 149);
            this.OKPainike.Name = "OKPainike";
            this.OKPainike.Size = new System.Drawing.Size(75, 23);
            this.OKPainike.TabIndex = 7;
            this.OKPainike.Text = "OK";
            this.OKPainike.UseVisualStyleBackColor = true;
            this.OKPainike.Click += new System.EventHandler(this.OKPainike_Click);
            // 
            // Lomake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 341);
            this.Controls.Add(this.VastausLomake);
            this.Controls.Add(this.HakuLomake);
            this.Name = "Lomake";
            this.Text = "Form1";
            this.Ryhmaboksi1.ResumeLayout(false);
            this.Ryhmaboksi1.PerformLayout();
            this.HakuLomake.ResumeLayout(false);
            this.VastausLomake.ResumeLayout(false);
            this.VastausLomake.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nimiOtsikko;
        private System.Windows.Forms.Label SyntymaAikaOtsikko;
        private System.Windows.Forms.Label EtsinOtsikko;
        private System.Windows.Forms.TextBox nimiLaatikko;
        private System.Windows.Forms.GroupBox Ryhmaboksi1;
        private System.Windows.Forms.ComboBox EtsinLaatikko;
        private System.Windows.Forms.DateTimePicker SyntymaAikaLaatikko;
        private System.Windows.Forms.Panel HakuLomake;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel VastausLomake;
        private System.Windows.Forms.Button OKPainike;
        private System.Windows.Forms.Label HaenVastaus;
        private System.Windows.Forms.Label SyntymaAikaVastaus;
        private System.Windows.Forms.Label nimiVastaus;
        private System.Windows.Forms.Label HaenOtsikkoS2;
        private System.Windows.Forms.Label SyntymaAikaOtsikkoS2;
        private System.Windows.Forms.Label NimiOtsikkoS2;
        private System.Windows.Forms.GroupBox RyhmaLaatikko2;
    }
}

