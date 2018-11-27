using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eka
{
    public partial class EkaLomake : Form
    {
        public EkaLomake()
        {
            InitializeComponent();
        }

        private void PainoNappi_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 10000; i++) { 
            ReagointiLippunen.Text = Convert.ToString(i);
                ReagointiLippunen.Update();
            }
        }
    }
}
