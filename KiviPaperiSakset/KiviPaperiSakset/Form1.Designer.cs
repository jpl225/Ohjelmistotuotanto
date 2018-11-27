namespace KiviPaperiSakset
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.KiviKuva = new System.Windows.Forms.PictureBox();
            this.PaperiKuva = new System.Windows.Forms.PictureBox();
            this.SaksetKuva = new System.Windows.Forms.PictureBox();
            this.PelaajanPisteet = new System.Windows.Forms.NumericUpDown();
            this.KoneenPisteet = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.KiviKuva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaperiKuva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaksetKuva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PelaajanPisteet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KoneenPisteet)).BeginInit();
            this.SuspendLayout();
            // 
            // KiviKuva
            // 
            this.KiviKuva.Image = ((System.Drawing.Image)(resources.GetObject("KiviKuva.Image")));
            this.KiviKuva.Location = new System.Drawing.Point(52, 106);
            this.KiviKuva.Name = "KiviKuva";
            this.KiviKuva.Size = new System.Drawing.Size(185, 170);
            this.KiviKuva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.KiviKuva.TabIndex = 0;
            this.KiviKuva.TabStop = false;
            // 
            // PaperiKuva
            // 
            this.PaperiKuva.Image = ((System.Drawing.Image)(resources.GetObject("PaperiKuva.Image")));
            this.PaperiKuva.Location = new System.Drawing.Point(298, 106);
            this.PaperiKuva.Name = "PaperiKuva";
            this.PaperiKuva.Size = new System.Drawing.Size(185, 170);
            this.PaperiKuva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PaperiKuva.TabIndex = 1;
            this.PaperiKuva.TabStop = false;
            // 
            // SaksetKuva
            // 
            this.SaksetKuva.Image = ((System.Drawing.Image)(resources.GetObject("SaksetKuva.Image")));
            this.SaksetKuva.Location = new System.Drawing.Point(545, 106);
            this.SaksetKuva.Name = "SaksetKuva";
            this.SaksetKuva.Size = new System.Drawing.Size(185, 170);
            this.SaksetKuva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SaksetKuva.TabIndex = 2;
            this.SaksetKuva.TabStop = false;
            // 
            // PelaajanPisteet
            // 
            this.PelaajanPisteet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PelaajanPisteet.Location = new System.Drawing.Point(318, 36);
            this.PelaajanPisteet.Name = "PelaajanPisteet";
            this.PelaajanPisteet.Size = new System.Drawing.Size(52, 31);
            this.PelaajanPisteet.TabIndex = 3;
            // 
            // KoneenPisteet
            // 
            this.KoneenPisteet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KoneenPisteet.Location = new System.Drawing.Point(413, 36);
            this.KoneenPisteet.Name = "KoneenPisteet";
            this.KoneenPisteet.Size = new System.Drawing.Size(52, 31);
            this.KoneenPisteet.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pelaaja";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kone";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 317);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KoneenPisteet);
            this.Controls.Add(this.PelaajanPisteet);
            this.Controls.Add(this.SaksetKuva);
            this.Controls.Add(this.PaperiKuva);
            this.Controls.Add(this.KiviKuva);
            this.Name = "Form1";
            this.Text = "Kivi, paperi ja sakset";
            ((System.ComponentModel.ISupportInitialize)(this.KiviKuva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaperiKuva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaksetKuva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PelaajanPisteet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KoneenPisteet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox KiviKuva;
        private System.Windows.Forms.PictureBox PaperiKuva;
        private System.Windows.Forms.PictureBox SaksetKuva;
        private System.Windows.Forms.NumericUpDown PelaajanPisteet;
        private System.Windows.Forms.NumericUpDown KoneenPisteet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

