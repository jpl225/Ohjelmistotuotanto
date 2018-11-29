namespace Horoskooppi
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
            this.sivu1 = new System.Windows.Forms.Panel();
            this.HoroskooppiOtsikko = new System.Windows.Forms.Label();
            this.ErityispiirteetOtsikko = new System.Windows.Forms.Label();
            this.HoroskooppiLaatikko = new System.Windows.Forms.TextBox();
            this.EPiirteetLaatikko = new System.Windows.Forms.RichTextBox();
            this.Otsikko1 = new System.Windows.Forms.Label();
            this.NaytaPainike = new System.Windows.Forms.Button();
            this.PeruutaPainike = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.sivu2 = new System.Windows.Forms.Panel();
            this.OtsikkoHoroskooppiS2 = new System.Windows.Forms.Label();
            this.VastausTeksti1 = new System.Windows.Forms.Label();
            this.ErityispiirteetOtsikkoS2 = new System.Windows.Forms.Label();
            this.Vastausteksti2 = new System.Windows.Forms.Label();
            this.OKPainike = new System.Windows.Forms.Button();
            this.sivu1.SuspendLayout();
            this.sivu2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sivu1
            // 
            this.sivu1.Controls.Add(this.PeruutaPainike);
            this.sivu1.Controls.Add(this.NaytaPainike);
            this.sivu1.Controls.Add(this.Otsikko1);
            this.sivu1.Controls.Add(this.EPiirteetLaatikko);
            this.sivu1.Controls.Add(this.HoroskooppiLaatikko);
            this.sivu1.Controls.Add(this.ErityispiirteetOtsikko);
            this.sivu1.Controls.Add(this.HoroskooppiOtsikko);
            this.sivu1.Location = new System.Drawing.Point(13, 13);
            this.sivu1.Name = "sivu1";
            this.sivu1.Size = new System.Drawing.Size(348, 256);
            this.sivu1.TabIndex = 0;
            this.sivu1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // HoroskooppiOtsikko
            // 
            this.HoroskooppiOtsikko.AutoSize = true;
            this.HoroskooppiOtsikko.Location = new System.Drawing.Point(3, 58);
            this.HoroskooppiOtsikko.Name = "HoroskooppiOtsikko";
            this.HoroskooppiOtsikko.Size = new System.Drawing.Size(70, 13);
            this.HoroskooppiOtsikko.TabIndex = 0;
            this.HoroskooppiOtsikko.Text = "Horoskooppi:";
            // 
            // ErityispiirteetOtsikko
            // 
            this.ErityispiirteetOtsikko.AutoSize = true;
            this.ErityispiirteetOtsikko.Location = new System.Drawing.Point(8, 96);
            this.ErityispiirteetOtsikko.Name = "ErityispiirteetOtsikko";
            this.ErityispiirteetOtsikko.Size = new System.Drawing.Size(68, 13);
            this.ErityispiirteetOtsikko.TabIndex = 1;
            this.ErityispiirteetOtsikko.Text = "Erityispiirteet:";
            // 
            // HoroskooppiLaatikko
            // 
            this.HoroskooppiLaatikko.Location = new System.Drawing.Point(71, 55);
            this.HoroskooppiLaatikko.Name = "HoroskooppiLaatikko";
            this.HoroskooppiLaatikko.Size = new System.Drawing.Size(256, 20);
            this.HoroskooppiLaatikko.TabIndex = 2;
            // 
            // EPiirteetLaatikko
            // 
            this.EPiirteetLaatikko.Location = new System.Drawing.Point(71, 93);
            this.EPiirteetLaatikko.Name = "EPiirteetLaatikko";
            this.EPiirteetLaatikko.Size = new System.Drawing.Size(256, 96);
            this.EPiirteetLaatikko.TabIndex = 3;
            this.EPiirteetLaatikko.Text = "";
            // 
            // Otsikko1
            // 
            this.Otsikko1.AutoSize = true;
            this.Otsikko1.Location = new System.Drawing.Point(23, 14);
            this.Otsikko1.Name = "Otsikko1";
            this.Otsikko1.Size = new System.Drawing.Size(262, 13);
            this.Otsikko1.TabIndex = 4;
            this.Otsikko1.Text = "Anna horoskooppi merkkisi ja kerro sen erityispiirteistä:";
            // 
            // NaytaPainike
            // 
            this.NaytaPainike.Location = new System.Drawing.Point(112, 211);
            this.NaytaPainike.Name = "NaytaPainike";
            this.NaytaPainike.Size = new System.Drawing.Size(75, 23);
            this.NaytaPainike.TabIndex = 5;
            this.NaytaPainike.Text = "Näytä";
            this.NaytaPainike.UseVisualStyleBackColor = true;
            this.NaytaPainike.Click += new System.EventHandler(this.NaytaPainike_Click);
            // 
            // PeruutaPainike
            // 
            this.PeruutaPainike.Location = new System.Drawing.Point(194, 211);
            this.PeruutaPainike.Name = "PeruutaPainike";
            this.PeruutaPainike.Size = new System.Drawing.Size(75, 23);
            this.PeruutaPainike.TabIndex = 6;
            this.PeruutaPainike.Text = "Peruuta";
            this.PeruutaPainike.UseVisualStyleBackColor = true;
            this.PeruutaPainike.Click += new System.EventHandler(this.PeruutaPainike_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // sivu2
            // 
            this.sivu2.Controls.Add(this.OKPainike);
            this.sivu2.Controls.Add(this.Vastausteksti2);
            this.sivu2.Controls.Add(this.ErityispiirteetOtsikkoS2);
            this.sivu2.Controls.Add(this.VastausTeksti1);
            this.sivu2.Controls.Add(this.OtsikkoHoroskooppiS2);
            this.sivu2.Location = new System.Drawing.Point(13, 13);
            this.sivu2.Name = "sivu2";
            this.sivu2.Size = new System.Drawing.Size(200, 256);
            this.sivu2.TabIndex = 1;
            this.sivu2.Visible = false;
            // 
            // OtsikkoHoroskooppiS2
            // 
            this.OtsikkoHoroskooppiS2.AutoSize = true;
            this.OtsikkoHoroskooppiS2.Location = new System.Drawing.Point(20, 26);
            this.OtsikkoHoroskooppiS2.Name = "OtsikkoHoroskooppiS2";
            this.OtsikkoHoroskooppiS2.Size = new System.Drawing.Size(70, 13);
            this.OtsikkoHoroskooppiS2.TabIndex = 0;
            this.OtsikkoHoroskooppiS2.Text = "Horoskooppi:";
            // 
            // VastausTeksti1
            // 
            this.VastausTeksti1.AutoSize = true;
            this.VastausTeksti1.Location = new System.Drawing.Point(23, 57);
            this.VastausTeksti1.Name = "VastausTeksti1";
            this.VastausTeksti1.Size = new System.Drawing.Size(0, 13);
            this.VastausTeksti1.TabIndex = 1;
            // 
            // ErityispiirteetOtsikkoS2
            // 
            this.ErityispiirteetOtsikkoS2.AutoSize = true;
            this.ErityispiirteetOtsikkoS2.Location = new System.Drawing.Point(23, 96);
            this.ErityispiirteetOtsikkoS2.Name = "ErityispiirteetOtsikkoS2";
            this.ErityispiirteetOtsikkoS2.Size = new System.Drawing.Size(68, 13);
            this.ErityispiirteetOtsikkoS2.TabIndex = 2;
            this.ErityispiirteetOtsikkoS2.Text = "Erityispiirteet:";
            // 
            // Vastausteksti2
            // 
            this.Vastausteksti2.AutoSize = true;
            this.Vastausteksti2.Location = new System.Drawing.Point(23, 125);
            this.Vastausteksti2.Name = "Vastausteksti2";
            this.Vastausteksti2.Size = new System.Drawing.Size(0, 13);
            this.Vastausteksti2.TabIndex = 3;
            // 
            // OKPainike
            // 
            this.OKPainike.Location = new System.Drawing.Point(62, 194);
            this.OKPainike.Name = "OKPainike";
            this.OKPainike.Size = new System.Drawing.Size(75, 23);
            this.OKPainike.TabIndex = 4;
            this.OKPainike.Text = "OK";
            this.OKPainike.UseVisualStyleBackColor = true;
            this.OKPainike.Click += new System.EventHandler(this.OKPainike_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 273);
            this.Controls.Add(this.sivu2);
            this.Controls.Add(this.sivu1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.sivu1.ResumeLayout(false);
            this.sivu1.PerformLayout();
            this.sivu2.ResumeLayout(false);
            this.sivu2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sivu1;
        private System.Windows.Forms.RichTextBox EPiirteetLaatikko;
        private System.Windows.Forms.TextBox HoroskooppiLaatikko;
        private System.Windows.Forms.Label ErityispiirteetOtsikko;
        private System.Windows.Forms.Label HoroskooppiOtsikko;
        private System.Windows.Forms.Button PeruutaPainike;
        private System.Windows.Forms.Button NaytaPainike;
        private System.Windows.Forms.Label Otsikko1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel sivu2;
        private System.Windows.Forms.Button OKPainike;
        private System.Windows.Forms.Label Vastausteksti2;
        private System.Windows.Forms.Label ErityispiirteetOtsikkoS2;
        private System.Windows.Forms.Label VastausTeksti1;
        private System.Windows.Forms.Label OtsikkoHoroskooppiS2;
    }
}

