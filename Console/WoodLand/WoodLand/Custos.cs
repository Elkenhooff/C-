using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodLand
{
    public class Custos
    {
        public static string Valor(double x)
        {
            double xfront;
            if (x >= 1000000000000000000)
            {
                xfront = x / 1000000000000000000;
                return Math.Round(xfront, 2) + "Qt";
            }

            else if (x >= 1000000000000000)
            {
                xfront = x / 1000000000000000;
                return Math.Round(xfront, 2) + "Qd";
            }

            else if (x >= 1000000000000)
            {
                xfront = x / 1000000000000;
                return Math.Round(xfront, 2) + "T ";
            }

            else if (x >= 1000000000)
            {
                xfront = x / 1000000000;
                return Math.Round(xfront, 2) + "B ";
            }

            else if (x >= 1000000)
            {
                xfront = x / 1000000;
                return Math.Round(xfront, 2) + "M ";
            }

            else if (x >= 1000)
            {
                xfront = x / 1000;
                return Math.Round(xfront, 2) + "K ";
            }

            else
            {
                xfront = x;
                return Math.Round(xfront, 2) + " ";
            }
        }
    }
}