using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paneelit
{
    public partial class Paneeliharjoitus : Form
    {
        public Paneeliharjoitus()
        {
            InitializeComponent();
            Sivu1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sivu1.Visible = false;
            Sivu2.Visible = true;
            Paneeliharjoitus.ActiveForm.Text = "Saavuit sivulle 2, eikö ole ihmeellistä?";
        }

        private void SeuraavaPainikeS2_Click(object sender, EventArgs e)
        {
            Sivu2.Visible = false;
            Sivu3.Visible = true;
            Paneeliharjoitus.ActiveForm.Text = "Missäköhän nyt olet?";

        }

        private void EdellinenPainikeS2_Click(object sender, EventArgs e)
        {
            Sivu1.Visible = true;
            Sivu2.Visible = false;
            Paneeliharjoitus.ActiveForm.Text = "Ja takaisin alussa";

        }

        private void EdellinenPainikeS3_Click(object sender, EventArgs e)
        {
            Sivu3.Visible = false;
            Sivu2.Visible = true;
            Paneeliharjoitus.ActiveForm.Text = "Saavuit sivulle 2, eikö ole ihmeellistä?";
        }

        private void SeuraavaPainikeS3_Click(object sender, EventArgs e)
        {
            Sivu3.Visible = false;
            Sivu4.Visible = true;
            Paneeliharjoitus.ActiveForm.Text = "Täältä ei pääse kuin taaksepäin";

        }

        private void EdellinenPainikeS4_Click(object sender, EventArgs e)
        {
            Sivu4.Visible = false;
            Sivu3.Visible = true;
            Paneeliharjoitus.ActiveForm.Text = "Missäköhän nyt olet?";

        }
    }
}
