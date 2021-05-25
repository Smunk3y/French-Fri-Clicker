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
    public partial class SaveGame : Form
    {
        public SaveGame()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Globalv.lastsave = DateTime.Now.ToString();
        }

        private void SaveGame_Load(object sender, EventArgs e)
        {
            label_lastsave.Text = Properties.Settings.Default.Lasttime.ToString();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_save1Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.saveornoSave1 = 1;
            Properties.Settings.Default.friSave1 = Globalv.fri;
            Properties.Settings.Default.fpsSave1 = Globalv.FPS;
            Properties.Settings.Default.fpcSave1 = Globalv.FPC;
            Properties.Settings.Default.cheatsonSave1 = Globalv.cheatsonoroff;

            //The Main page Inc Price Rates

            Properties.Settings.Default.incpricePotatopotSave1 = Globalv.incpricePotatopot;
            Properties.Settings.Default.incpriceSmallfarmSave1 = Globalv.incpriceSmallfarm;
            Properties.Settings.Default.incpriceGreenhouseSave1 = Globalv.incpriceGreenhouse;
            Properties.Settings.Default.incpriceFarmSave1 = Globalv.incpriceFarm;
            Properties.Settings.Default.incpriceBoxoSave1 = Globalv.incpriceBoxo;
            Properties.Settings.Default.incpriceSackoSave1 = Globalv.incpriceSacko;

            Properties.Settings.Default.incpricePotatocrateSave1 = Globalv.incpricePotatocrate;
            Properties.Settings.Default.incpriceShippingboatSave1 = Globalv.incpriceShippingboat;
            Properties.Settings.Default.incpriceHandpotatocutterSave1 = Globalv.incpriceHandpotatocutter;
            Properties.Settings.Default.incpriceDeepfryerSave1 = Globalv.incpriceDeepfryer;
            Properties.Settings.Default.incpriceOvenfriesSave1 = Globalv.incpriceOvenfries;
            Properties.Settings.Default.incpriceSmallfriesSave1 = Globalv.incpriceSmallfries;

            Properties.Settings.Default.incpriceFrenchFriSave1 = Globalv.incpriceFrenchFri;
            Properties.Settings.Default.incpricebagofriesSave1 = Globalv.incpricebagofries;
            Properties.Settings.Default.incpricelargedeepfryerSave1 = Globalv.incpricelargedeepfryer;
            Properties.Settings.Default.incpricebarrelofriesSave1 = Globalv.incpricebarrelofries;
            Properties.Settings.Default.incpriceThefritruckSave1 = Globalv.incpriceThefritruck;
            Properties.Settings.Default.incpricefrenchfriplaneSave1 = Globalv.incpricefrenchfriplane;

            Properties.Settings.Default.incpriceGiantpotatosiloSave1 = Globalv.incpriceGiantpotatosilo;
            Properties.Settings.Default.incpricePotatoblimpSave1 = Globalv.incpricePotatoblimp;
            Properties.Settings.Default.incpricePotatofactorySave1 = Globalv.incpricePotatofactory;
            Properties.Settings.Default.incpriceFrenchfriStandSave1 = Globalv.incpriceFrenchfriStand;
            Properties.Settings.Default.incpriceFrenchfritrainSave1 = Globalv.incpriceFrenchfritrain;
            Properties.Settings.Default.incpriceFrenchfriknifeSave1 = Globalv.incpriceFrenchfriknife;

            //amt of the stuff on main page

            Properties.Settings.Default.amtPotatopotSave1 = Globalv.amtPotatopot;
            Properties.Settings.Default.amtSmallfarmSave1 = Globalv.amtSmallfarm;
            Properties.Settings.Default.amtGreenhouseSave1 = Globalv.amtGreenhouse;
            Properties.Settings.Default.amtFarmSave1 = Globalv.amtFarm;
            Properties.Settings.Default.amtBoxpotatoSave1 = Globalv.amtBoxpotato;
            Properties.Settings.Default.amtSackopotatoSave1 = Globalv.amtSackopotato;

            Properties.Settings.Default.amtPotatocrateSave1 = Globalv.amtPotatocrate;
            Properties.Settings.Default.amtPotatoshippingcrateSave1 = Globalv.amtPotatoshippingcrate;
            Properties.Settings.Default.amtHandPotatocutterSave1 = Globalv.amtHandPotatocutter;
            Properties.Settings.Default.amtDeepfryerSave1 = Globalv.amtDeepfryer;
            Properties.Settings.Default.amtOvenfriesSave1 = Globalv.amtOvenfries;
            Properties.Settings.Default.amtSmallfriesSave1 = Globalv.amtSmallfries;

            Properties.Settings.Default.amtFrenchFriSave1 = Globalv.amtFrenchFri;
            Properties.Settings.Default.amtbagofriesSave1 = Globalv.amtbagofries;
            Properties.Settings.Default.amtlargedeepfryerSave1 = Globalv.amtlargedeepfryer;
            Properties.Settings.Default.amtbarrelofriesSave1 = Globalv.amtbarrelofries;
            Properties.Settings.Default.amtThefritruckSave1 = Globalv.amtThefritruck;
            Properties.Settings.Default.amtfrenchfriplaneSave1 = Globalv.amtfrenchfriplane;

            Properties.Settings.Default.amtGiantpotatosiloSave1 = Globalv.amtGiantpotatosilo;
            Properties.Settings.Default.amtPotatoblimpSave1 = Globalv.amtPotatoblimp;
            Properties.Settings.Default.amtPotatofactorySave1 = Globalv.amtPotatofactory;
            Properties.Settings.Default.amtFrenchfriStandSave1 = Globalv.amtFrenchfriStand;
            Properties.Settings.Default.amtFrenchfritrainSave1 = Globalv.amtFrenchfritrain;
            Properties.Settings.Default.amtFrenchfriknifeSave1 = Globalv.amtFrenchfriknife;

            //the saves for the fri applies to the fps items only 

            Properties.Settings.Default.friFarmSave1 = Globalv.friFarm;
            Properties.Settings.Default.friBoxopotatoSave1 = Globalv.friBoxopotato;
            Properties.Settings.Default.friSackopotatoSave1 = Globalv.friSackopotato;

            Properties.Settings.Default.friPotatocrateSave1 = Globalv.friPotatocrate;
            Properties.Settings.Default.friPotatoshippingboatSave1 = Globalv.friPotatoshippingboat;
            Properties.Settings.Default.friHandpotatocutterSave1 = Globalv.friHandpotatocutter;
            Properties.Settings.Default.friDeepfryerSave1 = Globalv.friDeepfryer;
            Properties.Settings.Default.friOvenfriesSave1 = Globalv.friOvenfries;
            Properties.Settings.Default.friSmallfriesSave1 = Globalv.friSmallfries;

            Properties.Settings.Default.friFrenchFriSave1 = Globalv.friFrenchFri;
            Properties.Settings.Default.fribagofriesSave1 = Globalv.fribagofries;
            Properties.Settings.Default.frilargedeepfryerSave1 = Globalv.frilargedeepfryer;
            Properties.Settings.Default.fribarrelofriesSave1 = Globalv.fribagofries;
            Properties.Settings.Default.friThefritruckSave1 = Globalv.friThefritruck;
            Properties.Settings.Default.frifrenchfriplaneSave1 = Globalv.frifrenchfriplane;

            Properties.Settings.Default.friGiantpotatosiloSave1 = Globalv.friGiantpotatosilo;
            Properties.Settings.Default.friPotatoblimpSave1 = Globalv.friGiantpotatosilo;
            Properties.Settings.Default.friPotatofactorySave1 = Globalv.friPotatofactory;
            Properties.Settings.Default.friFrenchfriStandSave1 = Globalv.friFrenchfriStand;
            Properties.Settings.Default.friFrenchfritrainSave1 = Globalv.friFrenchfritrain;
            Properties.Settings.Default.friFrenchfriknifeSave1 = Globalv.friFrenchfriknife;

            //the price of the items on the main page

            Properties.Settings.Default.pricePotatopotSave1 = Globalv.pricePotatopot;
            Properties.Settings.Default.priceSmallfarmSave1 = Globalv.priceSmallfarm;
            Properties.Settings.Default.priceGreenhouseSave1 = Globalv.priceGreenhouse;
            Properties.Settings.Default.priceFarmSave1 = Globalv.priceFarm;
            Properties.Settings.Default.priceBoxopotatoSave1 = Globalv.priceBoxopotato;
            Properties.Settings.Default.priceSackopotatoSave1 = Globalv.priceSackopotato;

            Properties.Settings.Default.pricePotatocrateSave1 = Globalv.pricePotatocrate;
            Properties.Settings.Default.pricePotatoshippingboatSave1 = Globalv.pricePotatoshippingboat;
            Properties.Settings.Default.pricehandpotatocutterSave1 = Globalv.pricehandpotatocutter;
            Properties.Settings.Default.pricedeepfryerSave1 = Globalv.pricedeepfryer;
            Properties.Settings.Default.priceovenfriesSave1 = Globalv.priceovenfries;
            Properties.Settings.Default.pricesmallfriesSave1 = Globalv.pricesmallfries;

            Properties.Settings.Default.priceFrenchfriesSave1 = Globalv.priceFrenchfries;
            Properties.Settings.Default.priceBagofriesSave1 = Globalv.priceBagofries;
            Properties.Settings.Default.priceLargedeepfryerSave1 = Globalv.priceLargedeepfryer;
            Properties.Settings.Default.priceBarrelofriesSave1 = Globalv.priceBarrelofries;
            Properties.Settings.Default.priceThefritruckSave1 = Globalv.priceThefritruck;
            Properties.Settings.Default.priceFrenchfriplaneSave1 = Globalv.priceFrenchfriplane;

            Properties.Settings.Default.priceGiantpotatosiloSave1 = Globalv.priceGiantpotatosilo;
            Properties.Settings.Default.pricePotatoblimpSave1 = Globalv.pricePotatoblimp;
            Properties.Settings.Default.pricePotatofactorySave1 = Globalv.pricePotatofactory;
            Properties.Settings.Default.priceFrenchfriStandSave1 = Globalv.priceFrenchfriStand;
            Properties.Settings.Default.priceFrenchfritrainSave1 = Globalv.priceFrenchfritrain;
            Properties.Settings.Default.priceFrenchfriknifeSave1 = Globalv.priceFrenchfriknife;


            //amt for the clickers 

            Properties.Settings.Default.amtBasicclickerSave1 = Globalv.amtBasicclicker;
            Properties.Settings.Default.amtPotatoclickerSave1 = Globalv.amtPotatoclicker;
            Properties.Settings.Default.amtPotatohelperSave1 = Globalv.amtPotatohelper;
            Properties.Settings.Default.amtDellmouseSave1 = Globalv.amtDellmouse;

            Properties.Settings.Default.amtRazermouseSave1 = Globalv.amtRazermouse;
            Properties.Settings.Default.amt15DollarmouseSave1 = Globalv.amt15Dollarmouse;
            Properties.Settings.Default.amtPotatoMouseSave1 = Globalv.amtPotatoMouse;
            Properties.Settings.Default.amtSparehandSave1 = Globalv.amtSparehand;

            Properties.Settings.Default.amtBronzehandSave1 = Globalv.amtBronzehand;
            Properties.Settings.Default.amtSilverhandSave1 = Globalv.amtSilverhand;
            Properties.Settings.Default.amtGoldhandSave1 = Globalv.amtGoldhand;
            Properties.Settings.Default.amtPlatinumhandSave1 = Globalv.amtPlatinumhand;

            Properties.Settings.Default.amtAmythysthandSave1 = Globalv.amtAmythysthand;
            Properties.Settings.Default.amtTopazhandSave1 = Globalv.amtTopazhand;
            Properties.Settings.Default.amtRubyhandSave1 = Globalv.amtRubyhand;
            Properties.Settings.Default.amtSapphirehandSave1 = Globalv.amtSapphirehand;

            //Prices of the Clicker on the First page of the FPC memu

            Properties.Settings.Default.priceofBasicclickerSave1 = Globalv.priceofBasicclicker;
            Properties.Settings.Default.priceofPotatoclcikerSave1 = Globalv.priceofPotatoclciker;
            Properties.Settings.Default.priceofPotatohelperSave1 = Globalv.priceofPotatohelper;
            Properties.Settings.Default.priceofDellmouseSave1 = Globalv.priceofDellmouse;

            Properties.Settings.Default.priceofRazermouseSave1 = Globalv.priceofRazermouse;
            Properties.Settings.Default.priceof15DollarmouseSave1 = Globalv.priceof15Dollarmouse;
            Properties.Settings.Default.priceofPotatoMouseSave1 = Globalv.priceofPotatoMouse;
            Properties.Settings.Default.priceofSparehandSave1 = Globalv.priceofSparehand;

            Properties.Settings.Default.priceofBronzehandSave1 = Globalv.priceofBronzehand;
            Properties.Settings.Default.priceofSilverhandSave1 = Globalv.priceofSilverhand;
            Properties.Settings.Default.priceofGoldhandSave1 = Globalv.priceofGoldhand;
            Properties.Settings.Default.priceofPlatinumhandSave1 = Globalv.priceofPlatinumhand;

            Properties.Settings.Default.priceofAmythysthandSave1 = Globalv.priceofAmythysthand;
            Properties.Settings.Default.priceofTopazhandSave1 = Globalv.priceofTopazhand;
            Properties.Settings.Default.priceofRubyhandSave1 = Globalv.priceofRubyhand;
            Properties.Settings.Default.priceofSapphirehandSave1 = Globalv.priceofSapphirehand;


            //Inc price for the clickers 

            Properties.Settings.Default.incBasicclickerSave1 = Globalv.incBasicclicker;
            Properties.Settings.Default.incPotatoclickerSave1 = Globalv.incPotatoclicker;
            Properties.Settings.Default.incPotatohelperSave1 = Globalv.incPotatohelper;
            Properties.Settings.Default.incDellmouseSave1 = Globalv.incDellmouse;

            Properties.Settings.Default.incRazermouseSave1 = Globalv.incRazermouse;
            Properties.Settings.Default.inc15DollarmouseSave1 = Globalv.inc15Dollarmouse;
            Properties.Settings.Default.incPotatoMouseSave1 = Globalv.incPotatoMouse;
            Properties.Settings.Default.incSparehandSave1 = Globalv.incSparehand;

            Properties.Settings.Default.incBronzehandSave1 = Globalv.incBronzehand;
            Properties.Settings.Default.incSilverhandSave1 = Globalv.incSilverhand;
            Properties.Settings.Default.incGoldhandSave1 = Globalv.incGoldhand;
            Properties.Settings.Default.incPlatinumhandSave1 = Globalv.incPlatinumhand;

            Properties.Settings.Default.incAmythysthandSave1 = Globalv.incAmythysthand;
            Properties.Settings.Default.incTopazhandSave1 = Globalv.incTopazhand;
            Properties.Settings.Default.incRubyhandSave1 = Globalv.incRubyhand;
            Properties.Settings.Default.incSapphirehandSave1 = Globalv.incSapphirehand;

            Properties.Settings.Default.Lasttime = Globalv.lastsave;
           label_lastsave.Text = Properties.Settings.Default.Lasttime.ToString();
           
        }

        private void button_save1Load_Click(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.saveornoSave1 == 1)
            {
                Globalv.fri = Properties.Settings.Default.friSave1;
                Globalv.FPS = Properties.Settings.Default.fpsSave1;
                Globalv.FPC = Properties.Settings.Default.fpcSave1;
                Globalv.cheatsonoroff = Properties.Settings.Default.cheatsonSave1;

                //The Main page Inc Price Rates

                Globalv.incpricePotatopot = Properties.Settings.Default.incpricePotatopotSave1;
                Globalv.incpriceSmallfarm = Properties.Settings.Default.incpriceSmallfarmSave1;
                Globalv.incpriceGreenhouse = Properties.Settings.Default.incpriceGreenhouseSave1;
                Globalv.incpriceFarm = Properties.Settings.Default.incpriceFarmSave1;
                Globalv.incpriceBoxo = Properties.Settings.Default.incpriceBoxoSave1;
                Globalv.incpriceSacko = Properties.Settings.Default.incpriceSackoSave1;

                Globalv.incpricePotatocrate = Properties.Settings.Default.incpricePotatocrateSave1;
                Globalv.incpriceShippingboat = Properties.Settings.Default.incpriceShippingboatSave1;
                Globalv.incpriceHandpotatocutter = Properties.Settings.Default.incpriceHandpotatocutterSave1;
                Globalv.incpriceDeepfryer = Properties.Settings.Default.incpriceDeepfryerSave1;
                Globalv.incpriceOvenfries = Properties.Settings.Default.incpriceOvenfriesSave1;
                Globalv.incpriceSmallfries = Properties.Settings.Default.incpriceSmallfriesSave1;

                Globalv.incpriceFrenchFri = Properties.Settings.Default.incpriceFrenchFriSave1;
                Globalv.incpricebagofries = Properties.Settings.Default.incpricebagofriesSave1;
                Globalv.incpricelargedeepfryer = Properties.Settings.Default.incpricelargedeepfryerSave1;
                Globalv.incpricebarrelofries = Properties.Settings.Default.incpricebarrelofriesSave1;
                Globalv.incpriceThefritruck = Properties.Settings.Default.incpriceThefritruckSave1;
                Globalv.incpricefrenchfriplane = Properties.Settings.Default.incpricefrenchfriplaneSave1;

                Globalv.incpriceGiantpotatosilo = Properties.Settings.Default.incpriceGiantpotatosiloSave1;
                Globalv.incpricePotatoblimp = Properties.Settings.Default.incpricePotatoblimpSave1;
                Globalv.incpricePotatofactory = Properties.Settings.Default.incpricePotatofactorySave1;
                Globalv.incpriceFrenchfriStand = Properties.Settings.Default.incpriceFrenchfriStandSave1;
                Globalv.incpriceFrenchfritrain = Properties.Settings.Default.incpriceFrenchfritrainSave1;
                Globalv.incpriceFrenchfriknife = Properties.Settings.Default.incpriceFrenchfriknifeSave1;

                //amt of the stuff on main page

                Globalv.amtPotatopot = Properties.Settings.Default.amtPotatopotSave1;
                Globalv.amtSmallfarm = Properties.Settings.Default.amtSmallfarmSave1;
                Globalv.amtGreenhouse = Properties.Settings.Default.amtGreenhouseSave1;
                Globalv.amtFarm = Properties.Settings.Default.amtFarmSave1;
                Globalv.amtBoxpotato = Properties.Settings.Default.amtBoxpotatoSave1;
                Globalv.amtSackopotato = Properties.Settings.Default.amtSackopotatoSave1;

                Globalv.amtPotatocrate = Properties.Settings.Default.amtPotatocrateSave1;
                Globalv.amtPotatoshippingcrate = Properties.Settings.Default.amtPotatoshippingcrateSave1;
                Globalv.amtHandPotatocutter = Properties.Settings.Default.amtHandPotatocutterSave1;
                Globalv.amtDeepfryer = Properties.Settings.Default.amtDeepfryerSave1;
                Globalv.amtOvenfries = Properties.Settings.Default.amtOvenfriesSave1;
                Globalv.amtSmallfries = Properties.Settings.Default.amtSmallfriesSave1;

                Globalv.amtFrenchFri = Properties.Settings.Default.amtFrenchFriSave1;
                Globalv.amtbagofries = Properties.Settings.Default.amtbagofriesSave1;
                Globalv.amtlargedeepfryer = Properties.Settings.Default.amtlargedeepfryerSave1;
                Globalv.amtbarrelofries = Properties.Settings.Default.amtbarrelofriesSave1;
                Globalv.amtThefritruck = Properties.Settings.Default.amtThefritruckSave1;
                Globalv.amtfrenchfriplane = Properties.Settings.Default.amtfrenchfriplaneSave1;

                Globalv.amtGiantpotatosilo = Properties.Settings.Default.amtGiantpotatosiloSave1;
                Globalv.amtPotatoblimp = Properties.Settings.Default.amtPotatoblimpSave1;
                Globalv.amtPotatofactory = Properties.Settings.Default.amtPotatofactorySave1;
                Globalv.amtFrenchfriStand = Properties.Settings.Default.amtFrenchfriStandSave1;
                Globalv.amtFrenchfritrain = Properties.Settings.Default.amtFrenchfritrainSave1;
                Globalv.amtFrenchfriknife = Properties.Settings.Default.amtFrenchfriknifeSave1;

                //the saves for the fri applies to the fps items only 

                Globalv.friFarm = Properties.Settings.Default.friFarmSave1;
                Globalv.friBoxopotato = Properties.Settings.Default.friBoxopotatoSave1;
                Globalv.friSackopotato = Properties.Settings.Default.friSackopotatoSave1;

                Globalv.friPotatocrate = Properties.Settings.Default.friPotatocrateSave1;
                Globalv.friPotatoshippingboat = Properties.Settings.Default.friPotatoshippingboatSave1;
                Globalv.friHandpotatocutter = Properties.Settings.Default.friHandpotatocutterSave1;
                Globalv.friDeepfryer = Properties.Settings.Default.friDeepfryerSave1;
                Globalv.friOvenfries = Properties.Settings.Default.friOvenfriesSave1;
                Globalv.friSmallfries = Properties.Settings.Default.friSmallfriesSave1;

                Globalv.friFrenchFri = Properties.Settings.Default.friFrenchFriSave1;
                Globalv.fribagofries = Properties.Settings.Default.fribagofriesSave1;
                Globalv.frilargedeepfryer = Properties.Settings.Default.frilargedeepfryerSave1;
                Globalv.fribagofries = Properties.Settings.Default.fribarrelofriesSave1;
                Globalv.friThefritruck = Properties.Settings.Default.friThefritruckSave1;
                Globalv.frifrenchfriplane = Properties.Settings.Default.frifrenchfriplaneSave1;

                Globalv.friGiantpotatosilo = Properties.Settings.Default.friGiantpotatosiloSave1;
                Globalv.friGiantpotatosilo = Properties.Settings.Default.friPotatoblimpSave1;
                Globalv.friPotatofactory = Properties.Settings.Default.friPotatofactorySave1;
                Globalv.friFrenchfriStand = Properties.Settings.Default.friFrenchfriStandSave1;
                Globalv.friFrenchfritrain = Properties.Settings.Default.friFrenchfritrainSave1;
                Globalv.friFrenchfriknife = Properties.Settings.Default.friFrenchfriknifeSave1;

                //the price of the items on the main page

                Globalv.pricePotatopot = Properties.Settings.Default.pricePotatopotSave1;
                Globalv.priceSmallfarm = Properties.Settings.Default.priceSmallfarmSave1;
                Globalv.priceGreenhouse = Properties.Settings.Default.priceGreenhouseSave1;
                Globalv.priceFarm = Properties.Settings.Default.priceFarmSave1;
                Globalv.priceBoxopotato = Properties.Settings.Default.priceBoxopotatoSave1;
                Globalv.priceSackopotato = Properties.Settings.Default.priceSackopotatoSave1;

                Globalv.pricePotatocrate = Properties.Settings.Default.pricePotatocrateSave1;
                Globalv.pricePotatoshippingboat = Properties.Settings.Default.pricePotatoshippingboatSave1;
                Globalv.pricehandpotatocutter = Properties.Settings.Default.pricehandpotatocutterSave1;
                Globalv.pricedeepfryer = Properties.Settings.Default.pricedeepfryerSave1;
                Globalv.priceovenfries = Properties.Settings.Default.priceovenfriesSave1;
                Globalv.pricesmallfries = Properties.Settings.Default.pricesmallfriesSave1;

                Globalv.priceFrenchfries = Properties.Settings.Default.priceFrenchfriesSave1;
                Globalv.priceBagofries = Properties.Settings.Default.priceBagofriesSave1;
                Globalv.priceLargedeepfryer = Properties.Settings.Default.priceLargedeepfryerSave1;
                Globalv.priceBarrelofries = Properties.Settings.Default.priceBarrelofriesSave1;
                Globalv.priceThefritruck = Properties.Settings.Default.priceThefritruckSave1;
                Globalv.priceFrenchfriplane = Properties.Settings.Default.priceFrenchfriplaneSave1;

                Globalv.priceGiantpotatosilo = Properties.Settings.Default.priceGiantpotatosiloSave1;
                Globalv.pricePotatoblimp = Properties.Settings.Default.pricePotatoblimpSave1;
                Globalv.pricePotatofactory = Properties.Settings.Default.pricePotatofactorySave1;
                Globalv.priceFrenchfriStand = Properties.Settings.Default.priceFrenchfriStandSave1;
                Globalv.priceFrenchfritrain = Properties.Settings.Default.priceFrenchfritrainSave1;
                Globalv.priceFrenchfriknife = Properties.Settings.Default.priceFrenchfriknifeSave1;


                //amt for the clickers 

                Globalv.amtBasicclicker = Properties.Settings.Default.amtBasicclickerSave1;
                Globalv.amtPotatoclicker = Properties.Settings.Default.amtPotatoclickerSave1;
                Globalv.amtPotatohelper = Properties.Settings.Default.amtPotatohelperSave1;
                Globalv.amtDellmouse = Properties.Settings.Default.amtDellmouseSave1;

                Globalv.amtRazermouse = Properties.Settings.Default.amtRazermouseSave1;
                Globalv.amt15Dollarmouse = Properties.Settings.Default.amt15DollarmouseSave1;
                Globalv.amtPotatoMouse = Properties.Settings.Default.amtPotatoMouseSave1;
                Globalv.amtSparehand = Properties.Settings.Default.amtSparehandSave1;

                Globalv.amtBronzehand = Properties.Settings.Default.amtBronzehandSave1;
                Globalv.amtSilverhand = Properties.Settings.Default.amtSilverhandSave1;
                Globalv.amtGoldhand = Properties.Settings.Default.amtGoldhandSave1;
                Globalv.amtPlatinumhand = Properties.Settings.Default.amtPlatinumhandSave1;

                Globalv.amtAmythysthand = Properties.Settings.Default.amtAmythysthandSave1;
                Globalv.amtTopazhand = Properties.Settings.Default.amtTopazhandSave1;
                Globalv.amtRubyhand = Properties.Settings.Default.amtRubyhandSave1;
                Globalv.amtSapphirehand = Properties.Settings.Default.amtSapphirehandSave1;

                //Prices of the Clicker on the First page of the FPC memu

                Globalv.priceofBasicclicker = Properties.Settings.Default.priceofBasicclickerSave1;
                Globalv.priceofPotatoclciker = Properties.Settings.Default.priceofPotatoclcikerSave1;
                Globalv.priceofPotatohelper = Properties.Settings.Default.priceofPotatohelperSave1;
                Globalv.priceofDellmouse = Properties.Settings.Default.priceofDellmouseSave1;

                Globalv.priceofRazermouse = Properties.Settings.Default.priceofRazermouseSave1;
                Globalv.priceof15Dollarmouse = Properties.Settings.Default.priceof15DollarmouseSave1;
                Globalv.priceofPotatoMouse = Properties.Settings.Default.priceofPotatoMouseSave1;
                Globalv.priceofSparehand = Properties.Settings.Default.priceofSparehandSave1;

                Globalv.priceofBronzehand = Properties.Settings.Default.priceofBronzehandSave1;
                Globalv.priceofSilverhand = Properties.Settings.Default.priceofSilverhandSave1;
                Globalv.priceofGoldhand = Properties.Settings.Default.priceofGoldhandSave1;
                Globalv.priceofPlatinumhand = Properties.Settings.Default.priceofPlatinumhandSave1;

                Globalv.priceofAmythysthand = Properties.Settings.Default.priceofAmythysthandSave1;
                Globalv.priceofTopazhand = Properties.Settings.Default.priceofTopazhandSave1;
                Globalv.priceofRubyhand = Properties.Settings.Default.priceofRubyhandSave1;
                Globalv.priceofSapphirehand = Properties.Settings.Default.priceofSapphirehandSave1;


                //Inc price for the clickers 

                Globalv.incBasicclicker = Properties.Settings.Default.incBasicclickerSave1;
                Globalv.incPotatoclicker = Properties.Settings.Default.incPotatoclickerSave1;
                Globalv.incPotatohelper = Properties.Settings.Default.incPotatohelperSave1;
                Globalv.incDellmouse = Properties.Settings.Default.incDellmouseSave1;

                Globalv.incRazermouse = Properties.Settings.Default.incRazermouseSave1;
                Globalv.inc15Dollarmouse = Properties.Settings.Default.inc15DollarmouseSave1;
                Globalv.incPotatoMouse = Properties.Settings.Default.incPotatoMouseSave1;
                Globalv.incSparehand = Properties.Settings.Default.incSparehandSave1;

                Globalv.incBronzehand = Properties.Settings.Default.incBronzehandSave1;
                Globalv.incSilverhand = Properties.Settings.Default.incSilverhandSave1;
                Globalv.incGoldhand = Properties.Settings.Default.incGoldhandSave1;
                Globalv.incPlatinumhand = Properties.Settings.Default.incPlatinumhandSave1;

                Globalv.incAmythysthand = Properties.Settings.Default.incAmythysthandSave1;
                Globalv.incTopazhand = Properties.Settings.Default.incTopazhandSave1;
                Globalv.incRubyhand = Properties.Settings.Default.incRubyhandSave1;
                Globalv.incSapphirehand = Properties.Settings.Default.incSapphirehandSave1;

                Globalv.justloadsave = 1;
            }
            else
            {
                MessageBox.Show("No Save Found");
            }
        }

        private void button_save1Wipe_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.friSave1 = 0;
            Properties.Settings.Default.fpsSave1 = 0;
            Properties.Settings.Default.fpcSave1 = 1;
            Properties.Settings.Default.cheatsonSave1 = 0;

            //The Main page Inc Price Rates

            Properties.Settings.Default.incpricePotatopotSave1 = 0;
            Properties.Settings.Default.incpriceSmallfarmSave1 = 0;
            Properties.Settings.Default.incpriceGreenhouseSave1 = 0;
            Properties.Settings.Default.incpriceFarmSave1 = 0;
            Properties.Settings.Default.incpriceBoxoSave1 = 0;
            Properties.Settings.Default.incpriceSackoSave1 = 0;

            Properties.Settings.Default.incpricePotatocrateSave1 = 0;
            Properties.Settings.Default.incpriceShippingboatSave1 = 0;
            Properties.Settings.Default.incpriceHandpotatocutterSave1 = 0;
            Properties.Settings.Default.incpriceDeepfryerSave1 = 0;
            Properties.Settings.Default.incpriceOvenfriesSave1 = 0;
            Properties.Settings.Default.incpriceSmallfriesSave1 = 0;

            Properties.Settings.Default.incpriceFrenchFriSave1 = 0;
            Properties.Settings.Default.incpricebagofriesSave1 = 0;
            Properties.Settings.Default.incpricelargedeepfryerSave1 = 0;
            Properties.Settings.Default.incpricebarrelofriesSave1 = 0;
            Properties.Settings.Default.incpriceThefritruckSave1 = 0;
            Properties.Settings.Default.incpricefrenchfriplaneSave1 = 0;

            Properties.Settings.Default.incpriceGiantpotatosiloSave1 = 0;
            Properties.Settings.Default.incpricePotatoblimpSave1 = 0;
            Properties.Settings.Default.incpricePotatofactorySave1 = 0;
            Properties.Settings.Default.incpriceFrenchfriStandSave1 = 0;
            Properties.Settings.Default.incpriceFrenchfritrainSave1 = 0;
            Properties.Settings.Default.incpriceFrenchfriknifeSave1 = 0;

            //amt of the stuff on main page

            Properties.Settings.Default.amtPotatopotSave1 = 0;
            Properties.Settings.Default.amtSmallfarmSave1 = 0;
            Properties.Settings.Default.amtGreenhouseSave1 = 0;
            Properties.Settings.Default.amtFarmSave1 = 0;
            Properties.Settings.Default.amtBoxpotatoSave1 = 0;
            Properties.Settings.Default.amtSackopotatoSave1 = 0;

            Properties.Settings.Default.amtPotatocrateSave1 = 0;
            Properties.Settings.Default.amtPotatoshippingcrateSave1 = 0;
            Properties.Settings.Default.amtHandPotatocutterSave1 = 0;
            Properties.Settings.Default.amtDeepfryerSave1 = 0;
            Properties.Settings.Default.amtOvenfriesSave1 = 0;
            Properties.Settings.Default.amtSmallfriesSave1 = 0;

            Properties.Settings.Default.amtFrenchFriSave1 = 0;
            Properties.Settings.Default.amtbagofriesSave1 = 0;
            Properties.Settings.Default.amtlargedeepfryerSave1 = 0;
            Properties.Settings.Default.amtbarrelofriesSave1 = 0;
            Properties.Settings.Default.amtThefritruckSave1 = 0;
            Properties.Settings.Default.amtfrenchfriplaneSave1 = 0;

            Properties.Settings.Default.amtGiantpotatosiloSave1 = 0;
            Properties.Settings.Default.amtPotatoblimpSave1 = 0;
            Properties.Settings.Default.amtPotatofactorySave1 = 0;
            Properties.Settings.Default.amtFrenchfriStandSave1 = 0;
            Properties.Settings.Default.amtFrenchfritrainSave1 = 0;
            Properties.Settings.Default.amtFrenchfriknifeSave1 = 0;

            //the saves for the fri applies to the fps items only 

            Properties.Settings.Default.friFarmSave1 = 0;
            Properties.Settings.Default.friBoxopotatoSave1 = 0;
            Properties.Settings.Default.friSackopotatoSave1 = 0;

            Properties.Settings.Default.friPotatocrateSave1 = 0;
            Properties.Settings.Default.friPotatoshippingboatSave1 = 0;
            Properties.Settings.Default.friHandpotatocutterSave1 = 0;
            Properties.Settings.Default.friDeepfryerSave1 = 0;
            Properties.Settings.Default.friOvenfriesSave1 = 0;
            Properties.Settings.Default.friSmallfriesSave1 = 0;

            Properties.Settings.Default.friFrenchFriSave1 = 0;
            Properties.Settings.Default.fribagofriesSave1 = 0;
            Properties.Settings.Default.frilargedeepfryerSave1 = 0;
            Properties.Settings.Default.fribarrelofriesSave1 = 0;
            Properties.Settings.Default.friThefritruckSave1 = 0;
            Properties.Settings.Default.frifrenchfriplaneSave1 = 0;

            Properties.Settings.Default.friGiantpotatosiloSave1 = 0;
            Properties.Settings.Default.friPotatoblimpSave1 = 0;
            Properties.Settings.Default.friPotatofactorySave1 = 0;
            Properties.Settings.Default.friFrenchfriStandSave1 = 0;
            Properties.Settings.Default.friFrenchfritrainSave1 = 0;
            Properties.Settings.Default.friFrenchfriknifeSave1 = 0;

            //the price of the items on the main page

            Properties.Settings.Default.pricePotatopotSave1 = 0;
            Properties.Settings.Default.priceSmallfarmSave1 = 0;
            Properties.Settings.Default.priceGreenhouseSave1 = 0;
            Properties.Settings.Default.priceFarmSave1 = 0;
            Properties.Settings.Default.priceBoxopotatoSave1 = 0;
            Properties.Settings.Default.priceSackopotatoSave1 = 0;

            Properties.Settings.Default.pricePotatocrateSave1 = 0;
            Properties.Settings.Default.pricePotatoshippingboatSave1 = 0;
            Properties.Settings.Default.pricehandpotatocutterSave1 = 0;
            Properties.Settings.Default.pricedeepfryerSave1 = 0;
            Properties.Settings.Default.priceovenfriesSave1 = 0;
            Properties.Settings.Default.pricesmallfriesSave1 = 0;

            Properties.Settings.Default.priceFrenchfriesSave1 = 0;
            Properties.Settings.Default.priceBagofriesSave1 = 0;
            Properties.Settings.Default.priceLargedeepfryerSave1 = 0;
            Properties.Settings.Default.priceBarrelofriesSave1 = 0;
            Properties.Settings.Default.priceThefritruckSave1 = 0;
            Properties.Settings.Default.priceFrenchfriplaneSave1 = 0;

            Properties.Settings.Default.priceGiantpotatosiloSave1 = 0;
            Properties.Settings.Default.pricePotatoblimpSave1 = 0;
            Properties.Settings.Default.pricePotatofactorySave1 = 0;
            Properties.Settings.Default.priceFrenchfriStandSave1 = 0;
            Properties.Settings.Default.priceFrenchfritrainSave1 = 0;
            Properties.Settings.Default.priceFrenchfriknifeSave1 = 0;


            //amt for the clickers 

            Properties.Settings.Default.amtBasicclickerSave1 = 0;
            Properties.Settings.Default.amtPotatoclickerSave1 = 0;
            Properties.Settings.Default.amtPotatohelperSave1 = 0;
            Properties.Settings.Default.amtDellmouseSave1 = 0;

            Properties.Settings.Default.amtRazermouseSave1 = 0;
            Properties.Settings.Default.amt15DollarmouseSave1 = 0;
            Properties.Settings.Default.amtPotatoMouseSave1 = 0;
            Properties.Settings.Default.amtSparehandSave1 = 0;

            Properties.Settings.Default.amtBronzehandSave1 = 0;
            Properties.Settings.Default.amtSilverhandSave1 = 0;
            Properties.Settings.Default.amtGoldhandSave1 = 0;
            Properties.Settings.Default.amtPlatinumhandSave1 = 0;

            Properties.Settings.Default.amtAmythysthandSave1 = 0;
            Properties.Settings.Default.amtTopazhandSave1 = 0;
            Properties.Settings.Default.amtRubyhandSave1 = 0;
            Properties.Settings.Default.amtSapphirehandSave1 = 0;

            //Prices of the Clicker on the First page of the FPC memu

            Properties.Settings.Default.priceofBasicclickerSave1 = 0;
            Properties.Settings.Default.priceofPotatoclcikerSave1 = 0;
            Properties.Settings.Default.priceofPotatohelperSave1 = 0;
            Properties.Settings.Default.priceofDellmouseSave1 = 0;

            Properties.Settings.Default.priceofRazermouseSave1 = 0;
            Properties.Settings.Default.priceof15DollarmouseSave1 = 0;
            Properties.Settings.Default.priceofPotatoMouseSave1 = 0;
            Properties.Settings.Default.priceofSparehandSave1 = 0;

            Properties.Settings.Default.priceofBronzehandSave1 = 0;
            Properties.Settings.Default.priceofSilverhandSave1 = 0;
            Properties.Settings.Default.priceofGoldhandSave1 = 0;
            Properties.Settings.Default.priceofPlatinumhandSave1 = 0;

            Properties.Settings.Default.priceofAmythysthandSave1 = 0;
            Properties.Settings.Default.priceofTopazhandSave1 = 0;
            Properties.Settings.Default.priceofRubyhandSave1 = 0;
            Properties.Settings.Default.priceofSapphirehandSave1 = 0;


            //Inc price for the clickers 

            Properties.Settings.Default.incBasicclickerSave1 = 0;
            Properties.Settings.Default.incPotatoclickerSave1 = 0;
            Properties.Settings.Default.incPotatohelperSave1 = 0;
            Properties.Settings.Default.incDellmouseSave1 = 0;

            Properties.Settings.Default.incRazermouseSave1 = 0;
            Properties.Settings.Default.inc15DollarmouseSave1 = 0;
            Properties.Settings.Default.incPotatoMouseSave1 = 0;
            Properties.Settings.Default.incSparehandSave1 = 0;

            Properties.Settings.Default.incBronzehandSave1 = 0;
            Properties.Settings.Default.incSilverhandSave1 = 0;
            Properties.Settings.Default.incGoldhandSave1 = 0;
            Properties.Settings.Default.incPlatinumhandSave1 = 0;

            Properties.Settings.Default.incAmythysthandSave1 = 0;
            Properties.Settings.Default.incTopazhandSave1 = 0;
            Properties.Settings.Default.incRubyhandSave1 = 0;
            Properties.Settings.Default.incSapphirehandSave1 = 0;

            Properties.Settings.Default.Lasttime = ("No Save");
            Properties.Settings.Default.saveornoSave1 = 0;
            label_lastsave.Text = Properties.Settings.Default.Lasttime.ToString();
        }

        private void button_unload_Click(object sender, EventArgs e)
        {
            Globalv.fri = 0;
            Globalv.FPS = 0;
            Globalv.FPC = 1;
            Globalv.cheatsonoroff = 0;

            //The Main page Inc Price Rates

            Globalv.incpricePotatopot = 15;
            Globalv.incpriceSmallfarm = 30;
            Globalv.incpriceGreenhouse = 60;
            Globalv.incpriceFarm = 150;
            Globalv.incpriceBoxo = 375;
            Globalv.incpriceSacko = 3000;

            Globalv.incpricePotatocrate = 15000;
            Globalv.incpriceShippingboat = 37500;
            Globalv.incpriceHandpotatocutter = 75000;
            Globalv.incpriceDeepfryer = 150000;
            Globalv.incpriceOvenfries = 240000;
            Globalv.incpriceSmallfries = 360000;

            Globalv.incpriceFrenchFri = 750000;
            Globalv.incpricebagofries = 1800000;
            Globalv.incpricelargedeepfryer = 4500000;
            Globalv.incpricebarrelofries = 7500000;
            Globalv.incpriceThefritruck = 12000000;
            Globalv.incpricefrenchfriplane = 24000000;

            Globalv.incpriceGiantpotatosilo = 37500000;
            Globalv.incpricePotatoblimp = 52500000;
            Globalv.incpricePotatofactory = 75000000;
            Globalv.incpriceFrenchfriStand = 150000000;
            Globalv.incpriceFrenchfritrain = 300000000;
            Globalv.incpriceFrenchfriknife = 375000000;

            //amt of the stuff on main page

            Globalv.amtPotatopot = 0;
            Globalv.amtSmallfarm = 0;
            Globalv.amtGreenhouse = 0;
            Globalv.amtFarm = 0;
            Globalv.amtBoxpotato = 0;
            Globalv.amtSackopotato = 0;

            Globalv.amtPotatocrate = 0;
            Globalv.amtPotatoshippingcrate = 0;
            Globalv.amtHandPotatocutter = 0;
            Globalv.amtDeepfryer = 0;
            Globalv.amtOvenfries = 0;
            Globalv.amtSmallfries = 0;

            Globalv.amtFrenchFri = 0;
            Globalv.amtbagofries = 0;
            Globalv.amtlargedeepfryer = 0;
            Globalv.amtbarrelofries = 0;
            Globalv.amtThefritruck = 0;
            Globalv.amtfrenchfriplane = 0;

            Globalv.amtGiantpotatosilo = 0;
            Globalv.amtPotatoblimp = 0;
            Globalv.amtPotatofactory = 0;
            Globalv.amtFrenchfriStand = 0;
            Globalv.amtFrenchfritrain = 0;
            Globalv.amtFrenchfriknife = 0;

            //the saves for the fri applies to the fps items only 

            Globalv.friFarm = 0;
            Globalv.friBoxopotato = 0;
            Globalv.friSackopotato = 0;

            Globalv.friPotatocrate = 0;
            Globalv.friPotatoshippingboat = 0;
            Globalv.friHandpotatocutter = 0;
            Globalv.friDeepfryer = 0;
            Globalv.friOvenfries = 0;
            Globalv.friSmallfries = 0;

            Globalv.friFrenchFri = 0;
            Globalv.fribagofries = 0;
            Globalv.frilargedeepfryer = 0;
            Globalv.fribagofries = 0;
            Globalv.friThefritruck = 0;
            Globalv.frifrenchfriplane = 0;

            Globalv.friGiantpotatosilo = 0;
            Globalv.friGiantpotatosilo = 0;
            Globalv.friPotatofactory = 0;
            Globalv.friFrenchfriStand = 0;
            Globalv.friFrenchfritrain = 0;
            Globalv.friFrenchfriknife = 0;

            //the price of the items on the main page

            Globalv.pricePotatopot = 50;
            Globalv.priceSmallfarm = 100;
            Globalv.priceGreenhouse = 200;
            Globalv.priceFarm = 500;
            Globalv.priceBoxopotato = 1250;
            Globalv.priceSackopotato = 10000;

            Globalv.pricePotatocrate = 50000;
            Globalv.pricePotatoshippingboat = 125000;
            Globalv.pricehandpotatocutter = 250000;
            Globalv.pricedeepfryer = 500000;
            Globalv.priceovenfries = 800000;
            Globalv.pricesmallfries = 1200000;

            Globalv.priceFrenchfries = 2500000;
            Globalv.priceBagofries = 6000000;
            Globalv.priceLargedeepfryer = 15000000;
            Globalv.priceBarrelofries = 25000000;
            Globalv.priceThefritruck = 40000000;
            Globalv.priceFrenchfriplane = 80000000;

            Globalv.priceGiantpotatosilo = 125000000;
            Globalv.pricePotatoblimp = 175000000;
            Globalv.pricePotatofactory = 250000000;
            Globalv.priceFrenchfriStand = 500000000;
            Globalv.priceFrenchfritrain = 1000000000;
            Globalv.priceFrenchfriknife = 1250000000;


            //amt for the clickers 

            Globalv.amtBasicclicker = 0;
            Globalv.amtPotatoclicker = 0;
            Globalv.amtPotatohelper = 0;
            Globalv.amtDellmouse = 0;

            Globalv.amtRazermouse = 0;
            Globalv.amt15Dollarmouse = 0;
            Globalv.amtPotatoMouse = 0;
            Globalv.amtSparehand = 0;

            Globalv.amtBronzehand = 0;
            Globalv.amtSilverhand = 0;
            Globalv.amtGoldhand = 0;
            Globalv.amtPlatinumhand = 0;

            Globalv.amtAmythysthand = 0;
            Globalv.amtTopazhand = 0;
            Globalv.amtRubyhand = 0;
            Globalv.amtSapphirehand = 0;

            //Prices of the Clicker on the First page of the FPC memu

            Globalv.priceofBasicclicker = 125;
            Globalv.priceofPotatoclciker = 800;
            Globalv.priceofPotatohelper = 4000;
            Globalv.priceofDellmouse = 10000;

            Globalv.priceofRazermouse = 30000;
            Globalv.priceof15Dollarmouse = 120000;
            Globalv.priceofPotatoMouse = 400000;
            Globalv.priceofSparehand = 1800000;

            Globalv.priceofBronzehand = 12000000;
            Globalv.priceofSilverhand = 27500000;
            Globalv.priceofGoldhand = 70000000;
            Globalv.priceofPlatinumhand = 125000000;

            Globalv.priceofAmythysthand = 200000000;
            Globalv.priceofTopazhand = 300000000;
            Globalv.priceofRubyhand = 700000000;
            Globalv.priceofSapphirehand = 1400000000;


            //Inc price for the clickers 

            Globalv.incBasicclicker = 38;
            Globalv.incPotatoclicker = 240;
            Globalv.incPotatohelper = 1200;
            Globalv.incDellmouse = 3000;

            Globalv.incRazermouse = 9000;
            Globalv.inc15Dollarmouse = 36000;
            Globalv.incPotatoMouse = 120000;
            Globalv.incSparehand = 540000;

            Globalv.incBronzehand = 3600000;
            Globalv.incSilverhand = 8250000;
            Globalv.incGoldhand = 21000000;
            Globalv.incPlatinumhand = 37500000;

            Globalv.incAmythysthand = 60000000;
            Globalv.incTopazhand = 90000000;
            Globalv.incRubyhand = 210000000;
            Globalv.incSapphirehand = 420000000;

            Globalv.justloadsave = 1;
        }
        }
    }
