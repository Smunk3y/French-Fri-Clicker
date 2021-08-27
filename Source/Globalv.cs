using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace French_Fri_Clicker
{
    public class Globalv
    {
       public static long fri = 0;
       public static long FPS = 0;
       public static long FPC = 1;
       public static long CheatFPS = 0;
       public static long autoclickeropens = 0;
       public static long cheatsonoroff = 0;
       public static long notenoughcount = 0;
       public static long cheatfps = 0;
       public static long cheatfpson = 0;
       public static long cheattoggleopen = 0;
       public static string lastsave = ("No Save");
       public static long justloadsave = 0;
       public static long upgradesbought = 0;
       public static long upgrademenu = 1;

        //Stocks
        public static long stockrefersh = 0;
        public static long timersecs = 60;
        public static long Stockbuyvarvar = 1;
        public static long Stockbuyvar = 1;
        public static string stockamtbuy = "0";

        //timer values
        public static long timerpotatopotfps = 40;
        public static long timersmalllfarm = 40;


        //Purchases for the power ups
        public static long powerpotatopotfps = 0;
        public static long powerpotatopotperc = 0;
        public static long powerSmallfarmfps = 0;
        public static long powerSmallfarmperc = 0;
        public static long powerGreenhousefps = 0;
        public static long powerGreenhouseperc = 0;
        public static long powerfarmfps = 0;
        public static long powerfarmperc = 0;
        public static long powerBoxOPotatosfps = 0;
        public static long powerBoxOPotatosperc = 0;
        public static long powerSackOPotatosfps = 0;
        public static long powerSackOPotatoperc = 0;
        public static long powerPotatoCratefps = 0;
        public static long powerPotatoCrateperc = 0;
        public static long powerPotatoShippingboatfps = 0;
        public static long powerPotatoShippingboatperc = 0;

        //price for the power ups
        public static long powerpricepotatopotfps = 400;
        public static long powerpricepotatopotperc = 1200;
        public static long powerpriceSmallfarmfps = 2000;
        public static long powerpriceSmallfarmperc = 3600;
        public static long powerpriceGreenhousefps = 5000;
        public static long powerpriceGreenhouseperc = 7000;
        public static long powerpricefarmfps = 5000;
        public static long powerpricefarmperc = 7000;
        public static long powerpriceBoxOPotatosfps = 22000;
        public static long powerpriceBoxOPotatosperc = 27500;
        public static long powerpriceSackOFps = 50000;
        public static long powerpriceSackOperc = 65000;
        public static long powerpricePotatoCratefps = 125000;
        public static long powerpricePotatoCrateperc = 160000;
        public static long powerpricePotatoShipfps = 400000;
        public static long powerpricePotatoShipperc = 700000;

        //fps adds
        public static long fpsPotatopot = 1;
        public static long fpssmallfarm = 2;
        public static long fpsgreenhouse = 5;
        public static long fpsfarm = 6;
        public static long fpsBoxOPotatos = 15;
        public static long fpsSackOPotatos = 50;
        public static long fpsPotatoCrate = 30;
        public static long fpsPotatoShippingCrate = 500;

        //price increase rates
        //all 30% might change
        public static long incpricePotatopot = 15;
        public static long incpriceSmallfarm = 30;
        public static long incpriceGreenhouse = 60;
        public static long incpriceFarm = 150;
        public static long incpriceBoxo = 375;
        public static long incpriceSacko = 3000;
        public static long incpricePotatocrate = 15000;
        public static long incpriceShippingboat = 37500;
        public static long incpriceHandpotatocutter = 75000;
        public static long incpriceDeepfryer = 150000;
        public static long incpriceOvenfries = 240000;
        public static long incpriceSmallfries = 360000;
        public static long incpriceFrenchFri = 750000;
        public static long incpricebagofries = 1800000;
        public static long incpricelargedeepfryer = 4500000;
        public static long incpricebarrelofries = 7500000;
        public static long incpriceThefritruck = 12000000;
        public static long incpricefrenchfriplane = 24000000;
        public static long incpriceGiantpotatosilo = 37500000;
        public static long incpricePotatoblimp = 52500000;
        public static long incpricePotatofactory = 75000000;
        public static long incpriceFrenchfriStand = 150000000;
        public static long incpriceFrenchfritrain = 300000000;
        public static long incpriceFrenchfriknife = 375000000;

        //price increase rates for the double inc
        //all 20% might change
        public static long incincpricePotatopot = 10;
        public static long incincpriceSmallfarm = 20;
        public static long incincpriceGreenhouse = 40;
        public static long incincpriceFarm = 100;
        public static long incincpriceBoxo = 250;
        public static long incincpriceSacko = 2000;
        public static long incincpricePotatocrate = 10000;
        public static long incincpriceShippingboat = 25000;
        //public static long incpriceHandpotatocutter = 75000;
       // public static long incpriceDeepfryer = 150000;
       // public static long incpriceOvenfries = 240000;
      //  public static long incpriceSmallfries = 360000;
      //  public static long incpriceFrenchFri = 750000;
      //  public static long incpricebagofries = 1800000;
     //   public static long incpricelargedeepfryer = 4500000;
      ///  public static long incpricebarrelofries = 7500000;
      //  public static long incpriceThefritruck = 12000000;
      //  public static long incpricefrenchfriplane = 24000000;
      ///  public static long incpriceGiantpotatosilo = 37500000;
      //  public static long incpricePotatoblimp = 52500000;
      //  public static long incpricePotatofactory = 75000000;
      //  public static long incpriceFrenchfriStand = 150000000;
      //  public static long incpriceFrenchfritrain = 300000000;
      //  public static long incpriceFrenchfriknife = 375000000;

        //the auto ones that do it for yo
        public static long amtPotatopot = 0;
        public static long amtSmallfarm = 0;
        public static long amtGreenhouse = 0;
        public static long amtFarm = 0;
        public static long amtBoxpotato = 0;
        public static long amtSackopotato = 0;
        public static long amtPotatocrate = 0;
        public static long amtPotatoshippingcrate = 0;
        public static long amtHandPotatocutter = 0;
        public static long amtDeepfryer = 0;
        public static long amtOvenfries = 0;
        public static long amtSmallfries = 0;
        public static long amtFrenchFri = 0;
        public static long amtbagofries = 0;
        public static long amtlargedeepfryer = 0;
        public static long amtbarrelofries = 0;
        public static long amtThefritruck = 0;
        public static long amtfrenchfriplane = 0;
        public static long amtGiantpotatosilo = 0;
        public static long amtPotatoblimp = 0;
        public static long amtPotatofactory = 0;
        public static long amtFrenchfriStand = 0;
        public static long amtFrenchfritrain = 0;
        public static long amtFrenchfriknife = 0;


        //the adds for the big ones
        public static long frigreenhouse = 0;
        public static long friSmallfarm = 0;
        public static long friFarm = 0;
        public static long friBoxopotato = 0;
        public static long friSackopotato = 0;
        public static long friPotatocrate = 0;
        public static long friPotatoshippingboat = 0;
        public static long friHandpotatocutter = 0;
        public static long friDeepfryer = 0;
        public static long friOvenfries = 0;
        public static long friSmallfries = 0;
        public static long friFrenchFri = 0;
        public static long fribagofries = 0;
        public static long frilargedeepfryer = 0;
        public static long fribarrelofries = 0;
        public static long friThefritruck = 0;
        public static long frifrenchfriplane = 0;
        public static long friGiantpotatosilo = 0;
        public static long friPotatoblimp = 0;
        public static long friPotatofactory = 0;
        public static long friFrenchfriStand = 0;
        public static long friFrenchfritrain = 0;
        public static long friFrenchfriknife = 0;

        //prices
        public static long pricePotatopot = 50;
        public static long priceSmallfarm = 100;
        public static long priceGreenhouse = 200;
        public static long priceFarm = 500;
        public static long priceBoxopotato = 1250;
        public static long priceSackopotato = 10000;
        public static long pricePotatocrate = 50000;
        public static long pricePotatoshippingboat = 125000;
        public static long pricehandpotatocutter = 250000;
        public static long pricedeepfryer = 500000;
        public static long priceovenfries = 800000;
        public static long pricesmallfries = 1200000;
        public static long priceFrenchfries = 2500000;
        public static long priceBagofries = 6000000;
        public static long priceLargedeepfryer = 15000000;
        public static long priceBarrelofries = 25000000;
        public static long priceThefritruck = 40000000;
        public static long priceFrenchfriplane = 80000000;
        public static long priceGiantpotatosilo = 125000000;
        public static long pricePotatoblimp = 175000000;
        public static long pricePotatofactory = 250000000;
        public static long priceFrenchfriStand = 500000000;
        public static long priceFrenchfritrain = 1000000000;
        public static long priceFrenchfriknife = 1250000000;


        //Amt of the clicks
        public static long amtBasicclicker = 0;
        public static long amtPotatoclicker = 0;
        public static long amtPotatohelper = 0;
        public static long amtDellmouse = 0;
        public static long amtRazermouse = 0;
        public static long amt15Dollarmouse = 0;
        public static long amtPotatoMouse = 0;
        public static long amtSparehand = 0;
        public static long amtBronzehand = 0;
        public static long amtSilverhand = 0;
        public static long amtGoldhand = 0;
        public static long amtPlatinumhand = 0;
        public static long amtAmythysthand = 0;
        public static long amtTopazhand = 0;
        public static long amtRubyhand = 0;
        public static long amtSapphirehand = 0;

        //prices of the clickers
        public static long priceofBasicclicker = 125;
        public static long priceofPotatoclciker = 800;
        public static long priceofPotatohelper = 4000;
        public static long priceofDellmouse = 10000;
        public static long priceofRazermouse = 30000;
        public static long priceof15Dollarmouse = 120000;
        public static long priceofPotatoMouse = 400000;
        public static long priceofSparehand = 1800000;
        public static long priceofBronzehand = 12000000;
        public static long priceofSilverhand = 27500000;
        public static long priceofGoldhand = 70000000;
        public static long priceofPlatinumhand = 125000000;
        public static long priceofAmythysthand = 200000000;
        public static long priceofTopazhand = 300000000;
        public static long priceofRubyhand = 700000000;
        public static long priceofSapphirehand = 1400000000;

        //increase rates
        public static long incBasicclicker = 38;
        public static long incPotatoclicker = 240;
        public static long incPotatohelper = 1200;
        public static long incDellmouse = 3000;

        public static long incRazermouse = 9000;
        public static long inc15Dollarmouse = 36000;
        public static long incPotatoMouse = 120000;
        public static long incSparehand = 540000;

        public static long incBronzehand = 3600000;
        public static long incSilverhand = 8250000;
        public static long incGoldhand = 21000000;
        public static long incPlatinumhand = 37500000;

        public static long incAmythysthand = 60000000;
        public static long incTopazhand = 90000000;
        public static long incRubyhand = 210000000;
        public static long incSapphirehand = 420000000;




        
    }


   

}
