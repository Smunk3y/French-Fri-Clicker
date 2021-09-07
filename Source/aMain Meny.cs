using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace French_Fri_Clicker
{
    public partial class Form1 : Form
    {
        //amount of fries
        //int frilocal = 0;

        //amount of FPS
        //int FPSloacl = 0;



        //int for auto clicker
        long clicksonfries = 0;

   


        //timer count
        long timecnt = 0;

        //auto clciker anti cheat
        //works by checking for common auto clicker prosecces names every 5 seconds yea
        //this is dont to prevent lag and overuse of a anti cheat that may not even be needed if playing as a legit player
        //int autoclickerwarningcounter = 0;
        public Form1()
        {
            InitializeComponent();
        }





        private void button1_Click(object sender, EventArgs e)
        {
            Quitform F2 = new Quitform();
            F2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void amt_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_start_Click(object sender, EventArgs e)
        {
            button_click.Enabled = true;
        }

        private void button_click1_Click(object sender, EventArgs e)
        {
            Globalv.fri += Globalv.FPC;
            clicksonfries += 1;
            label_numfri.Text = Globalv.fri.ToString();
        }


        private void label_numfri_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void button_opensettings_Click(object sender, EventArgs e)
        {
           //MessageBox.Show("Next Update");
           Settingsmenu F7 = new Settingsmenu();
           F7.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FriesperClick F3 = new FriesperClick();
            F3.Show();
        }

        //timer code




        private void timer1_Tick(object sender, EventArgs e)
        {
            timecnt += 1;
            label_numfri.Text = Globalv.fri.ToString();
            
            if (timecnt % 40 == 0)
            {
                label_fpc.Text = Globalv.FPC.ToString();
            }
            
            if(timecnt % 40 == 0)
            {

                Random rd = new Random();
             
                Globalv.timersecs = Globalv.timersecs - 1;

                if (Globalv.timersecs == 0)
                {
                    Globalv.stockrefersh = 1;
                    Globalv.timersecs = 120;
                }

                //mcdonds part
                if(Globalv.stockrefersh == 1)
                {
                    Globalv.mcdsLastPrice = Globalv.mcdsCurrentPrice;
                    Globalv.mcdsCurrentPrice = rd.Next(Globalv.mcdsLowRanbdom, Globalv.mcdsHighRandom);
                }
            }

            if (timecnt % 20 == 0)
            {
                Globalv.fri += Globalv.friBoxopotato;
            }

            if(timecnt % 80 == 0)
            {
                if(Globalv.justloadsave == 1)
                {
                    label_amtofPp.Text = Globalv.amtPotatopot.ToString();
                    label_pricePotatopot.Text = Globalv.pricePotatopot.ToString();
                    label_priceofSmall.Text = Globalv.priceSmallfarm.ToString();
                    label_amtofsmallfarm.Text = Globalv.amtSmallfarm.ToString();
                    label_priceofFarm.Text = Globalv.priceFarm.ToString();
                    label_amtoffarm.Text = Globalv.amtFarm.ToString();
                    label_priceofboxo.Text = Globalv.priceBoxopotato.ToString();
                    label_amtofbox.Text = Globalv.amtBoxpotato.ToString();
                    label_priceofGreen.Text = Globalv.priceGreenhouse.ToString();
                    label_amtofgreenhuse.Text = Globalv.amtGreenhouse.ToString();
                    label_priceofsacko.Text = Globalv.priceSackopotato.ToString();
                    label_amtSacko.Text = Globalv.amtSackopotato.ToString();
                    label_pricePotatocrate.Text = Globalv.pricePotatocrate.ToString();
                    label_amtofPotatocrate.Text = Globalv.amtPotatocrate.ToString();
                    label_pricePotatoshippingboat.Text = Globalv.pricePotatoshippingboat.ToString();
                    label_amtofPotatoshippingboat.Text = Globalv.amtPotatoshippingcrate.ToString();
                    label_priceofHandpotatocutter.Text = Globalv.pricehandpotatocutter.ToString();
                    label_amtofHandpotatocutter.Text = Globalv.amtHandPotatocutter.ToString();
                    label_priceofDeepfryer.Text = Globalv.pricedeepfryer.ToString();
                    label_amtofDeepfryer.Text = Globalv.amtDeepfryer.ToString();
                    label_priceofOvenfries.Text = Globalv.priceovenfries.ToString();
                    label_amtofOvenFries.Text = Globalv.amtOvenfries.ToString();
                    label_priceofSmallfries.Text = Globalv.pricesmallfries.ToString();
                    label_amtofSmallFries.Text = Globalv.amtSmallfries.ToString();
                    label_priceFries.Text = Globalv.priceFrenchfries.ToString();
                    label_amtofFries.Text = Globalv.amtFrenchFri.ToString();
                    label_priceBagOFries.Text = Globalv.priceBagofries.ToString();
                    label_amtofBagOFries.Text = Globalv.amtbagofries.ToString();
                    label_priceLargedeepFryer.Text = Globalv.priceLargedeepfryer.ToString();
                    label_amtofLargeDeepFryer.Text = Globalv.amtlargedeepfryer.ToString();
                    label_priceBarrelOfries.Text = Globalv.priceBarrelofries.ToString();
                    label_amtofBarrelOFries.Text = Globalv.amtbarrelofries.ToString();
                    label_priceThefriTruck.Text = Globalv.priceThefritruck.ToString();
                    label_amtofTheFriTruck.Text = Globalv.amtThefritruck.ToString();
                    label_priceFrenchfriPlane.Text = Globalv.priceFrenchfriplane.ToString();
                    label_amtofFrenchFriPlane.Text = Globalv.amtfrenchfriplane.ToString();
                    label_priceGiantPotoatSilo.Text = Globalv.priceGiantpotatosilo.ToString();
                    label_amtofGaintpotatosilo.Text = Globalv.amtGiantpotatosilo.ToString();
                    label_pricePotatoBlimp.Text = Globalv.pricePotatoblimp.ToString();
                    label_amtofPotatoblimp.Text = Globalv.amtPotatoblimp.ToString();
                    label_pricePotatoFactory.Text = Globalv.pricePotatofactory.ToString();
                    label_amtofPotatoFactory.Text = Globalv.amtPotatofactory.ToString();
                    label_priceFrenchFriStand.Text = Globalv.priceFrenchfriStand.ToString();
                    label_amtofFrenchFriStand.Text = Globalv.amtFrenchfriStand.ToString();
                    label_priceFrenchFriTrain.Text = Globalv.priceFrenchfritrain.ToString();
                    label_amtofFrenchFriTrain.Text = Globalv.amtFrenchfritrain.ToString();
                    label_priceFrenchFriKnife.Text = Globalv.priceFrenchfriknife.ToString();
                    label_amtofFrenchFriKnife.Text = Globalv.amtFrenchfriknife.ToString();
                    label_fpc.Text = Globalv.FPC.ToString();
                    label_FPS.Text = Globalv.FPS.ToString();
                    Globalv.justloadsave = 0;
                }
            }

            if (timecnt % 4 == 0)
            {
                Globalv.fri += Globalv.friSackopotato;
            }

            if (timecnt % 20 == 0)
            {
                label_FPS.Text = Globalv.FPS.ToString();
                Globalv.fri += Globalv.friFarm;
            }

            if (timecnt % Globalv.timersmalllfarm == 0)
            {
                Globalv.fri += Globalv.friSmallfarm;
            }

            if (timecnt % 20 == 0)
            {
                Globalv.fri += Globalv.friDeepfryer;
            }

            if (timecnt % Globalv.timerpotatopotfps == 0)
            {
                Globalv.fri += Globalv.amtPotatopot;
            }

            if (timecnt % 1 == 0)
            {
                Globalv.fri += Globalv.friFrenchFri;
            }

            if (timecnt % 1 == 0)
            {
                Globalv.fri += Globalv.friPotatoblimp;
            }

            if (timecnt % 1 == 0)
            {
                Globalv.fri += Globalv.friFrenchfritrain;
            }

            if (timecnt % 1 == 0)
            {
                Globalv.fri += Globalv.fribarrelofries;
            }

            if (timecnt % 1 == 0)
            {
                Globalv.fri += Globalv.frifrenchfriplane;
            }

            if (timecnt % 1 == 0)
            {
                Globalv.fri += Globalv.friThefritruck;
            }

            if (timecnt % 1 == 0)
            {
                Globalv.fri += Globalv.friGiantpotatosilo;
            }

            if (timecnt % 1 == 0)
            {
                Globalv.fri += Globalv.frilargedeepfryer;
            }

            if (timecnt % 1 == 0)
            {
                Globalv.fri += Globalv.friFrenchfriStand;
            }

            if (timecnt % 1 == 0)
            {
                Globalv.fri += Globalv.fribagofries;
            }

            if (timecnt % 8 == 0)
            {
                Globalv.fri += Globalv.frigreenhouse;
            }

            if (timecnt % 1 == 0)
            {
                Globalv.fri += Globalv.friPotatocrate;
            }

            if (timecnt % 1 == 0)
            {
                Globalv.fri += Globalv.friPotatofactory;
            }

            if (timecnt % 4 == 0)
            {
                label_fpsPotatopot.Text = Globalv.fpsPotatopot.ToString();
                label_fpsSmallFarm.Text = Globalv.fpssmallfarm.ToString();
                label_fpsGreenhouse.Text = Globalv.fpsgreenhouse.ToString();
                label_fpsBoxoPotatos.Text = (Globalv.fpsBoxOPotatos * 2 ).ToString();
                label_fpsSackopotatos.Text = (Globalv.fpsSackOPotatos * 4).ToString();
                label_fpsFarm.Text = (Globalv.fpsfarm * 2).ToString();
                label_fpsPotatocrate.Text = (Globalv.fpsPotatoCrate * 40).ToString();
                label_fpsPotatoShipingboat.Text = (Globalv.fpsPotatoShippingCrate * 5).ToString();
            }

            if (timecnt % 8 == 0)
            {
                Globalv.fri += Globalv.friPotatoshippingboat;
            }

            if (timecnt % 5 == 0)
            {
                Globalv.fri += Globalv.friHandpotatocutter;
            }

            if (timecnt % 5 == 0)
            {
                if(Globalv.cheatsonoroff == 1)
                {
                    timer_cheatfps.Enabled = true;
                }
            }

            if (timecnt % 5 == 0)
            {
                Globalv.fri += Globalv.friOvenfries;
            }

            if (timecnt % 1 == 0)
            {
                Globalv.fri += Globalv.friSmallfries;
            }

            //if (timecnt % 40 == 0)
            //{
            //    if (clicksonfries >= 20)
            //    {
            //       Globalv.fri = 0;
            //        AutoClicker F4 = new AutoClicker();
            //        F4.Show();
            //        clicksonfries = 0;
            //   }
            ///    else
            //   {
            //     clicksonfries = 0;
            //    }
            //}

            if(timecnt % 120 == 0)
            {
                if(Globalv.cheatsonoroff == 1)
                {
                    pictureBox_Cheated.Visible = true;
                }
            }

           // if (timecnt % 200 == 0)
           // {
           //
           //    if(Globalv.cheatsonoroff == 1)
           //     {
           //         pictureBox_Cheated.Visible = true;
           //     }
           //     if (Process.GetProcessesByName("AutoClicker").Length > 0)
           //     {
           //         if (Globalv.autoclickeropens == 0)
           //         {
           //            AutoClicker F4 = new AutoClicker();
           //             F4.Show();
           //             autoclickerwarningcounter += 1;
           //             Globalv.autoclickeropens = 1;
           //         }
           //         else
           //         {
           //             autoclickerwarningcounter += 1;
           //             Globalv.autoclickeropens = 0;
           //         }
           //
           //         if (autoclickerwarningcounter >= 6)
           //         {
           //             Globalv.fri = -999999999;
           //             MessageBox.Show("You Did not Close Auto Clicker" +
           //                             "You Have to close it next time " +
           //                             "Restart the program and close Auto Clicker" +
           //                             "Your Fries have been set to -999999999");
           //         }
           //    }
           //
           // }
            
        }

            private void button_PotatoPot_Click(object sender, EventArgs e)
            {
                if (Globalv.fri >= Globalv.pricePotatopot)
                {
                Globalv.amtPotatopot += 1;
                    Globalv.FPS += Globalv.fpsPotatopot;
                    Globalv.fri -= Globalv.pricePotatopot;
                Globalv.pricePotatopot += Globalv.incpricePotatopot;
                    label_FPS.Text = Globalv.FPS.ToString();
                    label_amtofPp.Text = Globalv.amtPotatopot.ToString();
                    label_pricePotatopot.Text = Globalv.pricePotatopot.ToString();
                Globalv.incpricePotatopot += Globalv.incincpricePotatopot;

                }
                else
                {
                    if(Globalv.notenoughcount == 0)
                {
                    Globalv.notenoughcount = 1;
                    NotEnoughFries F5 = new NotEnoughFries();
                    F5.Show();
                }
                }
            }

            private void button_smallfarm_Click(object sender, EventArgs e)
            {
                if (Globalv.fri >= Globalv.priceSmallfarm)
                {
                Globalv.amtSmallfarm += 1;
                Globalv.friSmallfarm += Globalv.fpssmallfarm;
                    Globalv.fri -= Globalv.priceSmallfarm;
                    Globalv.FPS += Globalv.fpssmallfarm;
                    Globalv.priceSmallfarm += Globalv.incpriceSmallfarm;
                    label_FPS.Text = Globalv.FPS.ToString();
                    label_priceofSmall.Text = Globalv.priceSmallfarm.ToString();
                    label_amtofsmallfarm.Text = Globalv.amtSmallfarm.ToString();
                Globalv.incpriceSmallfarm += Globalv.incincpriceSmallfarm;
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

            private void button_farm_Click(object sender, EventArgs e)
            {
                if (Globalv.fri >= Globalv.priceFarm)
                {
                Globalv.amtFarm += 1;
                Globalv.friFarm += Globalv.fpsfarm;
                    Globalv.fri -= Globalv.priceFarm;
                    Globalv.FPS += (Globalv.fpsfarm * 2);
                Globalv.priceFarm += Globalv.incpriceFarm;
                    label_FPS.Text = Globalv.FPS.ToString();
                    label_priceofFarm.Text = Globalv.priceFarm.ToString();
                    label_amtoffarm.Text = Globalv.amtFarm.ToString();
                Globalv.incpriceFarm += Globalv.incincpriceFarm;
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

            private void button_boxpotato_Click(object sender, EventArgs e)
            {
                if (Globalv.fri >= Globalv.priceBoxopotato)
                {
                Globalv.amtBoxpotato += 1;
                Globalv.friBoxopotato += (Globalv.fpsBoxOPotatos * 2);
                    Globalv.fri -= Globalv.priceBoxopotato;
                    Globalv.FPS += Globalv.fpsBoxOPotatos;
                Globalv.priceBoxopotato += Globalv.incpriceBoxo;
                    label_FPS.Text = Globalv.FPS.ToString();
                    label_priceofboxo.Text = Globalv.priceBoxopotato.ToString();
                    label_amtofbox.Text = Globalv.amtBoxpotato.ToString();
                Globalv.incpriceBoxo += Globalv.incincpriceBoxo;
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

            private void button_greenhouse_Click(object sender, EventArgs e)
            {
                if (Globalv.fri >= Globalv.priceGreenhouse)
                {
                Globalv.amtGreenhouse += 1;
                    Globalv.fri -= Globalv.priceGreenhouse;
                    Globalv.FPS += Globalv.fpsgreenhouse;
                Globalv.priceGreenhouse += Globalv.incpriceGreenhouse;
                    label_FPS.Text = Globalv.FPS.ToString();
                    label_priceofGreen.Text = Globalv.priceGreenhouse.ToString();
                    label_amtofgreenhuse.Text = Globalv.amtGreenhouse.ToString();
                Globalv.incpriceGreenhouse += Globalv.incincpriceGreenhouse;
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

            private void button_sackopotatos_Click(object sender, EventArgs e)
            {
                if (Globalv.fri >= Globalv.priceSackopotato)
                {
                Globalv.amtSackopotato += 1;
                    Globalv.fri -= Globalv.priceSackopotato;
                    Globalv.FPS += (Globalv.fpsSackOPotatos * 4);
                Globalv.friSackopotato += Globalv.fpsSackOPotatos;
                Globalv.priceSackopotato += Globalv.incpriceSacko;
                    label_FPS.Text = Globalv.FPS.ToString();
                    label_priceofsacko.Text = Globalv.priceSackopotato.ToString();
                    label_amtSacko.Text = Globalv.amtSackopotato.ToString();
                Globalv.incpriceSacko += Globalv.incincpriceSacko;
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

            private void button_potatocrate_Click(object sender, EventArgs e)
            {
                if (Globalv.fri >= Globalv.pricePotatocrate)
                {
                Globalv.amtPotatocrate += 1;
                    Globalv.fri -= Globalv.pricePotatocrate;
                    Globalv.FPS += (Globalv.fpsPotatoCrate * 40);
                Globalv.friPotatocrate += Globalv.fpsPotatoCrate;
                Globalv.pricePotatocrate += Globalv.incpricePotatocrate;
                    label_FPS.Text = Globalv.FPS.ToString();
                    label_pricePotatocrate.Text = Globalv.pricePotatocrate.ToString();
                    label_amtofPotatocrate.Text = Globalv.amtPotatocrate.ToString();
                Globalv.incpricePotatocrate += Globalv.incincpricePotatocrate;
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

            private void button_potatoshipboat_Click(object sender, EventArgs e)
            {
                if (Globalv.fri >= Globalv.pricePotatoshippingboat)
                {
                Globalv.amtPotatoshippingcrate += 1;
                    Globalv.fri -= Globalv.pricePotatoshippingboat;
                    Globalv.FPS += (Globalv.fpsPotatoShippingCrate * 5);
                Globalv.friPotatoshippingboat += Globalv.fpsPotatoShippingCrate;
                Globalv.pricePotatoshippingboat += Globalv.incpriceShippingboat;
                    label_FPS.Text = Globalv.FPS.ToString();
                    label_pricePotatoshippingboat.Text = Globalv.pricePotatoshippingboat.ToString();
                    label_amtofPotatoshippingboat.Text = Globalv.amtPotatoshippingcrate.ToString();
                Globalv.incpriceShippingboat += Globalv.incincpriceShippingboat;
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

            private void button_handpotatocutter_Click(object sender, EventArgs e)
            {
                if (Globalv.fri >= Globalv.pricehandpotatocutter)
                {
                Globalv.amtHandPotatocutter += 1;
                    Globalv.fri -= Globalv.pricehandpotatocutter;
                    Globalv.FPS += 4000;
                Globalv.friHandpotatocutter += 500; //do it 8 cause 500 x 8 is 4000
                Globalv.pricehandpotatocutter += Globalv.incpriceHandpotatocutter;
                    label_FPS.Text = Globalv.FPS.ToString();
                    label_priceofHandpotatocutter.Text = Globalv.pricehandpotatocutter.ToString();
                    label_amtofHandpotatocutter.Text = Globalv.amtHandPotatocutter.ToString();
                Globalv.incpriceHandpotatocutter += 75000;
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

            private void button_Deepfryer_Click(object sender, EventArgs e)
            {
                if (Globalv.fri >= Globalv.pricedeepfryer)
                {
                Globalv.amtDeepfryer += 1;
                    Globalv.fri -= Globalv.pricedeepfryer;
                    Globalv.FPS += 7000;
                Globalv.friDeepfryer += 3500; //do it 2 cause 3500 x 2  is 700
                Globalv.pricedeepfryer += Globalv.incpriceDeepfryer;
                    label_FPS.Text = Globalv.FPS.ToString();
                    label_priceofDeepfryer.Text = Globalv.pricedeepfryer.ToString();
                    label_amtofDeepfryer.Text = Globalv.amtDeepfryer.ToString();
                Globalv.incpriceDeepfryer += 150000;
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

            private void button_Ovenfries_Click(object sender, EventArgs e)
            {
                if (Globalv.fri >= Globalv.priceovenfries)
                {
                Globalv.amtOvenfries += 1;
                    Globalv.fri -= Globalv.priceovenfries;
                    Globalv.FPS += 10000;
                Globalv.friOvenfries += 500; //do it 10 cause yea it work so do 5 interval
                Globalv.priceovenfries += Globalv.incpriceOvenfries;
                    label_FPS.Text = Globalv.FPS.ToString();
                    label_priceofOvenfries.Text = Globalv.priceovenfries.ToString();
                    label_amtofOvenFries.Text = Globalv.amtOvenfries.ToString();
                Globalv.incpriceOvenfries += 240000;
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

            private void button_smallfries_Click(object sender, EventArgs e)
            {
                if (Globalv.fri >= Globalv.pricesmallfries)
                {
                Globalv.amtSmallfries += 1;
                    Globalv.fri -= Globalv.pricesmallfries;
                    Globalv.FPS += 14000;
                Globalv.friSmallfries += 350; //do it 10 cause yea it work so do 5 interval
                Globalv.pricesmallfries += Globalv.incpriceSmallfries;
                    label_FPS.Text = Globalv.FPS.ToString();
                    label_priceofSmallfries.Text = Globalv.pricesmallfries.ToString();
                    label_amtofSmallFries.Text = Globalv.amtSmallfries.ToString();
                Globalv.incpriceSmallfries += 360000;
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

        private void pictureBox_Cheated_Click(object sender, EventArgs e)
        {

        }

        private void timer_cheatfps_Tick(object sender, EventArgs e)
        {
            Globalv.fri += Globalv.cheatfps;
        }


        //The 3Rd Row


        private void button_Fries_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.priceFrenchfries)
            {
                Globalv.amtFrenchFri += 1;
                Globalv.fri -= Globalv.priceFrenchfries;
                Globalv.FPS += 21000;
                Globalv.friFrenchFri += 525; //run this 40 times so on the 1 time tick interval
                Globalv.priceFrenchfries += Globalv.incpriceFrenchFri;
                label_FPS.Text = Globalv.FPS.ToString();
                label_priceFries.Text = Globalv.priceFrenchfries.ToString();
                label_amtofFries.Text = Globalv.amtFrenchFri.ToString();
                Globalv.incpriceFrenchFri += 750000;
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

        private void button_BagOfries_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.priceBagofries)
            {
                Globalv.amtbagofries += 1;
                Globalv.fri -= Globalv.priceBagofries;
                Globalv.FPS += 32000;
                Globalv.fribagofries += 800; //run this 40 times so on the 1 time tick interval
                Globalv.priceBagofries += Globalv.incpricebagofries;
                label_FPS.Text = Globalv.FPS.ToString();
                label_priceBagOFries.Text = Globalv.priceBagofries.ToString();
                label_amtofBagOFries.Text = Globalv.amtbagofries.ToString();
                Globalv.incpricebagofries += 1800000;
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

        private void button_Largedeepfryer_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.priceLargedeepfryer)
            {
                Globalv.amtlargedeepfryer += 1;
                Globalv.fri -= Globalv.priceLargedeepfryer;
                Globalv.FPS += 60000;
                Globalv.frilargedeepfryer += 1500; //run this 40 times so on the 1 time tick interval
                Globalv.priceLargedeepfryer += Globalv.incpricelargedeepfryer;
                label_FPS.Text = Globalv.FPS.ToString();
                label_priceLargedeepFryer.Text = Globalv.priceLargedeepfryer.ToString();
                label_amtofLargeDeepFryer.Text = Globalv.amtlargedeepfryer.ToString();
                Globalv.incpricelargedeepfryer += 4500000;
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

        private void button_BarreloFries_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.priceBarrelofries)
            {
                Globalv.amtbarrelofries += 1;
                Globalv.fri -= Globalv.priceBarrelofries;
                Globalv.FPS += 100000;
                Globalv.fribarrelofries += 2500; //run this 40 times so on the 1 time tick interval
                Globalv.priceBarrelofries += Globalv.incpricebarrelofries;
                label_FPS.Text = Globalv.FPS.ToString();
                label_priceBarrelOfries.Text = Globalv.priceBarrelofries.ToString();
                label_amtofBarrelOFries.Text = Globalv.amtbarrelofries.ToString();
                Globalv.incpricebarrelofries += 7500000;
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

        private void button_Thefritruck_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.priceThefritruck)
            {
                Globalv.amtThefritruck += 1;
                Globalv.fri -= Globalv.priceThefritruck;
                Globalv.FPS += 175000;
                Globalv.friThefritruck += 4375; //run this 40 times so on the 1 time tick interval
                Globalv.priceThefritruck += Globalv.incpriceThefritruck;
                label_FPS.Text = Globalv.FPS.ToString();
                label_priceThefriTruck.Text = Globalv.priceThefritruck.ToString();
                label_amtofTheFriTruck.Text = Globalv.amtThefritruck.ToString();
                Globalv.incpriceThefritruck += 12000000;
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

        private void button_FrenchFriPlane_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.priceFrenchfriplane)
            {
                Globalv.amtfrenchfriplane += 1;
                Globalv.fri -= Globalv.priceFrenchfriplane;
                Globalv.FPS += 300000;
                Globalv.frifrenchfriplane += 7500; //run this 40 times so on the 1 time tick interval
                Globalv.priceFrenchfriplane += Globalv.incpricefrenchfriplane;
                label_FPS.Text = Globalv.FPS.ToString();
                label_priceFrenchfriPlane.Text = Globalv.priceFrenchfriplane.ToString();
                label_amtofFrenchFriPlane.Text = Globalv.amtfrenchfriplane.ToString();
                Globalv.incpricefrenchfriplane += 24000000;
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

        private void button_GiantPotatoSilo_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.priceGiantpotatosilo)
            {
                Globalv.amtGiantpotatosilo += 1;
                Globalv.fri -= Globalv.priceGiantpotatosilo;
                Globalv.FPS += 500000;
                Globalv.friGiantpotatosilo += 12500; //run this 40 times so on the 1 time tick interval
                Globalv.priceGiantpotatosilo += Globalv.incpriceGiantpotatosilo;
                label_FPS.Text = Globalv.FPS.ToString();
                label_priceGiantPotoatSilo.Text = Globalv.priceGiantpotatosilo.ToString();
                label_amtofGaintpotatosilo.Text = Globalv.amtGiantpotatosilo.ToString();
                Globalv.incpriceGiantpotatosilo += 37500000;
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

        private void button_Potatoblimp_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.pricePotatoblimp)
            {
                Globalv.amtPotatoblimp += 1;
                Globalv.fri -= Globalv.pricePotatoblimp;
                Globalv.FPS += 800000;
                Globalv.friPotatoblimp += 20000; //run this 40 times so on the 1 time tick interval
                Globalv.pricePotatoblimp += Globalv.incpricePotatoblimp;
                label_FPS.Text = Globalv.FPS.ToString();
                label_pricePotatoBlimp.Text = Globalv.pricePotatoblimp.ToString();
                label_amtofPotatoblimp.Text = Globalv.amtPotatoblimp.ToString();
                Globalv.incpricePotatoblimp += 52500000;
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

        private void button_PotatoFactory_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.pricePotatofactory)
            {
                Globalv.amtPotatofactory += 1;
                Globalv.fri -= Globalv.pricePotatofactory;
                Globalv.FPS += 2000000;
                Globalv.friPotatofactory += 50000; //run this 40 times so on the 1 time tick interval
                Globalv.pricePotatofactory += Globalv.incpricePotatofactory;
                label_FPS.Text = Globalv.FPS.ToString();
                label_pricePotatoFactory.Text = Globalv.pricePotatofactory.ToString();
                label_amtofPotatoFactory.Text = Globalv.amtPotatofactory.ToString();
                Globalv.incpricePotatofactory += 75000000;
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

        private void button_FrenchfriStand_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.priceFrenchfriStand)
            {
                Globalv.amtFrenchfriStand += 1;
                Globalv.fri -= Globalv.priceFrenchfriStand;
                Globalv.FPS += 5000000;
                Globalv.friFrenchfriStand += 125000; //run this 40 times so on the 1 time tick interval
                Globalv.priceFrenchfriStand += Globalv.incpriceFrenchfriStand;
                label_FPS.Text = Globalv.FPS.ToString();
                label_priceFrenchFriStand.Text = Globalv.priceFrenchfriStand.ToString();
                label_amtofFrenchFriStand.Text = Globalv.amtFrenchfriStand.ToString();
                Globalv.incpriceFrenchfriStand += 150000000;
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

        private void button_FrenchfriTrain_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.priceFrenchfritrain)
            {
                Globalv.amtFrenchfritrain += 1;
                Globalv.fri -= Globalv.priceFrenchfritrain;
                Globalv.FPS += 8000000;
                Globalv.friFrenchfriStand += 200000; //run this 40 times so on the 1 time tick interval
                Globalv.priceFrenchfritrain += Globalv.incpriceFrenchfritrain;
                label_FPS.Text = Globalv.FPS.ToString();
                label_priceFrenchFriTrain.Text = Globalv.priceFrenchfritrain.ToString();
                label_amtofFrenchFriTrain.Text = Globalv.amtFrenchfritrain.ToString();
                Globalv.incpriceFrenchfritrain += 300000000;
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

        private void button_FrenchfriKnife_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.priceFrenchfriknife)
            {
                Globalv.amtFrenchfriknife += 1;
                Globalv.fri -= Globalv.priceFrenchfriknife;
                Globalv.FPS += 12500000;
                Globalv.friFrenchfriknife += 312500; //run this 40 times so on the 1 time tick interval
                Globalv.priceFrenchfriknife += Globalv.incpriceFrenchfriknife;
                label_FPS.Text = Globalv.FPS.ToString();
                label_priceFrenchFriKnife.Text = Globalv.priceFrenchfriknife.ToString();
                label_amtofFrenchFriKnife.Text = Globalv.amtFrenchfriknife.ToString();
                Globalv.incpriceFrenchfriknife += 375000000;
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

        private void button1_Click_2(object sender, EventArgs e)
        {
         
        }

        private void button_savemenu_Click(object sender, EventArgs e)
        {
            SaveGame F13 = new SaveGame();
            F13.Show();
        }

        private void button_powerupmenu_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Next Update");
            Powerupmenu F14 = new Powerupmenu();
            F14.Show();
        }

        private void label_fpsFarm_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            
            
        }

        private void button_openstockmarket_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("In Beta");
            StockMarketpg1 F15 = new StockMarketpg1();
            F15.Show();
        }

        private void button_OpenAchivements_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Next Update");
            //Powerupmenu F14 = new Powerupmenu();
            //F14.Show();
        }

        private void button_openCasino_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Next Update");
            //Powerupmenu F14 = new Powerupmenu();
            //F14.Show();
        }
    }
    }
 
