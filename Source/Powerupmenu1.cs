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
    public partial class Powerupmenu : Form
    {
        public Powerupmenu()
        {
            InitializeComponent();
            if (Globalv.powerpotatopotfps == 1)
            {
                button_Potatopot_fps.Enabled = false;
                picture_soldPotatopotfps.Visible = true;
            }

            if (Globalv.powerpotatopotperc == 1)
            {
                button_Potatopot_perc.Enabled = false;
                picture_soldPotatopotperc.Visible = true;
            }

            if(Globalv.powerSmallfarmfps == 1)
            {
                button_Smallfarm_fps.Enabled = false;
                picture_soldsmallfarmfps.Visible = true;
            }

            if (Globalv.powerSmallfarmperc == 1)
            {
                button_smallfarm_perc.Enabled = false;
                picture_soldsmallfarmperc.Visible = true;
            }

            if (Globalv.powerGreenhousefps == 1)
            {
                button_Greenhouse_fps.Enabled = false;
                picture_soldgreenhousefps.Visible = true;
            }

            if (Globalv.powerGreenhouseperc == 1)
            {
                button_Greenhouse_perc.Enabled = false;
                picture_soldgreenhouseperc.Visible = true;
            }

            if (Globalv.powerfarmfps == 1)
            {
                button_Farm_fps.Enabled = false;
                picture_soldfarmfps.Visible = true;
            }

            if (Globalv.powerfarmperc == 1)
            {
                button_Farm_perc.Enabled = false;
                picture_soldfarmperxc.Visible = true;
            }

            if (Globalv.powerBoxOPotatosfps == 1)
            {
                button_BoxOFPS.Enabled = false;
                picture_soldBoxOfps.Visible = true;
            }

            if (Globalv.powerBoxOPotatosperc == 1)
            {
                button_BoxOPerc.Enabled = false;
                picture_soldBoxoperc.Visible = true;
            }

            if (Globalv.powerSackOPotatoperc == 1)
            {
                button_SackOPerc.Enabled = false;
                picture_soldSackOPerc.Visible = true;
            }

            if (Globalv.powerSackOPotatosfps == 1)
            {
                button_SackOFps.Enabled = false;
                picture_soldSackOFps.Visible = true;
            }

            if (Globalv.powerPotatoCratefps == 1)
            {
                button_Potatocratefps.Enabled = false;
                picture_soldPotatocratefps.Visible = true;
            }

            if (Globalv.powerPotatoCrateperc == 1)
            {
                button_Potatocrateperc.Enabled = false;
                picture_soldPotatocrateperc.Visible = true;
            }

            if (Globalv.powerPotatoShippingboatfps == 1)
            {
                button_potatoshippingBoatfps.Enabled = false;
                picture_soldPotatoshipboatfps.Visible = true;
            }

            if (Globalv.powerPotatoShippingboatperc == 1)
            {
                button_potatoshippingboatperc.Enabled = false;
                picture_soldPotatoshippingboatperc.Visible = true;
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Potatopot_fps_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.powerpricepotatopotfps)
            {
                Globalv.upgradesbought += 1;
                Globalv.powerpotatopotfps = 1;
                Globalv.fri -= Globalv.powerpricepotatopotfps;
                Globalv.timerpotatopotfps = 20;
                picture_soldPotatopotfps.Visible = true;
                Globalv.FPS += Globalv.amtPotatopot;
                button_Potatopot_fps.Enabled = false;
                Globalv.fpsPotatopot = 2;
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

        private void button_Potatopot_perc_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.powerpricepotatopotperc)
            {
                Globalv.upgradesbought += 1;
                Globalv.powerpotatopotperc = 1;
                Globalv.fri -= Globalv.powerpricepotatopotperc;
                picture_soldPotatopotperc.Visible = true;
                button_Potatopot_perc.Enabled = false;
                Globalv.incincpricePotatopot = 5;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_Fries.Text = Globalv.fri.ToString();

        }

        private void button_Smallfarm_fps_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.powerpriceSmallfarmfps)
            {
                Globalv.upgradesbought += 1;
                Globalv.powerSmallfarmfps = 1;
                Globalv.fri -= Globalv.powerSmallfarmfps;
                picture_soldsmallfarmfps.Visible = true;
                button_Smallfarm_fps.Enabled = false;
                Globalv.fpssmallfarm = 5;
                Globalv.friSmallfarm += (Globalv.amtSmallfarm * 3);
                Globalv.FPS += (Globalv.amtSmallfarm * 3);
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

        private void button_smallfarm_perc_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.powerpriceSmallfarmperc)
            {
                Globalv.upgradesbought += 1;
                Globalv.powerSmallfarmperc = 1;
                Globalv.fri -= Globalv.powerpriceSmallfarmperc;
                picture_soldsmallfarmperc.Visible = true;
                button_smallfarm_perc.Enabled = false;
                Globalv.incincpriceSmallfarm = 5;
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

        private void button_Greenhouse_fps_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.powerpriceGreenhousefps)
            {
                Globalv.upgradesbought += 1;
                Globalv.powerGreenhousefps = 1;
                Globalv.fri -= Globalv.powerpriceGreenhousefps;
                picture_soldgreenhousefps.Visible = true;
                button_Greenhouse_fps.Enabled = false;
                Globalv.fpsgreenhouse = 20;
                Globalv.frigreenhouse += (Globalv.amtGreenhouse * 5);
                Globalv.FPS += (Globalv.amtGreenhouse * 15);
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

        private void button_Greenhouse_perc_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.powerpriceGreenhouseperc)
            {
                Globalv.upgradesbought += 1;
                Globalv.powerGreenhouseperc = 1;
                Globalv.fri -= Globalv.powerGreenhouseperc;
                picture_soldgreenhouseperc.Visible = true;
                button_Greenhouse_perc.Enabled = false;
                Globalv.incincpriceGreenhouse = 10;
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

        private void button_Farm_fps_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.powerpricefarmfps)
            {
                Globalv.upgradesbought += 1;
                Globalv.powerfarmfps = 1;
                Globalv.fri -= Globalv.powerpricefarmfps;
                picture_soldfarmfps.Visible = true;
                button_Farm_fps.Enabled = false;
                Globalv.fpsfarm = 18;
                Globalv.friFarm += (Globalv.amtFarm * 6);
                Globalv.FPS += (Globalv.amtFarm * 24);
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

        private void button_Farm_perc_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.powerpricefarmperc)
            {
                Globalv.upgradesbought += 1;
                Globalv.powerfarmperc = 1;
                Globalv.fri -= Globalv.powerpricefarmperc;
                picture_soldfarmperxc.Visible = true;
                button_Farm_perc.Enabled = false;
                Globalv.incincpriceFarm = 25;
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

        private void button_BoxOFPS_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.powerpriceBoxOPotatosfps)
            {
                Globalv.upgradesbought += 1;
                Globalv.powerBoxOPotatosfps = 1;
                Globalv.fri -= Globalv.powerpriceBoxOPotatosfps;
                picture_soldBoxOfps.Visible = true;
                button_BoxOFPS.Enabled = false;
                Globalv.fpsBoxOPotatos = 50;
                Globalv.friBoxopotato += (Globalv.amtBoxpotato * 35);
                Globalv.FPS += (Globalv.amtBoxpotato * 70);
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

        private void button_BoxOPerc_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.powerpriceBoxOPotatosperc)
            {
                Globalv.upgradesbought += 1;
                Globalv.powerBoxOPotatosperc = 1;
                Globalv.fri -= Globalv.powerpriceBoxOPotatosperc;
                picture_soldBoxoperc.Visible = true;
                button_BoxOPerc.Enabled = false;
                Globalv.incincpriceBoxo = 75;
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

        private void button_SackOFps_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.powerpriceSackOFps)
            {
                Globalv.upgradesbought += 1;
                Globalv.powerSackOPotatosfps = 1;
                Globalv.fri -= Globalv.powerpriceSackOFps;
                picture_soldSackOFps.Visible = true;
                button_SackOFps.Enabled = false;
                Globalv.fpsSackOPotatos = 200;
                Globalv.friSackopotato += (Globalv.amtSackopotato * 150);
                Globalv.FPS += (Globalv.amtSackopotato * 600);
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

        private void button_SackOPerc_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.powerpriceSackOperc)
            {
                Globalv.upgradesbought += 1;
                Globalv.powerSackOPotatoperc = 1;
                Globalv.fri -= Globalv.powerpriceSackOperc;
                picture_soldSackOPerc.Visible = true;
                button_SackOPerc.Enabled = false;
                Globalv.incincpriceSacko = 500;
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

        private void button_Potatocratefps_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.powerpricePotatoCratefps)
            {
                Globalv.upgradesbought += 1;
                Globalv.powerPotatoCratefps = 1;
                Globalv.fri -= Globalv.powerpricePotatoCratefps;
                picture_soldPotatocratefps.Visible = true;
                button_Potatocratefps.Enabled = false;
                Globalv.fpsPotatoCrate = 100;
                Globalv.friPotatocrate += (Globalv.amtPotatocrate * 70);
                Globalv.FPS += (Globalv.amtPotatocrate * 2800);
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

        private void button_Potatocrateperc_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.powerpricePotatoCrateperc)
            {
                Globalv.upgradesbought += 1;
                Globalv.powerPotatoCrateperc = 1;
                Globalv.fri -= Globalv.powerpricePotatoCrateperc;
                picture_soldPotatocrateperc.Visible = true;
                button_Potatocrateperc.Enabled = false;
                Globalv.incincpricePotatocrate = 2500;
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

        private void button_potatoshippingBoatfps_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.powerpricePotatoShipfps)
            {
                Globalv.upgradesbought += 1;
                Globalv.powerPotatoShippingboatfps = 1;
                Globalv.fri -= Globalv.powerpricePotatoShipfps;
                picture_soldPotatoshipboatfps.Visible = true;
                button_potatoshippingBoatfps.Enabled = false;
                Globalv.fpsPotatoShippingCrate = 2000;
                Globalv.friPotatoshippingboat += (Globalv.amtPotatoshippingcrate * 1500);
                Globalv.FPS += (Globalv.amtPotatoshippingcrate * 7500);
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

        private void button_potatoshippingboatperc_Click(object sender, EventArgs e)
        {
            if (Globalv.fri >= Globalv.powerpricePotatoShipperc)
            {
                Globalv.upgradesbought += 1;
                Globalv.powerPotatoShippingboatperc = 1;
                Globalv.fri -= Globalv.powerpricePotatoShipperc;
                picture_soldPotatoshippingboatperc.Visible = true;
                button_potatoshippingboatperc.Enabled = false;
                Globalv.incincpriceShippingboat = 6250;
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Globalv.upgradesbought == 16)
            {
                Globalv.upgrademenu = 2;
                //Open New Upgrade
                this.Close();
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Powerupmenu_Load(object sender, EventArgs e)
        {
           
        }
    
    }
}
