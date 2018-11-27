using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muodot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Spainike_Click(object sender, EventArgs e)
        {
            Sboxi.Visible = true;
            Yboxi.Visible = false;
            Kboxi.Visible = false;
        }

        private void Ypainike_Click(object sender, EventArgs e)
        {
            Sboxi.Visible = false;
            Yboxi.Visible = true;
            Kboxi.Visible = false;
        }

        private void Kpainike_Click(object sender, EventArgs e)
        {
            Sboxi.Visible = false;
            Yboxi.Visible = false;
            Kboxi.Visible = true;
        }
    }
}
