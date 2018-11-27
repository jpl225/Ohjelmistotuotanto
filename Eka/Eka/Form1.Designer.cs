namespace Eka
{
    partial class EkaLomake
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
            this.PainoNappi = new System.Windows.Forms.Button();
            this.ReagointiLippunen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PainoNappi
            // 
            this.PainoNappi.Location = new System.Drawing.Point(12, 12);
            this.PainoNappi.Name = "PainoNappi";
            this.PainoNappi.Size = new System.Drawing.Size(96, 23);
            this.PainoNappi.TabIndex = 0;
            this.PainoNappi.Text = "Napauta";
            this.PainoNappi.UseVisualStyleBackColor = true;
            this.PainoNappi.Click += new System.EventHandler(this.PainoNappi_Click);
            // 
            // ReagointiLippunen
            // 
            this.ReagointiLippunen.AutoSize = true;
            this.ReagointiLippunen.Location = new System.Drawing.Point(15, 41);
            this.ReagointiLippunen.Name = "ReagointiLippunen";
            this.ReagointiLippunen.Size = new System.Drawing.Size(0, 13);
            this.ReagointiLippunen.TabIndex = 1;
            // 
            // EkaLomake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 79);
            this.Controls.Add(this.ReagointiLippunen);
            this.Controls.Add(this.PainoNappi);
            this.Name = "EkaLomake";
            this.Text = "Eka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PainoNappi;
        private System.Windows.Forms.Label ReagointiLippunen;
    }
}

