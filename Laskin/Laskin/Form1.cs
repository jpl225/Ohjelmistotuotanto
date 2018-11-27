using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laskin
{
    public partial class Form1 : Form
    {
        double luku1, luku2, vastaus;
        string teksti1, teksti2;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MiinusPainike_Click(object sender, EventArgs e)
        {

            luku1 = Convert.ToDouble(Luku1Teksti.Text);
            luku2 = Convert.ToDouble(Luku2Teksti.Text);
            vastaus = luku1 - luku2;
            Vastausteksti.Text = Convert.ToString(vastaus);
        }

        private void KertoPainike_Click(object sender, EventArgs e)
        {
            luku1 = Convert.ToDouble(Luku1Teksti.Text);
            luku2 = Convert.ToDouble(Luku2Teksti.Text);
            vastaus = luku1 * luku2;
            Vastausteksti.Text = Convert.ToString(vastaus);
        }

        private void JakoPainike_Click(object sender, EventArgs e)
        {
            luku1 = Convert.ToDouble(Luku1Teksti.Text);
            luku2 = Convert.ToDouble(Luku2Teksti.Text);
            vastaus = luku1 / luku2;
            Vastausteksti.Text = Convert.ToString(vastaus);
        }

        private void Luku1Teksti_TextChanged(object sender, EventArgs e)
        {
            teksti1 = Luku1Teksti.Text;
            Tarkasta(teksti1);
        }

        private void Luku2Teksti_TextChanged(object sender, EventArgs e)
        {
            teksti2 = Luku2Teksti.Text;
            Tarkasta(teksti2);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void PlusPainike_Click(object sender, EventArgs e)
        {
            
            luku1 = Convert.ToDouble(Luku1Teksti.Text);
            luku2 = Convert.ToDouble(Luku2Teksti.Text);
            vastaus = luku1 + luku2;
            Vastausteksti.Text = Convert.ToString(vastaus);
        }
        private double Tarkasta(string teksti)
        {
            if(teksti != "")
            {
                try
                {
                    double arvo1 = Convert.ToDouble(teksti);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Antamasi arvo ei ole luku! " + ex);
                    Luku1Teksti.Focus();
                }

            }
            return arvo1;
        }
    }

}
