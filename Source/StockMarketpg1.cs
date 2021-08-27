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
    public partial class StockMarketpg1 : Form
    {
        public StockMarketpg1()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int i;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out i))
            {
               MessageBox.Show("No More Than 9 Digits and only Numbers, Or the Game Might Break!");
           }
           else
           {
                Globalv.stockamtbuy = textBox1.Text;
                Globalv.Stockbuyvar = long.Parse(Globalv.stockamtbuy);
                Globalv.Stockbuyvarvar = Globalv.Stockbuyvar;
            }
        }
         
        private void StockMarketpg1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Globalv.Stockbuyvarvar.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            label_timmmer.Text = Globalv.timersecs.ToString();

        }
    }
}
