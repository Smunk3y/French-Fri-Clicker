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
    public partial class xxCheatFPC : Form
    {
        public xxCheatFPC()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xxCheatFPC_Load(object sender, EventArgs e)
        {

        }

        private void button_fps10_Click(object sender, EventArgs e)
        {
            Globalv.FPC += 10;
        }

        private void button_fpc100_Click(object sender, EventArgs e)
        {
            Globalv.FPC += 100;
        }

        private void button_fpc1000_Click(object sender, EventArgs e)
        {
            Globalv.FPC += 1000;
        }

        private void button_fpc10k_Click(object sender, EventArgs e)
        {
            Globalv.FPC += 10000;
        }

        private void button_fpc100k_Click(object sender, EventArgs e)
        {
            Globalv.FPC += 100000;
        }

        private void button1_Click(object sender, EventArgs e) //this the 1m one
        {
            Globalv.FPC += 1000000;
        }

        private void button_fpc10m_Click(object sender, EventArgs e)
        {
            Globalv.FPC += 10000000;
        }

        private void button_fpc100m_Click(object sender, EventArgs e)
        {
            Globalv.FPC += 100000000;
        }

        private void button_fpc1b_Click(object sender, EventArgs e)
        {
            Globalv.FPC += 1000000000;
        }

        private void button_fpc_Click(object sender, EventArgs e)
        {
            Globalv.FPC += 10000000000;
        }

        private void button_fpc100b_Click(object sender, EventArgs e)
        {
            Globalv.FPC += 100000000000;
        }

        private void button_1t_Click(object sender, EventArgs e)
        {
            Globalv.FPC += 1000000000000;
        }

        private void button_fpcmax_Click(object sender, EventArgs e)
        {
            Globalv.FPC += 25000000000000;
        }

        private void button_fpc0_Click(object sender, EventArgs e)
        {
            Globalv.FPC = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_amtoffri.Text = Globalv.fri.ToString();
            label_numfpc.Text = Globalv.FPC.ToString();
        }
    }
}
