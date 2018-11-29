namespace WindowsFormsApp3
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
            this.KyselyLomake = new System.Windows.Forms.Panel();
            this.RyhmaLaatikko = new System.Windows.Forms.GroupBox();
            this.NimiOtsikkoS1 = new System.Windows.Forms.Label();
            this.NimiLaatikkoS1 = new System.Windows.Forms.TextBox();
            this.IkaOtsikkoS1 = new System.Windows.Forms.Label();
            this.NaytaPainikeS1 = new System.Windows.Forms.Button();
            this.VastausLomake = new System.Windows.Forms.Panel();
            this.TiedotOtsikkoS2 = new System.Windows.Forms.Label();
            this.VastausS2 = new System.Windows.Forms.Label();
            this.IkaLaatikkoS1 = new System.Windows.Forms.TextBox();
            this.S2Vastaus = new System.Windows.Forms.Label();
            this.KyselyLomake.SuspendLayout();
            this.RyhmaLaatikko.SuspendLayout();
            this.VastausLomake.SuspendLayout();
            this.SuspendLayout();
            // 
            // KyselyLomake
            // 
            this.KyselyLomake.Controls.Add(this.NaytaPainikeS1);
            this.KyselyLomake.Controls.Add(this.RyhmaLaatikko);
            this.KyselyLomake.Location = new System.Drawing.Point(13, 27);
            this.KyselyLomake.Name = "KyselyLomake";
            this.KyselyLomake.Size = new System.Drawing.Size(214, 165);
            this.KyselyLomake.TabIndex = 0;
            // 
            // RyhmaLaatikko
            // 
            this.RyhmaLaatikko.Controls.Add(this.IkaLaatikkoS1);
            this.RyhmaLaatikko.Controls.Add(this.IkaOtsikkoS1);
            this.RyhmaLaatikko.Controls.Add(this.NimiLaatikkoS1);
            this.RyhmaLaatikko.Controls.Add(this.NimiOtsikkoS1);
            this.RyhmaLaatikko.Location = new System.Drawing.Point(7, 8);
            this.RyhmaLaatikko.Name = "RyhmaLaatikko";
            this.RyhmaLaatikko.Size = new System.Drawing.Size(200, 100);
            this.RyhmaLaatikko.TabIndex = 0;
            this.RyhmaLaatikko.TabStop = false;
            // 
            // NimiOtsikkoS1
            // 
            this.NimiOtsikkoS1.AutoSize = true;
            this.NimiOtsikkoS1.Location = new System.Drawing.Point(7, 20);
            this.NimiOtsikkoS1.Name = "NimiOtsikkoS1";
            this.NimiOtsikkoS1.Size = new System.Drawing.Size(41, 13);
            this.NimiOtsikkoS1.TabIndex = 0;
            this.NimiOtsikkoS1.Text = "Nimesi:";
            // 
            // NimiLaatikkoS1
            // 
            this.NimiLaatikkoS1.Location = new System.Drawing.Point(55, 20);
            this.NimiLaatikkoS1.Name = "NimiLaatikkoS1";
            this.NimiLaatikkoS1.Size = new System.Drawing.Size(139, 20);
            this.NimiLaatikkoS1.TabIndex = 1;
            // 
            // IkaOtsikkoS1
            // 
            this.IkaOtsikkoS1.AutoSize = true;
            this.IkaOtsikkoS1.Location = new System.Drawing.Point(10, 60);
            this.IkaOtsikkoS1.Name = "IkaOtsikkoS1";
            this.IkaOtsikkoS1.Size = new System.Drawing.Size(32, 13);
            this.IkaOtsikkoS1.TabIndex = 2;
            this.IkaOtsikkoS1.Text = "Ikäsi:";
            // 
            // NaytaPainikeS1
            // 
            this.NaytaPainikeS1.Location = new System.Drawing.Point(62, 114);
            this.NaytaPainikeS1.Name = "NaytaPainikeS1";
            this.NaytaPainikeS1.Size = new System.Drawing.Size(90, 41);
            this.NaytaPainikeS1.TabIndex = 1;
            this.NaytaPainikeS1.Text = "Näytä tiedot";
            this.NaytaPainikeS1.UseVisualStyleBackColor = true;
            this.NaytaPainikeS1.Click += new System.EventHandler(this.NaytaPainikeS1_Click);
            // 
            // VastausLomake
            // 
            this.VastausLomake.Controls.Add(this.S2Vastaus);
            this.VastausLomake.Controls.Add(this.VastausS2);
            this.VastausLomake.Controls.Add(this.TiedotOtsikkoS2);
            this.VastausLomake.Location = new System.Drawing.Point(256, 27);
            this.VastausLomake.Name = "VastausLomake";
            this.VastausLomake.Size = new System.Drawing.Size(257, 423);
            this.VastausLomake.TabIndex = 1;
            // 
            // TiedotOtsikkoS2
            // 
            this.TiedotOtsikkoS2.AutoSize = true;
            this.TiedotOtsikkoS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TiedotOtsikkoS2.Location = new System.Drawing.Point(7, 7);
            this.TiedotOtsikkoS2.Name = "TiedotOtsikkoS2";
            this.TiedotOtsikkoS2.Size = new System.Drawing.Size(57, 13);
            this.TiedotOtsikkoS2.TabIndex = 0;
            this.TiedotOtsikkoS2.Text = "TIEDOT:";
            this.TiedotOtsikkoS2.Click += new System.EventHandler(this.label1_Click);
            // 
            // VastausS2
            // 
            this.VastausS2.AutoSize = true;
            this.VastausS2.Location = new System.Drawing.Point(10, 35);
            this.VastausS2.Name = "VastausS2";
            this.VastausS2.Size = new System.Drawing.Size(0, 13);
            this.VastausS2.TabIndex = 1;
            // 
            // IkaLaatikkoS1
            // 
            this.IkaLaatikkoS1.Location = new System.Drawing.Point(55, 60);
            this.IkaLaatikkoS1.Name = "IkaLaatikkoS1";
            this.IkaLaatikkoS1.Size = new System.Drawing.Size(139, 20);
            this.IkaLaatikkoS1.TabIndex = 3;
            // 
            // S2Vastaus
            // 
            this.S2Vastaus.AutoSize = true;
            this.S2Vastaus.Location = new System.Drawing.Point(10, 45);
            this.S2Vastaus.Name = "S2Vastaus";
            this.S2Vastaus.Size = new System.Drawing.Size(35, 13);
            this.S2Vastaus.TabIndex = 2;
            this.S2Vastaus.Text = "label1";
            // 
            // Lomake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 462);
            this.Controls.Add(this.VastausLomake);
            this.Controls.Add(this.KyselyLomake);
            this.Name = "Lomake";
            this.Text = "Form1";
            this.KyselyLomake.ResumeLayout(false);
            this.RyhmaLaatikko.ResumeLayout(false);
            this.RyhmaLaatikko.PerformLayout();
            this.VastausLomake.ResumeLayout(false);
            this.VastausLomake.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel KyselyLomake;
        private System.Windows.Forms.Button NaytaPainikeS1;
        private System.Windows.Forms.GroupBox RyhmaLaatikko;
        private System.Windows.Forms.Label IkaOtsikkoS1;
        private System.Windows.Forms.TextBox NimiLaatikkoS1;
        private System.Windows.Forms.Label NimiOtsikkoS1;
        private System.Windows.Forms.Panel VastausLomake;
        private System.Windows.Forms.Label TiedotOtsikkoS2;
        private System.Windows.Forms.Label VastausS2;
        private System.Windows.Forms.TextBox IkaLaatikkoS1;
        private System.Windows.Forms.Label S2Vastaus;
    }
}

