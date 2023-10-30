using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WoodLand
{
    public class Upgrade
    {
        public static void Upgrades()
        {
            Console.Clear();
            while (true)
            {
                if (v.ascension > 0)
                {
                    Console.WriteLine("┌────────────────────────┐\r\n│        Upgrades        │\r\n│                        │\r\n│1 - Madeira             │\r\n│2 - Plantil             │\r\n│3 - Ascenscion          │\r\n│9 - Sair                │\r\n└────────────────────────┘");
                }
                else
                {
                    Console.WriteLine("┌────────────────────────┐\r\n│        Upgrades        │\r\n│                        │\r\n│1 - Madeira             │\r\n│2 - Plantil             │\r\n│9 - Sair                │\r\n└────────────────────────┘");
                }
                var chave = Console.ReadKey().Key;

                switch (chave)
                {
                    case ConsoleKey.D1:
                        Madeira.UpgradeMadeira();
                        break;

                    case ConsoleKey.D2:
                        Plantil.UpgradePlantil();
                        break;

                    case ConsoleKey.D3:
                        if (v.ascension > 0) 
                        {
                            Ascension.UpgradeAscension();
                        }
                        break;

                    case ConsoleKey.D9:
                        Console.Clear(); 
                        Program.Main();
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            }
            }

        }
    }
