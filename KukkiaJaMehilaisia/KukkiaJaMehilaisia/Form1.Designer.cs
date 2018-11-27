namespace KukkiaJaMehilaisia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kukkaPainike = new System.Windows.Forms.Button();
            this.PorroPainike = new System.Windows.Forms.Button();
            this.KukkaTeksti = new System.Windows.Forms.Label();
            this.PorroTeksti = new System.Windows.Forms.Label();
            this.PictureBoxMehilainen = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMehilainen)).BeginInit();
            this.SuspendLayout();
            // 
            // kukkaPainike
            // 
            this.kukkaPainike.Location = new System.Drawing.Point(55, 28);
            this.kukkaPainike.Name = "kukkaPainike";
            this.kukkaPainike.Size = new System.Drawing.Size(75, 23);
            this.kukkaPainike.TabIndex = 0;
            this.kukkaPainike.Text = "Lisää kukka";
            this.kukkaPainike.UseVisualStyleBackColor = true;
            this.kukkaPainike.Click += new System.EventHandler(this.kukkaPainike_Click);
            // 
            // PorroPainike
            // 
            this.PorroPainike.Location = new System.Drawing.Point(175, 27);
            this.PorroPainike.Name = "PorroPainike";
            this.PorroPainike.Size = new System.Drawing.Size(97, 23);
            this.PorroPainike.TabIndex = 1;
            this.PorroPainike.Text = "Lisaa mehilainen";
            this.PorroPainike.UseVisualStyleBackColor = true;
            this.PorroPainike.Click += new System.EventHandler(this.PorroPainike_Click);
            // 
            // KukkaTeksti
            // 
            this.KukkaTeksti.AutoSize = true;
            this.KukkaTeksti.Location = new System.Drawing.Point(55, 86);
            this.KukkaTeksti.Name = "KukkaTeksti";
            this.KukkaTeksti.Size = new System.Drawing.Size(49, 13);
            this.KukkaTeksti.TabIndex = 2;
            this.KukkaTeksti.Text = "Kukkia 0";
            this.KukkaTeksti.Click += new System.EventHandler(this.label1_Click);
            // 
            // PorroTeksti
            // 
            this.PorroTeksti.AutoSize = true;
            this.PorroTeksti.Location = new System.Drawing.Point(175, 85);
            this.PorroTeksti.Name = "PorroTeksti";
            this.PorroTeksti.Size = new System.Drawing.Size(62, 13);
            this.PorroTeksti.TabIndex = 3;
            this.PorroTeksti.Text = "Mehiläisiä 0";
            this.PorroTeksti.Click += new System.EventHandler(this.label2_Click);
            // 
            // PictureBoxMehilainen
            // 
            this.PictureBoxMehilainen.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxMehilainen.Image")));
            this.PictureBoxMehilainen.Location = new System.Drawing.Point(1, 146);
            this.PictureBoxMehilainen.Name = "PictureBoxMehilainen";
            this.PictureBoxMehilainen.Size = new System.Drawing.Size(46, 50);
            this.PictureBoxMehilainen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxMehilainen.TabIndex = 4;
            this.PictureBoxMehilainen.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 208);
            this.Controls.Add(this.PictureBoxMehilainen);
            this.Controls.Add(this.PorroTeksti);
            this.Controls.Add(this.KukkaTeksti);
            this.Controls.Add(this.PorroPainike);
            this.Controls.Add(this.kukkaPainike);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMehilainen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kukkaPainike;
        private System.Windows.Forms.Button PorroPainike;
        private System.Windows.Forms.Label KukkaTeksti;
        private System.Windows.Forms.Label PorroTeksti;
        private System.Windows.Forms.PictureBox PictureBoxMehilainen;
        private System.Windows.Forms.Timer timer1;
    }
}

