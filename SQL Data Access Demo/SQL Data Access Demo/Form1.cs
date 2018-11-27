using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Data_Access_Demo
{
    public partial class Form1 : Form
    {
        List<Automyynti> automyynti = new List<Automyynti>();
        public Form1()
        {
            InitializeComponent();

            loydetytAutotlista.DataSource = automyynti;
            loydetytAutotlista.DisplayMember = "FullInfo";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            automyynti = db.GetAutomyynti(merkki: merkkiText.Text);
            loydetytAutotlista.DataSource = automyynti;
            loydetytAutotlista.DisplayMember = "FullInfo";
        }
    }
}
