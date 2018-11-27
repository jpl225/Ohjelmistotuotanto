using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KukkiaJaMehilaisia
{
    public partial class Form1 : Form
    {
        int Kukkia = 0;
        int Mehilaisia = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void kukkaPainike_Click(object sender, EventArgs e)
        {
            Kukkia++;
            KukkaTeksti.Text = "Kukkia: " + Convert.ToString(Kukkia);
        }

        private void PorroPainike_Click(object sender, EventArgs e)
        {
            Mehilaisia++;
            PorroTeksti.Text = "Mehiläisiä: " + Convert.ToString(Mehilaisia);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PictureBoxMehilainen.Left = PictureBoxMehilainen.Left + 1;
        }
    }
}
