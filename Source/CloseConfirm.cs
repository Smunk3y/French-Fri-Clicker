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
    public partial class Quitform : Form
    {

        public Quitform()
        {
            InitializeComponent();
        }



        public static class Globalvars
        {
            public const int fris = 0;
            public static int friis = 0;
        }



        private void button1_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();
            Environment.Exit(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button_update_Click(object sender, EventArgs e)
        {   
        }
    }
}
