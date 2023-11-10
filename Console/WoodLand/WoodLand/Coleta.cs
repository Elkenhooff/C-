using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodLand
{
    public class Coleta
    {
        public static void ColetarMadeira()
        {
            if (v.upgwood[7] > 0)
            {
                v.wood += v.upgradewood;
                v.trees = v.trees;
            }
            else
            {
                v.wood += v.upgradewood;
                v.trees -= (int)(v.upgradewood - (v.upgradewood * v.upgwood[3] * 0.20));
            }
        }
    }
}
