using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Data_Access_Demo
{
    class Automyynti
    {
        public int id { get; set; }
        public string rek_nro { get; set; }
        public string merkki { get; set; }
        public string malli { get; set; }
        public int vuosimalli { get; set; }
        public int ajokm { get; set; }
        public float hinta { get; set; }
        public string muuta { get; set; }
        
        public string omaisuus
        {
            get
            {
                return $"{rek_nro} {merkki} {malli} {vuosimalli} {ajokm} {hinta} {muuta}";
            }
            
        }
        
    }
}
