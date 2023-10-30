namespace WoodLand
{
    public class Money
    {
        public static void NumerosMoney()
        {
            if (v.money >= 1000000000000000000)
            {
                v.moneyfront = v.money / 1000000000000000000;
                v.m = "Qt";
            }

            else if (v.money >= 1000000000000000)
            {
                v.moneyfront = v.money / 1000000000000000;
                v.m = "Qd";
            }

            else if (v.money >= 1000000000000)
            {
                v.moneyfront = v.money / 1000000000000;
                v.m = "T ";
            }

            else if (v.money >= 1000000000)
            {
                v.moneyfront = v.money / 1000000000;
                v.m = "B ";
            }

            else if (v.money >= 1000000)
            {
                v.moneyfront = v.money / 1000000;
                v.m = "M ";
            }

            else if (v.money >= 1000)
            {
                v.moneyfront = v.money / 1000;
                v.m = "K ";
            }

            else
            {
                v.m = "  ";
                v.moneyfront = v.money;
            }

        }
    }
}
