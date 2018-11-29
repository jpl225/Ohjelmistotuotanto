using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KirjainLaskenta
{
    public partial class Form1 : Form
    {
        int pituus = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NaytaPainike2_Click(object sender, EventArgs e)
        {
            String valiteksti;
            valiteksti = TekstiLaatikko.Text;
            valiteksti = valiteksti.Replace(" ", "");
            VastausTekstiS4.Text = TekstiLaatikko.Text;
            pituus = valiteksti.Length;
            VastausPituusS5.Text = Convert.ToString(pituus);

        }

        private void OtsikkoTekstiS3_Click(object sender, EventArgs e)
        {

        }

        private void OKPainikeS2_Click(object sender, EventArgs e)
        {
            Sivu2.Visible = false;
            sivu3.Visible = true;
            
        }

        private void OKPainikeS3_Click(object sender, EventArgs e)
        {
            sivu3.Visible = false;
            Sivu1.Visible = true;
        }

        private void NaytaPainike1_Click(object sender, EventArgs e)
        {
            pituus = TekstiLaatikko.Text.Length;
            sivu3.Visible = false;
            Sivu1.Visible = true;
            VastausTekstiS2.Text = TekstiLaatikko.Text;
            VastausPituusS3.Text = Convert.ToString(pituus);
        }

        private void OKPainikeS4_Click(object sender, EventArgs e)
        {
            Sivu4.Visible = false;
            Sivu5.Visible = true;
        }

        private void OKPainikeS5_Click(object sender, EventArgs e)
        {
            Sivu5.Visible = false;
            Sivu1.Visible = true;
        }
    }
}
