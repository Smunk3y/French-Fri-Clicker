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
    public partial class StockWallet : Form
    {
        public StockWallet()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_McdonsAmt.Text = Globalv.mcdsStockamt.ToString();
            label_McdonsPrice.Text = (Globalv.mcdsStockamt * Globalv.mcdsCurrentPrice).ToString();


        }
    }
}
