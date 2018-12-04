using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySQL_testi
{
    public partial class HenkilostoPainikeS5 : Form
    {
        public HenkilostoPainikeS5()
        {
            InitializeComponent();
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void KyselyLaatikkoS2_Enter(object sender, EventArgs e) 
        {
            if (HenkilostoPainikeS3.Checked == true)
            {
                              
            }
            if (OsastoPainikeS3.Checked == true)
            {
               
            }
            if (ProjektiPainikeS3.Checked == true)
            {
                
            }
            if (AikatauluPainikeS3.Checked == true)
            {

            }

            

        }

        private void KyselyLaatikkoS1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KatseluNappi.Checked == true)
            {
                KatseluPaneeli1.Visible = true;
                AlkuPaneeli.Visible = false;
            }
            if (LisaysNappi.Checked == true)
            {
                LisaysPaneeli1.Visible = true;
                AlkuPaneeli.Visible = false;
            }
            if(MuuttoNappi.Checked == true)
            {
                MuutosPaneeli1.Visible = true;
                AlkuPaneeli.Visible = false;
            }
            if(PoistoNappi.Checked == true)
            {
                PoistoPaneeli1.Visible = true;
                AlkuPaneeli.Visible = false;
            }
        }

        private void ValintaPainikeS2_Click(object sender, EventArgs e)
        {
            string komentojono;
            if (HenkilostoPainike.Checked == true)
            {
                KatseluPaneeli1.Visible = false;
                NayttoPaneeli.Visible = true;
                komentojono = "SELECT * from henkilo";
                ajaKysely(komentojono);
            }
            if (OsastoPainike.Checked == true)
            {
                KatseluPaneeli1.Visible = false;
                NayttoPaneeli.Visible = true;
                komentojono = "SELECT * from osasto";
                ajaKysely(komentojono);
            }
            if (ProjektiPainike.Checked == true)
            {
                KatseluPaneeli1.Visible = false;
                NayttoPaneeli.Visible = true;
                komentojono = "SELECT * from projekti";
                ajaKysely(komentojono);
            }
            if (AikatauluPainike.Checked == true)
            {
                KatseluPaneeli1.Visible = false;
                NayttoPaneeli.Visible = true;
                komentojono = "SELECT projekti.pnimi, projekti.sijainti, projektihenkilo.tunnit, projektihenkilo.suun_tunnit, henkilo.enimi, henkilo.snimi, osasto.osnimi FROM projekti, projektihenkilo, henkilo, osasto WHERE projekti.ptun = projektihenkilo.ptun and projektihenkilo.htun = henkilo.htun and henkilo.ostunnus = osasto.ostun";
                ajaKysely(komentojono);
            }

        }
        private void ajaKysely(string jono)
        {
            MySqlConnectionStringBuilder yr = new MySqlConnectionStringBuilder();
            yr.Add("Database", "firma");
            yr.Add("DataSource", "localhost");
            yr.Add("User Id", "root");
            yr.Add("Password", "");

            MySqlConnection yht = new MySqlConnection(yr.ConnectionString);
            MySqlCommand kom = new MySqlCommand(jono, yht);

            try
            {
            yht.Open();
            MySqlDataAdapter DA = new MySqlDataAdapter();
            DA.SelectCommand = kom;
            DataTable taulu = new DataTable();
            DA.Fill(taulu);
            VastausTaulu.DataSource = taulu;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ValintaPainikeS3_Click(object sender, EventArgs e)
        {
            string komentojono;
            if (HenkilostoPainikeS3.Checked == true)
            {
                LisaysPaneeli1.Visible = false;
                HenkilostoLisays.Visible = true;
            
            }
            if (OsastoPainikeS3.Checked == true)
            {
                LisaysPaneeli1.Visible = false;
                OsastoLisaysPaneeli.Visible = true;
            }
            if (ProjektiPainikeS3.Checked == true)
            {
                LisaysPaneeli1.Visible = false;
                
            }
            if (AikatauluPainikeS3.Checked == true)
            {
                LisaysPaneeli1.Visible = false;
               
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string kysely;
            int tunnari = Convert.ToInt32(htunLisays.Text);
            string etunimi = enimiLisays.Text;
            string sukunimi = snimiLisays.Text;
            string paikka = KuntaLisays.Text;
            string koulutus = TutkintoLisays.Text;
            int liksa = Convert.ToInt32(PalkkaLisays.Text);
            double vero = Convert.ToDouble(VeroLisays.Text);
            string paiva = TulopaivaLisays.Text;
            int osasto = Convert.ToInt32(OsastoLisays.Text);
            kysely = "insert into henkilo values('" + tunnari + "','" + etunimi + "','" + sukunimi + "','"
                + paikka +"','"+ koulutus +"','" + liksa +"','" + vero + "','" + paiva +"','"+ osasto +"')";
            ajaLisays(kysely);

        }
        private void ajaLisays(string kysely)
        {
            MySqlConnectionStringBuilder yr = new MySqlConnectionStringBuilder();
            yr.Add("Database", "firma");
            yr.Add("DataSource", "localhost");
            yr.Add("User Id", "root");
            yr.Add("Password", "");

            MySqlConnection yht = new MySqlConnection(yr.ConnectionString);
            MySqlCommand kom = new MySqlCommand(kysely, yht);

            try
            {
                MySqlDataReader lukija;
                yht.Open();
                lukija = kom.ExecuteReader();
                MessageBox.Show("Tiedot tallennettu");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kysely;
            int tunnus = Convert.ToInt32(OstunnusLisays.Text);
            string nimi = OsNimiLisays.Text;
            string oskoodi = OsKoodiLisays.Text;
            kysely = "insert into firma.osasto values ('" + Convert.ToInt32(OstunnusLisays.Text)+"','" 
                + OsNimiLisays.Text+"','" + OsKoodiLisays.Text+"')";
            ajaLisays(kysely);
        }

        private void ValintaPainikeS4_Click(object sender, EventArgs e)
        {

        }

        private void PaluuPainike_Click(object sender, EventArgs e)
        {
            NayttoPaneeli.Visible = false;
            KatseluPaneeli1.Visible = true;
        }
    }
}
