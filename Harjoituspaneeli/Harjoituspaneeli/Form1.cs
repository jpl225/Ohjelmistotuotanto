using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoituspaneeli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SeuraavaPainikeS1_Click(object sender, EventArgs e)
        {
            Sivu1.Visible = false;
            Sivu2.Visible = true;
        }

        private void EdellinenPainikeS2_Click(object sender, EventArgs e)
        {
            Sivu2.Visible = false;
            Sivu1.Visible = true;
        }

        private void SeuraavaPainikeS2_Click(object sender, EventArgs e)
        {
            Sivu2.Visible = false;
            Sivu3.Visible = true;
        }

        private void EdellinenPainikeS3_Click(object sender, EventArgs e)
        {
            Sivu3.Visible = false;
            Sivu2.Visible = true;
        }

        private void SeuraavaPainikeS3_Click(object sender, EventArgs e)
        {
            Sivu3.Visible = false;
            Sivu4.Visible = true;
        }

        private void EdellinenPainikeS4_Click(object sender, EventArgs e)
        {
            Sivu4.Visible = false;
            Sivu3.Visible = true;
        }
    }
}
