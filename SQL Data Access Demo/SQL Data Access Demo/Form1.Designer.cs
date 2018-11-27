namespace SQL_Data_Access_Demo
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
            this.loydetytAutotlista = new System.Windows.Forms.ListBox();
            this.merkkiText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Etsi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loydetytAutotlista
            // 
            this.loydetytAutotlista.FormattingEnabled = true;
            this.loydetytAutotlista.Location = new System.Drawing.Point(22, 126);
            this.loydetytAutotlista.Name = "loydetytAutotlista";
            this.loydetytAutotlista.Size = new System.Drawing.Size(313, 251);
            this.loydetytAutotlista.TabIndex = 0;
            // 
            // merkkiText
            // 
            this.merkkiText.Location = new System.Drawing.Point(204, 59);
            this.merkkiText.Name = "merkkiText";
            this.merkkiText.Size = new System.Drawing.Size(131, 20);
            this.merkkiText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Merkki";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Etsi
            // 
            this.Etsi.Location = new System.Drawing.Point(145, 91);
            this.Etsi.Name = "Etsi";
            this.Etsi.Size = new System.Drawing.Size(75, 23);
            this.Etsi.TabIndex = 3;
            this.Etsi.Text = "Etsi";
            this.Etsi.UseVisualStyleBackColor = true;
            this.Etsi.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Etsi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.merkkiText);
            this.Controls.Add(this.loydetytAutotlista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox loydetytAutotlista;
        private System.Windows.Forms.TextBox merkkiText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Etsi;
    }
}

