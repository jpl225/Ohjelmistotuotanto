namespace LisaaPaivitaPoistaSQL
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
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.txtHtun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEnimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSnimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtKunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTutkinto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPalkka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtVeroprosentti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPvm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtOstunnus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtHtun,
            this.txtEnimi,
            this.txtSnimi,
            this.txtKunta,
            this.txtTutkinto,
            this.txtPalkka,
            this.txtVeroprosentti,
            this.txtPvm,
            this.txtOstunnus});
            this.dgvEmployee.Location = new System.Drawing.Point(4, 7);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowTemplate.Height = 28;
            this.dgvEmployee.Size = new System.Drawing.Size(1257, 441);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellValueChanged);
            // 
            // txtHtun
            // 
            this.txtHtun.DataPropertyName = "htun";
            this.txtHtun.HeaderText = "Htun";
            this.txtHtun.Name = "txtHtun";
            // 
            // txtEnimi
            // 
            this.txtEnimi.DataPropertyName = "enimi";
            this.txtEnimi.HeaderText = "Enimi";
            this.txtEnimi.Name = "txtEnimi";
            this.txtEnimi.Width = 414;
            // 
            // txtSnimi
            // 
            this.txtSnimi.DataPropertyName = "snimi";
            this.txtSnimi.HeaderText = "Snimi";
            this.txtSnimi.Name = "txtSnimi";
            // 
            // txtKunta
            // 
            this.txtKunta.DataPropertyName = "kunta";
            this.txtKunta.HeaderText = "Kunta";
            this.txtKunta.Name = "txtKunta";
            // 
            // txtTutkinto
            // 
            this.txtTutkinto.DataPropertyName = "tutkinto";
            this.txtTutkinto.HeaderText = "Tutkinto";
            this.txtTutkinto.Name = "txtTutkinto";
            // 
            // txtPalkka
            // 
            this.txtPalkka.DataPropertyName = "palkka";
            this.txtPalkka.HeaderText = "Palkka";
            this.txtPalkka.Name = "txtPalkka";
            // 
            // txtVeroprosentti
            // 
            this.txtVeroprosentti.DataPropertyName = "veroprosentti";
            this.txtVeroprosentti.HeaderText = "Veroprosentti";
            this.txtVeroprosentti.Name = "txtVeroprosentti";
            // 
            // txtPvm
            // 
            this.txtPvm.DataPropertyName = "pvm";
            this.txtPvm.HeaderText = "Pvm";
            this.txtPvm.Name = "txtPvm";
            // 
            // txtOstunnus
            // 
            this.txtOstunnus.DataPropertyName = "ostunnus";
            this.txtOstunnus.HeaderText = "Ostunnus";
            this.txtOstunnus.Name = "txtOstunnus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 450);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtHtun;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEnimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSnimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtKunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTutkinto;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPalkka;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtVeroprosentti;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPvm;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtOstunnus;
    }
}

