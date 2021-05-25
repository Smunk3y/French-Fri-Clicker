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
    public partial class NotEnoughFries : Form
    {
        public NotEnoughFries()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Globalv.notenoughcount = 0;
            this.Close();
        }

        private void label_amtofsmallfarm_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            label_amtofFries.Text = Globalv.fri.ToString();
        }
    }
}
