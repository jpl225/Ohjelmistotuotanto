
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.Odbc;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sample
{
    public partial class Default : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            try
            {
                string myConnectionString = "Driver={MySQL ODBC 5.1 Driver};Server=localhost;Database=automyynti; User=root;Password=testisalis;";
                OdbcConnection myConnection = new OdbcConnection();

                myConnection.ConnectionString = myConnectionString;
                myConnection.Open();

                string mySqlCommand = textBox1.Text;

                OdbcCommand comm = new OdbcCommand(mySqlCommand, myConnection);
                OdbcDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    int i = 0;
                    string row = "";

                    while (i < dr.FieldCount)
                    {
                        row = row + dr.GetValue(i).ToString();
                        i++;
                    }

                    listBox1.Items.Add(row);
                }

                myConnection.Close();
            }
            catch (Exception ex)
            {
                textBox2.Text = ex.Message.ToString();
            }
        }
    }
}