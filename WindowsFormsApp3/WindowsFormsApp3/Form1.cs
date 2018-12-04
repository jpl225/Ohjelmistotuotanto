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
        // Luodaan taulukko, johon tallennetaan tiedot
        DataTable taulukko = new DataTable("ihmiset");

        public Lomake()
        {
            InitializeComponent();
            //Lisätään taulukkoon sarakeotsikot
            taulukko.Columns.Add("Nimi");
            taulukko.Columns.Add("Ikä");
            taulukko.Columns.Add("Status");
            taulukko.Columns.Add("Kelpoisuus");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NaytaPainikeS1_Click(object sender, EventArgs e)
        {
            KyselyLomake.Visible = false;
            VastausLomake.Visible = true;
            // otetaan valitesti muuttuja käyttöön, jotta voidaan testata lukua
            int valitesti = Convert.ToInt32(IkaLaatikkoS1.Text);
            S2Vastaus.Text = "";
            if (valitesti > 65)
            {
                // Syötetään tiedot taulukkoon
                taulukko.Rows.Add(NimiLaatikkoS1.Text, IkaLaatikkoS1.Text, "eläkeläinen", "hyväksytty");
                // Tyhjennetään kentät edellisistä arvoista
                NimiLaatikkoS1.Clear();
                IkaLaatikkoS1.Clear();
            }
            else if (valitesti > 18)
            {
                // Syötetään tiedot taulukkoon
                taulukko.Rows.Add(NimiLaatikkoS1.Text, IkaLaatikkoS1.Text, "aikuinen", "hylätty");
                // Tyhjennetään kentät edellisistä arvoista
                NimiLaatikkoS1.Clear();
                IkaLaatikkoS1.Clear();
            }
            else if (valitesti != 0)
            {
                // Syötetään tiedot taulukkoon
                taulukko.Rows.Add(NimiLaatikkoS1.Text, IkaLaatikkoS1.Text, "lapsi", "hyväksytty");
                // Tyhjennetään kentät edellisistä arvoista
                NimiLaatikkoS1.Clear();
                IkaLaatikkoS1.Clear();
            }
            else
            {
                // Tyhjennetään kentät edellisistä arvoista
                NimiLaatikkoS1.Clear();
                IkaLaatikkoS1.Clear();
            }
            // Käydään läpi rivit
            for (int i = 0; i < taulukko.Rows.Count; i++)
            {
                // Käydään läpi sarakkeet
                for (int j = 0; j < taulukko.Columns.Count; j++)
                {
                    // Tulostetaan S2Vastaukseen taulukon sisältö
                    S2Vastaus.Text += taulukko.Rows[i][j].ToString() + "\n";
                }
                // Laitetaan jokaisen tietueen jälkeen rivinvaihto
                S2Vastaus.Text += "\n";
            }

        }

        private void TakaisinPainike_Click(object sender, EventArgs e)
        {
            KyselyLomake.Visible = true;
            VastausLomake.Visible = false;
            NimiLaatikkoS1.Clear();
            IkaLaatikkoS1.Clear();
        }
    }
}
