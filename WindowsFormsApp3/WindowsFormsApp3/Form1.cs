using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Lomake : Form
    {
        int luku = 0;
        Ihminen[] eka = new Ihminen[10];
        public Lomake()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NaytaPainikeS1_Click(object sender, EventArgs e)
        {
            KyselyLomake.Visible = false;
            VastausLomake.Visible = true;
            eka[luku].ika = IkaLaatikkoS1.Text;
            eka[luku].nimi = NimiLaatikkoS1.Text;
            /*if(eka[luku].ika > 65)
            {
                eka[luku].status = "eläkeläinen";
                eka[luku].kelpoisuus = "hyväksytty";
            }
            else if(eka[luku].ika > 18)
            {
                eka[luku].status = "aikuinen";
                eka[luku].kelpoisuus = "hylätty";
            }
            else
            {
                eka[luku].status = "lapsi";
                eka[luku].kelpoisuus = "hylatty";
            }*/
            luku++;
            for (int i = 0; i < luku; i++)
            {
                S2Vastaus.Text = S2Vastaus.Text + "Nimi: " + eka[i].nimi + "\nIkä: " + eka[i].ika +
                    "\n" + "Status: " + eka[i].status +
                    "\nKelpoisuus" + eka[i].kelpoisuus + "\n";
            }

        }
        class Ihminen
        {
            public string nimi;
            public string ika;
            public string status;
            public string kelpoisuus;
        }
    }
}
