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
    public partial class FriesperClick : Form
    {
        public FriesperClick()
        {
            InitializeComponent();
        }


       

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label_FPC_Click(object sender, EventArgs e)
        {

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label_FPC.Text = Globalv.FPC.ToString();
            label_Fries.Text = Globalv.fri.ToString();

            label_priceBasicClick.Text = Globalv.priceofBasicclicker.ToString();
            label_amtofBasicClick.Text = Globalv.amtBasicclicker.ToString();

            label_priceofPotatoclick.Text = Globalv.priceofPotatoclciker.ToString();
            label_amtofPotatoclick.Text = Globalv.amtPotatoclicker.ToString();

            label_priceofDellmouse.Text = Globalv.priceofDellmouse.ToString();
            label_amtofDellmouse.Text = Globalv.amtDellmouse.ToString();

            label_amtofPotatohelp.Text = Globalv.amtPotatohelper.ToString();
            label_priceofPotatoHelper.Text = Globalv.priceofPotatohelper.ToString();

            label_amtRazermouse.Text = Globalv.amtRazermouse.ToString();
            label_priceRazermouse.Text = Globalv.priceofRazermouse.ToString();

            label_amt15Dollargamingmouse.Text = Globalv.amt15Dollarmouse.ToString();
            label_price15dollargamingmouse.Text = Globalv.priceof15Dollarmouse.ToString();

            label_amtPotatomouse.Text = Globalv.amtPotatoMouse.ToString();
            label_pricePoatomouse.Text = Globalv.priceofPotatoMouse.ToString();

            label_amtSparehand.Text = Globalv.amtSparehand.ToString();
            label_priceSparehand.Text = Globalv.priceofSparehand.ToString();

            label_amtBronzehand.Text = Globalv.amtBronzehand.ToString();
            label_bronzehand.Text = Globalv.priceofBronzehand.ToString();

            label_amtSilverhand.Text = Globalv.amtSilverhand.ToString();
            label_priceSilverhand.Text = Globalv.priceofSilverhand.ToString();

            label_amtGoldhand.Text = Globalv.amtGoldhand.ToString();
            label_priceGoldhand.Text = Globalv.priceofGoldhand.ToString();

            label_amtPlatinumhand.Text = Globalv.amtPlatinumhand.ToString();
            label_pricePlatinumhand.Text = Globalv.priceofPlatinumhand.ToString();

            label_amtAmethysthand.Text = Globalv.amtAmythysthand.ToString();
            label_Amethysthand.Text = Globalv.priceofAmythysthand.ToString();

            label_amtTopazhand.Text = Globalv.amtTopazhand.ToString();
            label_Topazhand.Text = Globalv.priceofTopazhand.ToString();

            label_amtRubyhand.Text = Globalv.amtRubyhand.ToString();
            label_Rubyhand.Text = Globalv.priceofRubyhand.ToString();

            label_amtSapphirehand.Text = Globalv.amtSapphirehand.ToString();
            label_priceSapphirehand.Text = Globalv.priceofSapphirehand.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(Globalv.fri >= Globalv.priceofBasicclicker)
            {
                Globalv.fri -= Globalv.priceofBasicclicker;
                Globalv.FPC += 1;
                Globalv.amtBasicclicker += 1;
                Globalv.priceofBasicclicker += Globalv.incBasicclicker;
                label_priceBasicClick.Text = Globalv.priceofBasicclicker.ToString();
                label_amtofBasicClick.Text = Globalv.amtBasicclicker.ToString();
                Globalv.incBasicclicker += 25;
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

        private void button_PotatoClick_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.priceofPotatoclciker)
            {
                Globalv.fri -= Globalv.priceofPotatoclciker;
                Globalv.FPC += 5;
                Globalv.amtPotatoclicker += 1;
                Globalv.priceofPotatoclciker += Globalv.incPotatoclicker;
                label_priceofPotatoclick.Text = Globalv.priceofPotatoclciker.ToString();
                label_amtofPotatoclick.Text = Globalv.amtPotatoclicker.ToString();
                Globalv.incPotatoclicker += 240;
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.priceofDellmouse)
            {
                Globalv.fri -= Globalv.priceofDellmouse;
                Globalv.FPC += 50;
                Globalv.amtDellmouse += 1;
                Globalv.priceofDellmouse += Globalv.incDellmouse;
                label_priceofDellmouse.Text = Globalv.priceofDellmouse.ToString();
                label_amtofDellmouse.Text = Globalv.amtDellmouse.ToString();
                Globalv.incDellmouse += 3000;
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

        private void button_Potatohelper_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.priceofPotatohelper)
            {
                Globalv.fri -= Globalv.priceofPotatohelper;
                Globalv.FPC += 20;
                Globalv.amtPotatohelper += 1;
                Globalv.priceofPotatohelper += Globalv.incPotatohelper;
                label_amtofPotatohelp.Text = Globalv.amtPotatohelper.ToString();
                label_priceofPotatoHelper.Text = Globalv.priceofPotatohelper.ToString();
                Globalv.incPotatohelper += 1200;
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

        private void button_opemcps_Click(object sender, EventArgs e)
        {
            ClickperSecond F6 = new ClickperSecond();
            F6.Show();
        }

        private void button_RazerMouse_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.priceofRazermouse)
            {
                Globalv.fri -= Globalv.priceofRazermouse;
                Globalv.FPC += 250;
                Globalv.amtRazermouse += 1;
                Globalv.priceofRazermouse += Globalv.incRazermouse;
                label_amtRazermouse.Text = Globalv.amtRazermouse.ToString();
                label_priceRazermouse.Text = Globalv.priceofRazermouse.ToString();
                Globalv.incRazermouse += 9000;
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

        private void button_15Dollargamingmouse_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.priceof15Dollarmouse)
            {
                Globalv.fri -= Globalv.priceof15Dollarmouse;
                Globalv.FPC += 1500;
                Globalv.amt15Dollarmouse += 1;
                Globalv.priceof15Dollarmouse += Globalv.inc15Dollarmouse;
                label_amt15Dollargamingmouse.Text = Globalv.amt15Dollarmouse.ToString();
                label_price15dollargamingmouse.Text = Globalv.priceof15Dollarmouse.ToString();
                Globalv.inc15Dollarmouse += 36000;
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

        private void button_Poatomouse_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.priceofPotatoMouse)
            {
                Globalv.fri -= Globalv.priceofPotatoMouse;
                Globalv.FPC += 5000;
                Globalv.amtPotatoMouse += 1;
                Globalv.priceofPotatoMouse += Globalv.incPotatoMouse;
                label_amtPotatomouse.Text = Globalv.amtPotatoMouse.ToString();
                label_pricePoatomouse.Text = Globalv.priceofPotatoMouse.ToString();
                Globalv.incPotatoMouse += 120000;
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

        private void button_SpareHand_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.priceofSparehand)
            {
                Globalv.fri -= Globalv.priceofSparehand;
                Globalv.FPC += 20000;
                Globalv.amtSparehand += 1;
                Globalv.priceofSparehand += Globalv.incSparehand;
                label_amtSparehand.Text = Globalv.amtSparehand.ToString();
                label_priceSparehand.Text = Globalv.priceofSparehand.ToString();
                Globalv.incSparehand += 540000;
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

        private void button_Bronzehand_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.priceofBronzehand)
            {
                Globalv.fri -= Globalv.priceofBronzehand;
                Globalv.FPC += 75000;
                Globalv.amtBronzehand += 1;
                Globalv.priceofBronzehand += Globalv.incBronzehand;
                label_amtBronzehand.Text = Globalv.amtBronzehand.ToString();
                label_bronzehand.Text = Globalv.priceofBronzehand.ToString();
                Globalv.incBronzehand += 3600000;
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

        private void button_Silverhand_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.priceofSilverhand)
            {
                Globalv.fri -= Globalv.priceofSilverhand;
                Globalv.FPC += 200000;
                Globalv.amtSilverhand += 1;
                Globalv.priceofSilverhand += Globalv.incSilverhand;
                label_amtSilverhand.Text = Globalv.amtSilverhand.ToString();
                label_priceSilverhand.Text = Globalv.priceofSilverhand.ToString();
                Globalv.incSilverhand += 8250000;
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

        private void button_Goldhand_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.priceofGoldhand)
            {
                Globalv.fri -= Globalv.priceofGoldhand;
                Globalv.FPC += 500000;
                Globalv.amtGoldhand += 1;
                Globalv.priceofGoldhand += Globalv.incGoldhand;
                label_amtGoldhand.Text = Globalv.amtGoldhand.ToString();
                label_priceGoldhand.Text = Globalv.priceofGoldhand.ToString();
                Globalv.incGoldhand += 21000000;
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

        private void button_PlatinumHand_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.priceofPlatinumhand)
            {
                Globalv.fri -= Globalv.priceofPlatinumhand;
                Globalv.FPC += 800000;
                Globalv.amtPlatinumhand += 1;
                Globalv.priceofPlatinumhand += Globalv.incPlatinumhand;
                label_amtPlatinumhand.Text = Globalv.amtPlatinumhand.ToString();
                label_pricePlatinumhand.Text = Globalv.priceofPlatinumhand.ToString();
                Globalv.incPlatinumhand += 37500000;
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

        private void button_Amethysthand_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.priceofAmythysthand)
            {
                Globalv.fri -= Globalv.priceofAmythysthand;
                Globalv.FPC += 1250000;
                Globalv.amtAmythysthand += 1;
                Globalv.priceofAmythysthand += Globalv.incAmythysthand;
                label_amtAmethysthand.Text = Globalv.amtAmythysthand.ToString();
                label_Amethysthand.Text = Globalv.priceofAmythysthand.ToString();
                Globalv.incAmythysthand += 60000000;
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

        private void button_Topazhand_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.priceofTopazhand)
            {
                Globalv.fri -= Globalv.priceofTopazhand;
                Globalv.FPC += 2000000;
                Globalv.amtTopazhand += 1;
                Globalv.priceofTopazhand += Globalv.incTopazhand;
                label_amtTopazhand.Text = Globalv.amtTopazhand.ToString();
                label_Topazhand.Text = Globalv.priceofTopazhand.ToString();
                Globalv.incTopazhand += 90000000;
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

        private void button_Rubyhand_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.priceofRubyhand)
            {
                Globalv.fri -= Globalv.priceofRubyhand;
                Globalv.FPC += 5000000;
                Globalv.amtRubyhand += 1;
                Globalv.priceofRubyhand += Globalv.incRubyhand;
                label_amtRubyhand.Text = Globalv.amtRubyhand.ToString();
                label_Rubyhand.Text = Globalv.priceofRubyhand.ToString();
                Globalv.incRubyhand += 210000000;
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

        private void button_Sapphirehand_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.priceofSapphirehand)
            {
                Globalv.fri -= Globalv.priceofSapphirehand;
                Globalv.FPC += 12000000;
                Globalv.amtSapphirehand += 1;
                Globalv.priceofSapphirehand += Globalv.incSapphirehand;
                label_amtSapphirehand.Text = Globalv.amtSapphirehand.ToString();
                label_priceSapphirehand.Text = Globalv.priceofSapphirehand.ToString();
                Globalv.incSapphirehand += 420000000;
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_Rightarrow_Click(object sender, EventArgs e)
        {
            
        }

        private void FriesperClick_Load(object sender, EventArgs e)
        {

        }
    }
}
    