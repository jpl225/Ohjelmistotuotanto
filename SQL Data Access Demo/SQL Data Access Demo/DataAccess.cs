using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SQL_Data_Access_Demo
{
    class DataAccess
    {
        public List<Automyynti> GetAutomyynti(string merkki)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Avustaja.CnnVal("Automyynti")))
            {
                var output = connection.Query<Automyynti>($"select * from auto where merkki = '{ merkki }'").ToList();
                return output;
            }
        }
    }
}
