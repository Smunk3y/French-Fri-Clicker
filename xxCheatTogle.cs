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
    public partial class xxCheatTogle : Form
    {
        public xxCheatTogle()
        {
            InitializeComponent();
        }

        private void button_opencheatmeny_Click(object sender, EventArgs e)
        {
            Globalv.cheatsonoroff = 1;
            this.Close();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Globalv.cheattoggleopen = 0;
            this.Close();
        }
    }
}
