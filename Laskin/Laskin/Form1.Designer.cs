namespace Laskin
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
            this.Luku1Teksti = new System.Windows.Forms.TextBox();
            this.Luku2Teksti = new System.Windows.Forms.TextBox();
            this.EnsimmainenTeksti = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PlusPainike = new System.Windows.Forms.Button();
            this.MiinusPainike = new System.Windows.Forms.Button();
            this.KertoPainike = new System.Windows.Forms.Button();
            this.JakoPainike = new System.Windows.Forms.Button();
            this.Vastausteksti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Luku1Teksti
            // 
            this.Luku1Teksti.Location = new System.Drawing.Point(23, 44);
            this.Luku1Teksti.Name = "Luku1Teksti";
            this.Luku1Teksti.Size = new System.Drawing.Size(100, 20);
            this.Luku1Teksti.TabIndex = 0;
            this.Luku1Teksti.TextChanged += new System.EventHandler(this.Luku1Teksti_TextChanged);
            // 
            // Luku2Teksti
            // 
            this.Luku2Teksti.Location = new System.Drawing.Point(172, 43);
            this.Luku2Teksti.Name = "Luku2Teksti";
            this.Luku2Teksti.Size = new System.Drawing.Size(100, 20);
            this.Luku2Teksti.TabIndex = 1;
            this.Luku2Teksti.TextChanged += new System.EventHandler(this.Luku2Teksti_TextChanged);
            // 
            // EnsimmainenTeksti
            // 
            this.EnsimmainenTeksti.AutoSize = true;
            this.EnsimmainenTeksti.Location = new System.Drawing.Point(23, 25);
            this.EnsimmainenTeksti.Name = "EnsimmainenTeksti";
            this.EnsimmainenTeksti.Size = new System.Drawing.Size(67, 13);
            this.EnsimmainenTeksti.TabIndex = 2;
            this.EnsimmainenTeksti.Text = "Anna 1. luku";
            this.EnsimmainenTeksti.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ToinenTeksti";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // PlusPainike
            // 
            this.PlusPainike.Location = new System.Drawing.Point(23, 71);
            this.PlusPainike.Name = "PlusPainike";
            this.PlusPainike.Size = new System.Drawing.Size(30, 30);
            this.PlusPainike.TabIndex = 4;
            this.PlusPainike.Text = "+";
            this.PlusPainike.UseVisualStyleBackColor = true;
            this.PlusPainike.Click += new System.EventHandler(this.PlusPainike_Click);
            // 
            // MiinusPainike
            // 
            this.MiinusPainike.Location = new System.Drawing.Point(60, 71);
            this.MiinusPainike.Name = "MiinusPainike";
            this.MiinusPainike.Size = new System.Drawing.Size(30, 30);
            this.MiinusPainike.TabIndex = 5;
            this.MiinusPainike.Text = "-";
            this.MiinusPainike.UseVisualStyleBackColor = true;
            this.MiinusPainike.Click += new System.EventHandler(this.MiinusPainike_Click);
            // 
            // KertoPainike
            // 
            this.KertoPainike.Location = new System.Drawing.Point(96, 71);
            this.KertoPainike.Name = "KertoPainike";
            this.KertoPainike.Size = new System.Drawing.Size(30, 30);
            this.KertoPainike.TabIndex = 6;
            this.KertoPainike.Text = "*";
            this.KertoPainike.UseVisualStyleBackColor = true;
            this.KertoPainike.Click += new System.EventHandler(this.KertoPainike_Click);
            // 
            // JakoPainike
            // 
            this.JakoPainike.Location = new System.Drawing.Point(132, 71);
            this.JakoPainike.Name = "JakoPainike";
            this.JakoPainike.Size = new System.Drawing.Size(30, 30);
            this.JakoPainike.TabIndex = 7;
            this.JakoPainike.Text = "/";
            this.JakoPainike.UseVisualStyleBackColor = true;
            this.JakoPainike.Click += new System.EventHandler(this.JakoPainike_Click);
            // 
            // Vastausteksti
            // 
            this.Vastausteksti.AutoSize = true;
            this.Vastausteksti.Location = new System.Drawing.Point(26, 129);
            this.Vastausteksti.Name = "Vastausteksti";
            this.Vastausteksti.Size = new System.Drawing.Size(0, 13);
            this.Vastausteksti.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Vastausteksti);
            this.Controls.Add(this.JakoPainike);
            this.Controls.Add(this.KertoPainike);
            this.Controls.Add(this.MiinusPainike);
            this.Controls.Add(this.PlusPainike);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnsimmainenTeksti);
            this.Controls.Add(this.Luku2Teksti);
            this.Controls.Add(this.Luku1Teksti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Luku1Teksti;
        private System.Windows.Forms.TextBox Luku2Teksti;
        private System.Windows.Forms.Label EnsimmainenTeksti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PlusPainike;
        private System.Windows.Forms.Button MiinusPainike;
        private System.Windows.Forms.Button KertoPainike;
        private System.Windows.Forms.Button JakoPainike;
        private System.Windows.Forms.Label Vastausteksti;
    }
}

