namespace Soitin
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
            this.KysymysTeksti = new System.Windows.Forms.Label();
            this.VastausPainike = new System.Windows.Forms.Button();
            this.VastausTeksti = new System.Windows.Forms.Label();
            this.KuvaBoxi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.KuvaBoxi)).BeginInit();
            this.SuspendLayout();
            // 
            // KysymysTeksti
            // 
            this.KysymysTeksti.AutoSize = true;
            this.KysymysTeksti.Location = new System.Drawing.Point(36, 33);
            this.KysymysTeksti.Name = "KysymysTeksti";
            this.KysymysTeksti.Size = new System.Drawing.Size(224, 13);
            this.KysymysTeksti.TabIndex = 0;
            this.KysymysTeksti.Text = "Mitä soitinta soitetaan joko plektralla tai ilman?";
            // 
            // VastausPainike
            // 
            this.VastausPainike.Location = new System.Drawing.Point(39, 67);
            this.VastausPainike.Name = "VastausPainike";
            this.VastausPainike.Size = new System.Drawing.Size(75, 43);
            this.VastausPainike.TabIndex = 1;
            this.VastausPainike.Text = "Näytä vastaus";
            this.VastausPainike.UseVisualStyleBackColor = true;
            this.VastausPainike.Click += new System.EventHandler(this.VastausPainike_Click);
            // 
            // VastausTeksti
            // 
            this.VastausTeksti.AutoSize = true;
            this.VastausTeksti.Location = new System.Drawing.Point(36, 141);
            this.VastausTeksti.Name = "VastausTeksti";
            this.VastausTeksti.Size = new System.Drawing.Size(40, 13);
            this.VastausTeksti.TabIndex = 2;
            this.VastausTeksti.Text = "Kitaraa";
            this.VastausTeksti.Visible = false;
            // 
            // KuvaBoxi
            // 
            this.KuvaBoxi.Image = ((System.Drawing.Image)(resources.GetObject("KuvaBoxi.Image")));
            this.KuvaBoxi.Location = new System.Drawing.Point(172, 67);
            this.KuvaBoxi.Name = "KuvaBoxi";
            this.KuvaBoxi.Size = new System.Drawing.Size(100, 194);
            this.KuvaBoxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.KuvaBoxi.TabIndex = 3;
            this.KuvaBoxi.TabStop = false;
            this.KuvaBoxi.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 294);
            this.Controls.Add(this.KuvaBoxi);
            this.Controls.Add(this.VastausTeksti);
            this.Controls.Add(this.VastausPainike);
            this.Controls.Add(this.KysymysTeksti);
            this.Name = "Form1";
            this.Text = "Mikä soitin?";
            ((System.ComponentModel.ISupportInitialize)(this.KuvaBoxi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KysymysTeksti;
        private System.Windows.Forms.Button VastausPainike;
        private System.Windows.Forms.Label VastausTeksti;
        private System.Windows.Forms.PictureBox KuvaBoxi;
    }
}

