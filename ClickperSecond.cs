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
    public partial class ClickperSecond : Form
    {
        public ClickperSecond()
        {
            InitializeComponent();
        }

        //ints

        int CPS = 0;
        int Clicks = 0;
        int seconds = 0;
        private void button_clickme_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            Clicks += 1;
            label_inprogress.Text = ("In Progress");
            label_clicks.Text = Clicks.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            seconds += 1;

            if (seconds == 10)
            {
                button_clickme.Enabled = false;
                CPS = (Clicks / seconds);
                label_amtofPotatoclick.Text = CPS.ToString();
                label_secondsleft.Text = ("0");
                label_inprogress.Text = ("Over");
            }
            if (seconds == 9)
            {
                label_secondsleft.Text = ("1");
            }

            if (seconds == 8)
            {
                label_secondsleft.Text = ("2");
            }

            if (seconds == 7)
            {
                label_secondsleft.Text = ("3");
            }

            if (seconds == 6)
            {
                label_secondsleft.Text = ("4");
            }

            if (seconds == 5)
            {
                label_secondsleft.Text = ("5");
            }

            if (seconds == 4)
            {
                label_secondsleft.Text = ("6");
            }

            if (seconds == 3)
            {
                label_secondsleft.Text = ("7");
            }

            if (seconds == 2)
            {
                label_secondsleft.Text = ("8");
            }

            if (seconds == 1)
            {
                label_secondsleft.Text = ("9");
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clicks = 0;
            CPS = 0;
            seconds = 0;
            label_inprogress.Text = ("Ready To Go");
            label_secondsleft.Text = ("10");
            label_amtofPotatoclick.Text = CPS.ToString();
            timer.Enabled = false;
            button_clickme.Enabled = true;
        }

        private void label_clicks_Click(object sender, EventArgs e)
        {
           
        }

        private void label_inprogress_Click(object sender, EventArgs e)
        {
            
        }
    }
}
