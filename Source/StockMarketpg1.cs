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
            if (!int.TryParse(textBox_applied.Text, out i))
            {
               MessageBox.Show("No More Than 9 Digits and only Numbers, Or the Game Might Break!");
           }
           else
           {
                Globalv.stockamtbuy = textBox_applied.Text;
                Globalv.Stockbuyvar = long.Parse(Globalv.stockamtbuy); 
                Globalv.Stockbuyvarvar = Globalv.Stockbuyvar;
            }
        }
         
        private void StockMarketpg1_Load(object sender, EventArgs e)
        {
            if(Globalv.openhelp == 0)
            {
                Globalv.openhelp = 1;
                StockHelp F17 = new StockHelp();
                F17.Show();
            }

            textBox_applied.Text = Globalv.Stockbuyvarvar.ToString();

            if (Globalv.mcdsCurrentPrice > Globalv.mcdsLastPrice)
            {
                label_urMcdonalds.Text = ("1");
                pictureBox_Mcdonalds.Image = French_Fri_Clicker.Properties.Resources.StockMarketUp;
                pictureBox_Mcdonalds.Refresh();
                pictureBox_Mcdonalds.Visible = true;

            }
            else
            {
                label_urMcdonalds.Text = ("2");
                pictureBox_Mcdonalds.Image = French_Fri_Clicker.Properties.Resources.StockMarketDown;
                pictureBox_Mcdonalds.Refresh();
                pictureBox_Mcdonalds.Visible = true;
            }

            label_Mcdonaldsprice.Text = Globalv.mcdsCurrentPrice.ToString();
            label_urMcdonalds.Text = (Globalv.mcdsCurrentPrice * Globalv.Stockbuyvarvar).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            label_timmmer.Text = Globalv.timersecs.ToString();
            label_urMcdonalds.Text = (Globalv.mcdsCurrentPrice * Globalv.Stockbuyvarvar).ToString();
            label_amtfri.Text = Globalv.fri.ToString();

            if (Globalv.stockrefersh == 1)
            {

                //Mcdonalds Part

               if(Globalv.mcdsCurrentPrice > Globalv.mcdsLastPrice)
                {
                    label_urMcdonalds.Text = ("1");
                    pictureBox_Mcdonalds.Image = French_Fri_Clicker.Properties.Resources.StockMarketUp;
                    pictureBox_Mcdonalds.Refresh();
                    pictureBox_Mcdonalds.Visible = true;
                    
                }
                else
                {
                    label_urMcdonalds.Text = ("2");
                    pictureBox_Mcdonalds.Image = French_Fri_Clicker.Properties.Resources.StockMarketDown;
                    pictureBox_Mcdonalds.Refresh();
                    pictureBox_Mcdonalds.Visible = true;
                }

                label_Mcdonaldsprice.Text = Globalv.mcdsCurrentPrice.ToString();
                label_urMcdonalds.Text = (Globalv.mcdsCurrentPrice * Globalv.Stockbuyvarvar).ToString();
            }
        }

        private void button_mcdonsUpgrade_Click(object sender, EventArgs e)
        {
            if (Globalv.mcdsStockamt == 1)
            {

            }
            else
            {
                Globalv.mcdsStockamt = Globalv.mcdsStockamt / 2;
                Globalv.mcdsLowRanbdom = Globalv.mcdsLowRanbdom * 2;
                Globalv.mcdsHighRandom = Globalv.mcdsHighRandom * 3;
                Globalv.mcdsCurrentPrice = Globalv.mcdsCurrentPrice * 2;
            }

        }

        private void button_mcdonsBuy_Click(object sender, EventArgs e)
        {
            if(Globalv.fri >= (Globalv.mcdsCurrentPrice * Globalv.Stockbuyvarvar))
            {
                Globalv.mcdsStockamt += (1 * Globalv.Stockbuyvarvar);
                Globalv.fri -= (Globalv.mcdsCurrentPrice * Globalv.Stockbuyvarvar);
            }
            else
            {
                if (Globalv.notenoughcount == 0)
                {
                    Globalv.notenoughcount = 1;
                    NotEnoughFries F5 = new NotEnoughFries();
                    F5.Show();
                }
            }
        }

        private void button_mcdonsSell_Click(object sender, EventArgs e)
        {
            if (Globalv.mcdsStockamt >= Globalv.Stockbuyvarvar)
            {
                Globalv.fri += (Globalv.mcdsCurrentPrice * Globalv.Stockbuyvarvar);
                Globalv.mcdsStockamt = Globalv.mcdsStockamt - Globalv.Stockbuyvarvar;
            }
            else
            {
                MessageBox.Show("Not Enough Stock");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StockWallet F16 = new StockWallet();
            F16.Show();
        }

        private void button_openhelp_Click(object sender, EventArgs e)
        {
            StockHelp F17 = new StockHelp();
            F17.Show();
        }
    }
}
