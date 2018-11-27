using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arvauspeli
{
    public partial class Form1 : Form
    {
        int arvaus;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ArvausTeksti_TextChanged(object sender, EventArgs e)
        {
            arvaus = Convert.ToInt32(ArvausTeksti.Text);
            Random rnd = new Random();
            int kone = rnd.Next(1, 11);
            if(arvaus > kone)
            {
                Vastausteksti.Text = "Sinun lukusi " + arvaus + " on suurempi \n kuin minun lukuni " + kone + " VOITIT!";
            }
            else if (kone > arvaus)
            {
                Vastausteksti.Text = "Minun lukuni " + kone + " on suurempi \n kuin sinun lukusi " + arvaus + " VOITIN!";

            }
            else
            {
                Vastausteksti.Text = "Tuli tasapeli";

            }
        }
    }
}
