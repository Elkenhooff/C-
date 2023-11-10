using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WoodLand
{
    public class v
    {
        public static object id;
        public static object senha;
        public static bool save = false;
        public static double wood = 10000;
        public static double woodfront = 0;
        public static double money = 100000000000000;
        public static double moneyfront = 0;
        public static int trees = 0;
        public static double prestige = 0;
        public static double ascension = 214522310;
        public static double descension = 0;
        public static string l = " ";
        public static string m = " ";
        public static double upgradeUm = 1;
        public static double custoUm = 500;
        public static double upgradeDois = 1;
        public static double custoDois = 10000;
        public static double upgradeTres = 1;
        public static double custoTres = 0;
        public static double upgradeQuatro = 1;
        public static double custoQuatro = 0;
        public static double upgradeCinco = 1;
        public static double custoCinco = 1000;
        public static double upgradeSeis = 1;
        public static double custoSeis = 5000;
        public static double upgradeSete = 1;
        public static double custoSete = 500;
        public static double upgradeOito = 1;
        public static double custoOito = 5000;
        public static int[] upgwood = new int[8];
        public static int[] upgplantil = new int[8];
        public static int[] upgprestige = new int[8];
        public static int[] upgascension = new int[8];
        public static int[] woodhop = new int[20];  
        public static int upgradeDPS = 0;
        public static int upgradeDPStree = 0;
        public static int upgradewood = 1;
        public static int upgradetrees = 0;
        
        public static void a()
        {
            upgradewood = (int)((1 + upgwood[0] * 3) * Math.Pow(2, upgwood[2]) * Math.Pow(10, upgwood[4]) * Math.Pow(100, upgwood[6]));
            upgradeDPS = (0 +  upgwood[1] * 10) * (int)Math.Pow(100, upgwood[5]);
            upgradetrees = 1 + (int)((upgplantil[0] * 3) + (upgplantil[1] * 5) + (upgplantil[2] * 15) * Math.Pow(10, upgplantil[4]) * Math.Pow(1000, upgplantil[6]));
            upgradeDPStree = (0 + upgplantil[3] * 5) * (int)Math.Pow(100, upgplantil[5]);
        }
    }
}
