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
    public partial class xxCheatFries : Form
    {
        public xxCheatFries()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add100_Click(object sender, EventArgs e)
        {
            Globalv.fri += 100;
        }

        private void button_add10k_Click(object sender, EventArgs e)
        {
            Globalv.fri += 10000;
        }

        private void button_add100k_Click(object sender, EventArgs e)
        {
            Globalv.fri += 100000;
        }

        private void button_add10m_Click(object sender, EventArgs e)
        {
            Globalv.fri += 10000000;
        }

        private void button_add100m_Click(object sender, EventArgs e)
        {
            Globalv.fri += 100000000;
        }

        private void button_add10b_Click(object sender, EventArgs e)
        {
            Globalv.fri += 10000000000;
        }

        private void button_add100b_Click(object sender, EventArgs e)
        {
            Globalv.fri += 100000000000;
        }

        private void button_add10t_Click(object sender, EventArgs e)
        {
            Globalv.fri += 10000000000000;
        }

        private void button_add100t_Click(object sender, EventArgs e)
        {
            Globalv.fri += 100000000000000;
        }

        private void button_add10q_Click(object sender, EventArgs e)
        {
            Globalv.fri += 10000000000000000;
        }

        private void button_max_Click(object sender, EventArgs e)
        {
            Globalv.fri = 9000000000000000000;
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            Globalv.fri = 0;
        }

        private void button_min_Click(object sender, EventArgs e)
        {
            Globalv.fri = -9000000000000000000;
        }

        private void button_add100Q_Click(object sender, EventArgs e)
        {
            Globalv.fri += 100000000000000000;
        }

        private void button_add10Qa_Click(object sender, EventArgs e)
        {
             Globalv.fri += 100000000000000000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_numfri.Text = Globalv.fri.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Globalv.fri = 0;
        }
    }
}
