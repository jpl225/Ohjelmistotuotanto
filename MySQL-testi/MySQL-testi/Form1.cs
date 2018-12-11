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
        // toinen tapa tehdä yhteys
        MySqlConnection connection = new MySqlConnection("database=firma;datasource = localhost;user=root;password=");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table = new DataTable();
        BindingManagerBase managerBase;
        MySqlCommandBuilder builder;

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
            //string komentojono;
            if (HenkilostoPainikeS3.Checked == true)
            {
                LisaysPaneeli1.Visible = false;
                HenkilostoLisaysPaneeli.Visible = true;
            
            }
            if (OsastoPainikeS3.Checked == true)
            {
                LisaysPaneeli1.Visible = false;
                OsastoLisaysPaneeli.Visible = true;
            }
            if (ProjektiPainikeS3.Checked == true)
            {
                LisaysPaneeli1.Visible = false;
                ProjektinLisaysPaneeli.Visible = true;
                
            }
            if (AikatauluPainikeS3.Checked == true)
            {
                LisaysPaneeli1.Visible = false;
                ProjektiHenkiloPaneeli.Visible = true;
                ajaComboKysely();
               
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

        private void KatseluPaneeli1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            KatseluPaneeli1.Visible = false;
            AlkuPaneeli.Visible = true;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            HenkilostoLisaysPaneeli.Visible = false;
            LisaysPaneeli1.Visible = true;
        }

        private void s_Click(object sender, EventArgs e)
        {
            OsastoLisaysPaneeli.Visible = false;
            LisaysPaneeli1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProjektinLisaysPaneeli.Visible = false;
            LisaysPaneeli1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LisaysPaneeli1.Visible = false;
            AlkuPaneeli.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MuutosPaneeli1.Visible = false;
            AlkuPaneeli.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PoistoPaneeli1.Visible = false;
            AlkuPaneeli.Visible = true;
        }

        private void OsastoPainikeS3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ajaComboKysely()
        {
            //string kysely;
            string kysely = "SELECT * FROM projekti";
            string kysely2 = "SELECT * FROM henkilo";
            MySqlConnectionStringBuilder yr = new MySqlConnectionStringBuilder();
            yr.Add("Database", "firma");
            yr.Add("DataSource", "localhost");
            yr.Add("User Id", "root");
            yr.Add("Password", "");

            MySqlConnection yht = new MySqlConnection(yr.ConnectionString);
            MySqlCommand kom = new MySqlCommand(kysely, yht);
            MySqlCommand kom2 = new MySqlCommand(kysely2, yht);
            MySqlDataReader lukija;
            MySqlDataReader lukija2;
            try
            {
                yht.Open();
                lukija = kom.ExecuteReader();
                while (lukija.Read())
                {
                    string pnro = lukija.GetString("ptun");
                    string pnimi = lukija.GetString("pnimi");
                    string jono = pnro + " " + pnimi;
                    ProjektiPudotusVastaus.Items.Add(jono);
                }
                yht.Close();
                yht.Open();
                lukija2 = kom2.ExecuteReader();
                while(lukija2.Read())
                {
                    string htun = lukija2.GetString("htun");
                    string enimi = lukija2.GetString("enimi");
                    string snimi = lukija2.GetString("snimi");
                    string nimi = htun + " " + enimi + " " + snimi;
                    HenkiloPudotusValikko.Items.Add(nimi);
                }
                yht.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void HenkilostoPainikeS5_Load(object sender, EventArgs e)
        {
            
        }

        private void ProjektiHenkiloPaneeli_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            ProjektiHenkiloPaneeli.Visible = false;
            LisaysPaneeli1.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string kysely;
            string projekti = ProjektiPudotusVastaus.Text;
            string henkilo = HenkiloPudotusValikko.Text;
            int vali = henkilo.IndexOf(' ');
            string htunText = henkilo.Substring(0, vali);
            int htun = Convert.ToInt32(htunText);
            int vali2 = projekti.IndexOf(' ');
            string projText = projekti.Substring(0, vali2);
            int ptun = Convert.ToInt32(projText);
            int ttunnit = Convert.ToInt32(TehdytTunnitVastaus.Text);
            int stunnit = Convert.ToInt32(SuunnitellutTunnitVastaus.Text);
            kysely = "INSERT INTO projektihenkilo (ptun, htun, tunnit, suun_tunnit) VALUES ("
                + ptun + ", " + htun + ", " + ttunnit + ", " + stunnit + ");"; 
            ajaLisays(kysely);
        }

        private void LisaaProjektiPainike_Click(object sender, EventArgs e)
        {
            string kysely;
            int protun = Convert.ToInt32(ProjektitunTeksti.Text);
            string pronimi = ProjektiNimiTeksti.Text;
            int proprio = Convert.ToInt32(ProjektiPrioTeksti.Text);
            string prosij = ProjektiSijaintiTeksti.Text;
            kysely = "INSERT INTO projekti (ptun, pnimi, prioriteetti, sijainti) VALUES ('" +
                protun + "', '" + pronimi + "', '" + proprio + "', '" + prosij + "');";
            MessageBox.Show(kysely);
            ajaLisays(kysely);
        }

        private void KaikkiPaneeli_Paint(object sender, PaintEventArgs e)
        {
            string query = "SELECT * FROM henkilo";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            KaikkiYleisNakyma.DataSource = table;
            KaikkiHloText.DataBindings.Add("text", table, "htun");
            KaikkiEtunimiText.DataBindings.Add("text", table, "enimi");
            KaikkiSukunimiText.DataBindings.Add("text", table, "snimi");
            KaikkiKuntaText.DataBindings.Add("text", table, "kunta");
            KaikkiTutkintoText.DataBindings.Add("text", table, "tutkinto");
            KaikkiPalkkaText.DataBindings.Add("text", table, "palkka");
            KaikkiVeroText.DataBindings.Add("text", table, "veroprosentti");
            KaikkiPvmText.DataBindings.Add("text", table, "pvm");

   
        }
    }
}
