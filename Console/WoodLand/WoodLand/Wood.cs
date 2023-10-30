using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodLand
{
    public class Wood
    {
        public static void NumerosWood()
        {
            if (v.wood >= 1000000000000000000)
            {
                v.woodfront = v.wood / 1000000000000000000;
                v.l = "Qt";
            }

            else if (v.wood >= 1000000000000000)
            {
                v.woodfront = v.wood / 1000000000000000;
                v.l = "Qd";
            }

            else if (v.wood >= 1000000000000)
            {
                v.woodfront = v.wood / 1000000000000;
                v.l = "T ";
            }

            else if (v.wood >= 1000000000)
            {
                v.woodfront = v.wood / 1000000000;
                v.l = "B ";
            }

            else if (v.wood >= 1000000)
            {
                v.woodfront = v.wood / 1000000;
                v.l = "M ";
            }

            else if (v.wood >= 1000)
            {
                v.woodfront = v.wood / 1000;
                v.l = "K ";
            }

            else
            {
                v.l = "  ";
                v.woodfront = v.wood;
            }
        }
    }
}
