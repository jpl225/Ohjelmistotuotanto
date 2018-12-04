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

namespace KyselySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SuoritaNappi_Click(object sender, EventArgs e)
        {
            ajaKysely();
        }

        private void ajaKysely()
        {
            string kysely = SQLKysely.Text;

            if(kysely =="")
            {
                MessageBox.Show("Ole hyvä ja lisää SQL-kysely");
                return;
            }

            MySqlConnectionStringBuilder yhteydenrakentaja = new MySqlConnectionStringBuilder();
            yhteydenrakentaja.Add("Database", "hr");
            yhteydenrakentaja.Add("DataSource", "localhost");
            yhteydenrakentaja.Add("User Id", "root");
            yhteydenrakentaja.Add("Password", "");

            MySqlConnection yhteys = new MySqlConnection(yhteydenrakentaja.ConnectionString);

            MySqlCommand komento = new MySqlCommand(kysely, yhteys);

            try
            {
                yhteys.Open();
                MySqlDataAdapter MinunSovitin = new MySqlDataAdapter();
                MinunSovitin.SelectCommand = komento;
                DataTable tietoTaulu = new DataTable();
                MinunSovitin.Fill(tietoTaulu);
                Vastaus.DataSource = tietoTaulu;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
