using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace French_Fri_Clicker
{
    public partial class AutoClicker : Form
    {
        public AutoClicker()
        {
            InitializeComponent();
        }

        private void button_toclose_Click(object sender, EventArgs e)
        {
            Globalv.autoclickeropens = 0;
            this.Close();
        }

        private void label_fpc_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
