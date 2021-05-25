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
    public partial class Settingsmenu : Form
    {
        public Settingsmenu()
        {
            InitializeComponent();
        }

        int timecnt2 = 0;

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_opencheatmeny_Click(object sender, EventArgs e)
        {
            if (Globalv.cheatsonoroff == 1)
            {
                xCheatmenu F8 = new xCheatmenu();
                F8.Show();
            }
            else
            {
                //make it show activate cheats then close after .8 seconds
            }
        }

        private void button_cheattoggle_Click(object sender, EventArgs e)
        {
            if (Globalv.cheattoggleopen == 0)
            {
                xxCheatTogle F9 = new xxCheatTogle();
                F9.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timecnt2 += 1;

            if (Globalv.cheatsonoroff == 1)
            {
                label_cheatsident.Text = "Yes";
            }
        }

        private void label_fris_Click(object sender, EventArgs e)
        {

        }
    }
}
