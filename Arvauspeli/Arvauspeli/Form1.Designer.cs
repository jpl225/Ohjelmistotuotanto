namespace Arvauspeli
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
            this.ArvausTeksti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Vastausteksti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ArvausTeksti
            // 
            this.ArvausTeksti.Location = new System.Drawing.Point(171, 32);
            this.ArvausTeksti.Name = "ArvausTeksti";
            this.ArvausTeksti.Size = new System.Drawing.Size(33, 20);
            this.ArvausTeksti.TabIndex = 0;
            this.ArvausTeksti.TextChanged += new System.EventHandler(this.ArvausTeksti_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arvaa jokin luku 1-10 välillä:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Vastausteksti
            // 
            this.Vastausteksti.AutoSize = true;
            this.Vastausteksti.Location = new System.Drawing.Point(29, 74);
            this.Vastausteksti.Name = "Vastausteksti";
            this.Vastausteksti.Size = new System.Drawing.Size(0, 13);
            this.Vastausteksti.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 137);
            this.Controls.Add(this.Vastausteksti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArvausTeksti);
            this.Name = "Form1";
            this.Text = "Arvauspeli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ArvausTeksti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Vastausteksti;
    }
}

