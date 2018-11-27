namespace Muodot
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
            this.Spainike = new System.Windows.Forms.Button();
            this.Ypainike = new System.Windows.Forms.Button();
            this.Kpainike = new System.Windows.Forms.Button();
            this.Sboxi = new System.Windows.Forms.PictureBox();
            this.Yboxi = new System.Windows.Forms.PictureBox();
            this.Kboxi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Sboxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yboxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kboxi)).BeginInit();
            this.SuspendLayout();
            // 
            // Spainike
            // 
            this.Spainike.Location = new System.Drawing.Point(41, 27);
            this.Spainike.Name = "Spainike";
            this.Spainike.Size = new System.Drawing.Size(75, 23);
            this.Spainike.TabIndex = 0;
            this.Spainike.Text = "Suorakulmio";
            this.Spainike.UseVisualStyleBackColor = true;
            this.Spainike.Click += new System.EventHandler(this.Spainike_Click);
            // 
            // Ypainike
            // 
            this.Ypainike.Location = new System.Drawing.Point(140, 27);
            this.Ypainike.Name = "Ypainike";
            this.Ypainike.Size = new System.Drawing.Size(75, 23);
            this.Ypainike.TabIndex = 1;
            this.Ypainike.Text = "Ympyrä";
            this.Ypainike.UseVisualStyleBackColor = true;
            this.Ypainike.Click += new System.EventHandler(this.Ypainike_Click);
            // 
            // Kpainike
            // 
            this.Kpainike.Location = new System.Drawing.Point(241, 27);
            this.Kpainike.Name = "Kpainike";
            this.Kpainike.Size = new System.Drawing.Size(75, 23);
            this.Kpainike.TabIndex = 2;
            this.Kpainike.Text = "Kolmio";
            this.Kpainike.UseVisualStyleBackColor = true;
            this.Kpainike.Click += new System.EventHandler(this.Kpainike_Click);
            // 
            // Sboxi
            // 
            this.Sboxi.Image = ((System.Drawing.Image)(resources.GetObject("Sboxi.Image")));
            this.Sboxi.Location = new System.Drawing.Point(79, 74);
            this.Sboxi.Name = "Sboxi";
            this.Sboxi.Size = new System.Drawing.Size(178, 158);
            this.Sboxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Sboxi.TabIndex = 3;
            this.Sboxi.TabStop = false;
            this.Sboxi.Visible = false;
            // 
            // Yboxi
            // 
            this.Yboxi.Image = ((System.Drawing.Image)(resources.GetObject("Yboxi.Image")));
            this.Yboxi.Location = new System.Drawing.Point(79, 74);
            this.Yboxi.Name = "Yboxi";
            this.Yboxi.Size = new System.Drawing.Size(178, 158);
            this.Yboxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Yboxi.TabIndex = 4;
            this.Yboxi.TabStop = false;
            this.Yboxi.Visible = false;
            // 
            // Kboxi
            // 
            this.Kboxi.Image = ((System.Drawing.Image)(resources.GetObject("Kboxi.Image")));
            this.Kboxi.Location = new System.Drawing.Point(79, 74);
            this.Kboxi.Name = "Kboxi";
            this.Kboxi.Size = new System.Drawing.Size(178, 158);
            this.Kboxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Kboxi.TabIndex = 5;
            this.Kboxi.TabStop = false;
            this.Kboxi.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 242);
            this.Controls.Add(this.Kboxi);
            this.Controls.Add(this.Yboxi);
            this.Controls.Add(this.Sboxi);
            this.Controls.Add(this.Kpainike);
            this.Controls.Add(this.Ypainike);
            this.Controls.Add(this.Spainike);
            this.Name = "Form1";
            this.Text = "Muodot";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sboxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yboxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kboxi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Spainike;
        private System.Windows.Forms.Button Ypainike;
        private System.Windows.Forms.Button Kpainike;
        private System.Windows.Forms.PictureBox Sboxi;
        private System.Windows.Forms.PictureBox Yboxi;
        private System.Windows.Forms.PictureBox Kboxi;
    }
}

