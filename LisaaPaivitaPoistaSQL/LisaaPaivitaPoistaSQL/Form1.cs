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

namespace LisaaPaivitaPoistaSQL
{
    
    public partial class Form1 : Form
    {
        MySqlConnectionStringBuilder yr = new MySqlConnectionStringBuilder();
        
        public Form1()
        {
            InitializeComponent();
            yr.Add("Database", "firma");
            yr.Add("DataSource", "localhost");
            yr.Add("User Id", "root");
            yr.Add("Password", "");

          
        }

        void PopulateDataGridView()
        {
            MySqlConnection yht = new MySqlConnection(yr.ConnectionString);
            {
                yht.Open();
                MySqlDataAdapter sqlDA = new MySqlDataAdapter("SELECT * FROM henkilo", yht);
                DataTable taulu = new DataTable();
                sqlDA.Fill(taulu);
                dgvEmployee.DataSource = taulu;


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateDataGridView(); 
        }

        private void dgvEmployee_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvEmployee.CurrentRow != null)
            {
                MySqlConnection yht = new MySqlConnection(yr.ConnectionString);
                {
                    yht.Open();
                    DataGridViewRow dvgRow = dgvEmployee.CurrentRow;
                    string komentojono;
                    if(txtHtun == null)
                    {
                        komentojono = "INSERT INTO henkilo VALUES (0, '" + txtEnimi + "','" +
                        txtSnimi + "','" + txtKunta + "','" + txtTutkinto + "','" +
                        txtPalkka + "','" + txtVeroprosentti + "','" + txtPvm + "','" +
                        txtOstunnus + "')";
                        
                    }
                    else
                    {
                        komentojono = "UPDATE henkilo SET htun = '" + txtHtun +
                        "', enimi = '" + txtEnimi + "', snimi = '" + txtSnimi +
                        "', kunta = '" + txtKunta + "', tutkinto = '" + txtTutkinto +
                        "', palkka = '" + txtPalkka + "', veroprosentti = '" + txtVeroprosentti +
                        "', pvm = '" + txtPvm + "', ostunnus = '" + txtOstunnus +
                        "WHERE htun = '"+ txtHtun + "')";
                     
                    }
                    MySqlCommand sqlKomento = new MySqlCommand(komentojono, yht);
                    try
                    {
                        sqlKomento.CommandType = CommandType.StoredProcedure;
                        sqlKomento.Parameters.AddWithValue("@htun", 0);
                        sqlKomento.Parameters.AddWithValue("@name", dvgRow.Cells["txtNimi"].Value == DBNull.Value ? "" : dvgRow.Cells["txtNimi"].Value.ToString);

                        MySqlDataReader lukija;
                        lukija = sqlKomento.ExecuteReader();
                        MessageBox.Show("Tiedot tallennettu");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
