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
    public partial class xCheatmenu : Form
    {
        public xCheatmenu()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_openfries_Click(object sender, EventArgs e)
        {
            xxCheatFries F10 = new xxCheatFries();
            F10.Show();
        }

        private void button_FPS_Click(object sender, EventArgs e)
        {
            Globalv.cheatfpson = 1;
            xxCheatFPS F11 = new xxCheatFPS();
            F11.Show();
        }

        private void button_openfpc_Click(object sender, EventArgs e)
        {
            xxCheatFPC F12 = new xxCheatFPC();
            F12.Show();
        }
    }
}
