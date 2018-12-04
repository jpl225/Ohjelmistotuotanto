namespace KyselySQL
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
            this.SQLKysely = new System.Windows.Forms.TextBox();
            this.KyselyOtsikko = new System.Windows.Forms.Label();
            this.Vastaus = new System.Windows.Forms.DataGridView();
            this.SuoritaNappi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Vastaus)).BeginInit();
            this.SuspendLayout();
            // 
            // SQLKysely
            // 
            this.SQLKysely.Location = new System.Drawing.Point(28, 51);
            this.SQLKysely.Multiline = true;
            this.SQLKysely.Name = "SQLKysely";
            this.SQLKysely.Size = new System.Drawing.Size(215, 94);
            this.SQLKysely.TabIndex = 0;
            // 
            // KyselyOtsikko
            // 
            this.KyselyOtsikko.AutoSize = true;
            this.KyselyOtsikko.Location = new System.Drawing.Point(28, 32);
            this.KyselyOtsikko.Name = "KyselyOtsikko";
            this.KyselyOtsikko.Size = new System.Drawing.Size(149, 13);
            this.KyselyOtsikko.TabIndex = 1;
            this.KyselyOtsikko.Text = "Anna suoritettava SQL-kysely:";
            // 
            // Vastaus
            // 
            this.Vastaus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Vastaus.Location = new System.Drawing.Point(326, 51);
            this.Vastaus.Name = "Vastaus";
            this.Vastaus.Size = new System.Drawing.Size(240, 150);
            this.Vastaus.TabIndex = 2;
            // 
            // SuoritaNappi
            // 
            this.SuoritaNappi.Location = new System.Drawing.Point(41, 165);
            this.SuoritaNappi.Name = "SuoritaNappi";
            this.SuoritaNappi.Size = new System.Drawing.Size(136, 57);
            this.SuoritaNappi.TabIndex = 3;
            this.SuoritaNappi.Text = "Suorita kysely";
            this.SuoritaNappi.UseVisualStyleBackColor = true;
            this.SuoritaNappi.Click += new System.EventHandler(this.SuoritaNappi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SuoritaNappi);
            this.Controls.Add(this.Vastaus);
            this.Controls.Add(this.KyselyOtsikko);
            this.Controls.Add(this.SQLKysely);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Vastaus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SQLKysely;
        private System.Windows.Forms.Label KyselyOtsikko;
        private System.Windows.Forms.DataGridView Vastaus;
        private System.Windows.Forms.Button SuoritaNappi;
    }
}

