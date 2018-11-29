using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horoskooppi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NaytaPainike_Click(object sender, EventArgs e)
        {
            sivu1.Visible = false;
            sivu2.Visible = true;
            VastausTeksti1.Text = HoroskooppiLaatikko.Text;
            Vastausteksti2.Text = EPiirteetLaatikko.Text;
        }

        private void OKPainike_Click(object sender, EventArgs e)
        {
            sivu2.Visible = false;
            sivu1.Visible = true;
        }

        private void PeruutaPainike_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            toolTip1.SetToolTip(NaytaPainike, "paina minua");
        }
    }
}
