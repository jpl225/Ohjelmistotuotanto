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
            Vastausteksti.Text = "Minun lukuni on " + (arvaus + 1) + " hävisit niukasti!";
        }
    }
}
