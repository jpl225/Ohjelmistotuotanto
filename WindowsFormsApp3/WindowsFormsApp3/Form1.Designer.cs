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
            this.NaytaPainikeS1 = new System.Windows.Forms.Button();
            this.RyhmaLaatikko = new System.Windows.Forms.GroupBox();
            this.IkaLaatikkoS1 = new System.Windows.Forms.TextBox();
            this.IkaOtsikkoS1 = new System.Windows.Forms.Label();
            this.NimiLaatikkoS1 = new System.Windows.Forms.TextBox();
            this.NimiOtsikkoS1 = new System.Windows.Forms.Label();
            this.VastausLomake = new System.Windows.Forms.Panel();
            this.TakaisinPainike = new System.Windows.Forms.Button();
            this.S2Vastaus = new System.Windows.Forms.Label();
            this.VastausS2 = new System.Windows.Forms.Label();
            this.TiedotOtsikkoS2 = new System.Windows.Forms.Label();
            this.KyselyLomake.SuspendLayout();
            this.RyhmaLaatikko.SuspendLayout();
            this.VastausLomake.SuspendLayout();
            this.SuspendLayout();
            // 
            // KyselyLomake
            // 
            this.KyselyLomake.Controls.Add(this.NaytaPainikeS1);
            this.KyselyLomake.Controls.Add(this.RyhmaLaatikko);
            this.KyselyLomake.Location = new System.Drawing.Point(20, 42);
            this.KyselyLomake.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.KyselyLomake.Name = "KyselyLomake";
            this.KyselyLomake.Size = new System.Drawing.Size(321, 254);
            this.KyselyLomake.TabIndex = 0;
            // 
            // NaytaPainikeS1
            // 
            this.NaytaPainikeS1.Location = new System.Drawing.Point(93, 175);
            this.NaytaPainikeS1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NaytaPainikeS1.Name = "NaytaPainikeS1";
            this.NaytaPainikeS1.Size = new System.Drawing.Size(135, 63);
            this.NaytaPainikeS1.TabIndex = 1;
            this.NaytaPainikeS1.Text = "Näytä tiedot";
            this.NaytaPainikeS1.UseVisualStyleBackColor = true;
            this.NaytaPainikeS1.Click += new System.EventHandler(this.NaytaPainikeS1_Click);
            // 
            // RyhmaLaatikko
            // 
            this.RyhmaLaatikko.Controls.Add(this.IkaLaatikkoS1);
            this.RyhmaLaatikko.Controls.Add(this.IkaOtsikkoS1);
            this.RyhmaLaatikko.Controls.Add(this.NimiLaatikkoS1);
            this.RyhmaLaatikko.Controls.Add(this.NimiOtsikkoS1);
            this.RyhmaLaatikko.Location = new System.Drawing.Point(10, 12);
            this.RyhmaLaatikko.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RyhmaLaatikko.Name = "RyhmaLaatikko";
            this.RyhmaLaatikko.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RyhmaLaatikko.Size = new System.Drawing.Size(300, 154);
            this.RyhmaLaatikko.TabIndex = 0;
            this.RyhmaLaatikko.TabStop = false;
            // 
            // IkaLaatikkoS1
            // 
            this.IkaLaatikkoS1.Location = new System.Drawing.Point(82, 92);
            this.IkaLaatikkoS1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IkaLaatikkoS1.Name = "IkaLaatikkoS1";
            this.IkaLaatikkoS1.Size = new System.Drawing.Size(206, 26);
            this.IkaLaatikkoS1.TabIndex = 3;
            // 
            // IkaOtsikkoS1
            // 
            this.IkaOtsikkoS1.AutoSize = true;
            this.IkaOtsikkoS1.Location = new System.Drawing.Point(15, 92);
            this.IkaOtsikkoS1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IkaOtsikkoS1.Name = "IkaOtsikkoS1";
            this.IkaOtsikkoS1.Size = new System.Drawing.Size(46, 20);
            this.IkaOtsikkoS1.TabIndex = 2;
            this.IkaOtsikkoS1.Text = "Ikäsi:";
            // 
            // NimiLaatikkoS1
            // 
            this.NimiLaatikkoS1.Location = new System.Drawing.Point(82, 31);
            this.NimiLaatikkoS1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NimiLaatikkoS1.Name = "NimiLaatikkoS1";
            this.NimiLaatikkoS1.Size = new System.Drawing.Size(206, 26);
            this.NimiLaatikkoS1.TabIndex = 1;
            // 
            // NimiOtsikkoS1
            // 
            this.NimiOtsikkoS1.AutoSize = true;
            this.NimiOtsikkoS1.Location = new System.Drawing.Point(10, 31);
            this.NimiOtsikkoS1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NimiOtsikkoS1.Name = "NimiOtsikkoS1";
            this.NimiOtsikkoS1.Size = new System.Drawing.Size(60, 20);
            this.NimiOtsikkoS1.TabIndex = 0;
            this.NimiOtsikkoS1.Text = "Nimesi:";
            // 
            // VastausLomake
            // 
            this.VastausLomake.Controls.Add(this.TakaisinPainike);
            this.VastausLomake.Controls.Add(this.S2Vastaus);
            this.VastausLomake.Controls.Add(this.VastausS2);
            this.VastausLomake.Controls.Add(this.TiedotOtsikkoS2);
            this.VastausLomake.Location = new System.Drawing.Point(384, 42);
            this.VastausLomake.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VastausLomake.Name = "VastausLomake";
            this.VastausLomake.Size = new System.Drawing.Size(386, 651);
            this.VastausLomake.TabIndex = 1;
            // 
            // TakaisinPainike
            // 
            this.TakaisinPainike.Location = new System.Drawing.Point(275, 27);
            this.TakaisinPainike.Name = "TakaisinPainike";
            this.TakaisinPainike.Size = new System.Drawing.Size(93, 42);
            this.TakaisinPainike.TabIndex = 3;
            this.TakaisinPainike.Text = "Takaisin";
            this.TakaisinPainike.UseVisualStyleBackColor = true;
            this.TakaisinPainike.Click += new System.EventHandler(this.TakaisinPainike_Click);
            // 
            // S2Vastaus
            // 
            this.S2Vastaus.AutoSize = true;
            this.S2Vastaus.Location = new System.Drawing.Point(15, 69);
            this.S2Vastaus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.S2Vastaus.Name = "S2Vastaus";
            this.S2Vastaus.Size = new System.Drawing.Size(0, 20);
            this.S2Vastaus.TabIndex = 2;
            // 
            // VastausS2
            // 
            this.VastausS2.AutoSize = true;
            this.VastausS2.Location = new System.Drawing.Point(15, 54);
            this.VastausS2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VastausS2.Name = "VastausS2";
            this.VastausS2.Size = new System.Drawing.Size(0, 20);
            this.VastausS2.TabIndex = 1;
            // 
            // TiedotOtsikkoS2
            // 
            this.TiedotOtsikkoS2.AutoSize = true;
            this.TiedotOtsikkoS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TiedotOtsikkoS2.Location = new System.Drawing.Point(10, 11);
            this.TiedotOtsikkoS2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TiedotOtsikkoS2.Name = "TiedotOtsikkoS2";
            this.TiedotOtsikkoS2.Size = new System.Drawing.Size(82, 20);
            this.TiedotOtsikkoS2.TabIndex = 0;
            this.TiedotOtsikkoS2.Text = "TIEDOT:";
            this.TiedotOtsikkoS2.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lomake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 711);
            this.Controls.Add(this.VastausLomake);
            this.Controls.Add(this.KyselyLomake);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button TakaisinPainike;
    }
}

