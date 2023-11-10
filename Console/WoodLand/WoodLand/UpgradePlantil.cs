using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodLand
{
    public class Plantil
    {
        public static void UpgradePlantil()
        {
            while (true)
                {
                    Console.Clear();
                    Console.WriteLine("┌───────────────────────────────────────┐\r\n│               Upgrades                │\r\n│                                       │\r\n│1 - Plantil Acelerado                  │\r\n│2 - Arado Plantador                    │\r\n│3 - Cavalo com Arado                   │\r\n│4 - Maquina de Plantar                 │\r\n│5 - Arrado de Vibranium                │\r\n│6 - Maquina de Vibranium               │\r\n│7 - Plantação Celestial                │\r\n│8 - ???                                │\r\n│9 - Sair                               │\r\n└───────────────────────────────────────┘\r\n");
                    var chave = Console.ReadKey().Key;

                    switch (chave)
                    {
                        case ConsoleKey.D1:
                            while (true)
                            {
                                Console.Clear();
                                double custo1 = (200 * Math.Pow(1.10, v.upgplantil[0]));
                                Console.WriteLine($"┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                                         Plantil Acelerado                                      │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│     Plantara mais rapido suas arvores para fazer novos trabalhos. 3 arvores a mais por vez     │\r\n│                                           R$ {Custos.Valor(custo1), 8}                                          │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t    ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t    │ 1 - Comprar    │      │  2 - Voltar    │\r\n    \t\t\t    └────────────────┘      └────────────────┘"); 
                                var chavee = Console.ReadKey().Key;
                                switch (chavee)
                                {
                                    case ConsoleKey.D1:
                                        if (v.money >= custo1)
                                        {
                                            v.money -= custo1;
                                            Console.Clear();
                                            Console.WriteLine("Upgrade adaptado com sucesso");
                                            Console.ReadKey();
                                            v.upgplantil[0]++;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Você não tem dinheiro suficiente para comprar esse upgrade");
                                            Console.WriteLine("Pressione qualquer tecla para voltar");
                                            Console.ReadKey();
                                        }
                                        break;

                                    case ConsoleKey.D2:
                                        UpgradePlantil();
                                        break;

                                    default:
                                        Console.Clear();
                                        break;
                                }
                            }

                        case ConsoleKey.D2:
                            while (true)
                            {
                                Console.Clear();
                                double custo2 = (15000 * Math.Pow(1.20, v.upgplantil[1]));
                                Console.WriteLine($"┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                                           Arado Plantador                                      │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│   Maquina manual que ira preparar sua terra e ira fazer o plantil. 5 arvores a mais por vez    │\r\n│                                            R$ {Custos.Valor(custo2), 8}                                         │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t    ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t    │ 1 - Comprar    │      │  2 - Voltar    │\r\n    \t\t\t    └────────────────┘      └────────────────┘");
                                var chavee = Console.ReadKey().Key;



                                switch (chavee)
                                {
                                    case ConsoleKey.D1:
                                        if (v.money >= custo2)
                                        {
                                            v.money -= custo2;
                                            Console.Clear();
                                            Console.WriteLine("Upgrade adaptado com sucesso");
                                            Console.ReadKey();
                                            v.upgplantil[1]++;
                                        }

                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Você não tem dinheiro suficiente para comprar esse upgrade");
                                            Console.WriteLine("Pressione qualquer tecla para voltar");
                                            Console.ReadKey();
                                        }
                                        break;

                                    case ConsoleKey.D2:
                                        UpgradePlantil();
                                        break;

                                    default:
                                        Console.Clear();
                                        break;
                                }
                            }

                        case ConsoleKey.D3:
                            while (true)
                            {
                                Console.Clear();
                                double custo3 = (150000 * Math.Pow(1.50, v.upgplantil[2]));
                                Console.WriteLine($"┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                                         Cavalo com Arado                                       │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│         Maquina de arado com cavalo preparo mais rapido do solo. 15 arvores por vez            │\r\n│                                            R$ {Custos.Valor(custo3), 8}                                         │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t    ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t    │ 1 - Comprar    │      │  2 - Voltar    │\r\n    \t\t\t    └────────────────┘      └────────────────┘");
                                var chavee = Console.ReadKey().Key;



                                switch (chavee)
                                {
                                    case ConsoleKey.D1:
                                        if (v.money >= custo3)
                                        {
                                            v.money -= custo3;
                                            Console.Clear();
                                            Console.WriteLine("Upgrade adaptado com sucesso");
                                            Console.ReadKey();
                                            v.upgplantil[2]++;
                                        }

                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Você não tem dinheiro suficiente para comprar esse upgrade");
                                            Console.WriteLine("Pressione qualquer tecla para voltar");
                                            Console.ReadKey();
                                        }
                                        break;

                                    case ConsoleKey.D2:
                                        UpgradePlantil();
                                        break;

                                    default:
                                        Console.Clear();
                                        break;
                                }
                            }

                        case ConsoleKey.D4:
                            while (true)
                            {
                                Console.Clear();
                                double custo4 = (1500000 * Math.Pow(1.50, v.upgplantil[2]));
                                if (v.upgplantil[3] < 21)
                                {
                                Console.WriteLine($"┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                                        Maquina de Plantar                                      │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                   Maquina de plantil profissional que ira fazer o trabalho duro                │\r\n│                                            R$ 10M                                              │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t    ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t    │ 1 - Comprar    │      │  2 - Voltar    │\r\n    \t\t\t    └────────────────┘      └────────────────┘");
                                var chavee = Console.ReadKey().Key;



                                    switch (chavee)
                                    {
                                        case ConsoleKey.D1:
                                            if (v.money >= custo4)
                                            {
                                                v.money -= custo4;
                                                Console.Clear();
                                                Console.WriteLine("Upgrade adaptado com sucesso");
                                                Console.ReadKey();
                                                v.upgplantil[3]++;
                                            } 

                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Você não tem dinheiro suficiente para comprar esse upgrade");
                                                Console.WriteLine("Pressione qualquer tecla para voltar");
                                                Console.ReadKey();
                                            }
                                            break;

                                        case ConsoleKey.D2:
                                            UpgradePlantil();
                                            break;

                                        default:
                                            Console.Clear();
                                            break;
                                    }
                                }
                                else
                                {
                                Console.WriteLine($"┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                                        Maquina de Plantar                                      │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                   Maquina de plantil profissional que ira fazer o trabalho duro                │\r\n│                                           Maximizado                                           │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t    ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t    │ 1 - Comprar    │      │  2 - Voltar    │\r\n    \t\t\t    └────────────────┘      └────────────────┘");
                                Console.ReadKey();
                                UpgradePlantil();
                                }
                            }

                        case ConsoleKey.D5:
                            while (true)
                            {
                                Console.Clear();
                                double custo5 = 1000;
                                if (v.upgplantil[4] == 0)
                                {
                                    Console.WriteLine($"┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                                        Arrado de Vibranium                                     │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                       Um arrado de vibranium permitindo o dobro de plantio por vez             │\r\n│                                          1k Prestige                                           │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t    ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t    │ 1 - Comprar    │      │  2 - Voltar    │\r\n    \t\t\t    └────────────────┘      └────────────────┘");
                                    var chavee = Console.ReadKey().Key;



                                    switch (chavee)
                                    {
                                        case ConsoleKey.D1:
                                            if (v.prestige >= custo5)
                                            {
                                                v.prestige -= custo5;
                                                Console.Clear();
                                                Console.WriteLine("Upgrade adaptado com sucesso");
                                                Console.ReadKey();
                                                v.upgplantil[4]++;
                                            }

                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Você não tem prestige suficiente para comprar esse upgrade");
                                                Console.WriteLine("Pressione qualquer tecla para voltar");
                                                Console.ReadKey();
                                            }
                                            break;

                                        case ConsoleKey.D2:
                                            UpgradePlantil();
                                            break;

                                        default:
                                            Console.Clear();
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                                        Arrado de Vibranium                                     │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                       Um arrado de vibranium permitindo o dobro de plantio por vez             │\r\n│                                           Maximizado                                           │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t    ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t    │ 1 - Comprar    │      │  2 - Voltar    │\r\n    \t\t\t    └────────────────┘      └────────────────┘");
                                    Console.ReadKey();
                                    UpgradePlantil();
                                }
                            }

                        case ConsoleKey.D6:
                            while (true)
                            {
                                Console.Clear();
                                double custo6 = 10000;
                                if (v.upgplantil[5] == 0)
                                {
                                    Console.WriteLine($"┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                                 Maquina de Coleta de Vibranium                                 │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│               Maquinario de alta coleta de madeira e com desempenho de outro mundo             │\r\n│                                          10k Prestige                                          │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t    ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t    │ 1 - Comprar    │      │  2 - Voltar    │\r\n    \t\t\t    └────────────────┘      └────────────────┘");
                                    var chavee = Console.ReadKey().Key;



                                    switch (chavee)
                                    {
                                        case ConsoleKey.D1:
                                            if (v.prestige >= custo6)
                                            {
                                                v.prestige -= custo6;
                                                Console.Clear();
                                                Console.WriteLine("Upgrade adaptado com sucesso");
                                                Console.ReadKey();
                                                v.upgplantil[5]++;
                                            }

                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Você não tem dinheiro suficiente para comprar esse upgrade");
                                                Console.WriteLine("Pressione qualquer tecla para voltar");
                                                Console.ReadKey();
                                            }
                                            break;

                                        case ConsoleKey.D2:
                                            UpgradePlantil();
                                            break;

                                        default:
                                            Console.Clear();
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                                 Maquina de Coleta de Vibranium                                 │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│               Maquinario de alta coleta de madeira e com desempenho de outro mundo             │\r\n│                                           Maximizado                                           │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t    ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t    │ 1 - Comprar    │      │  2 - Voltar    │\r\n    \t\t\t    └────────────────┘      └────────────────┘");
                                    Console.ReadKey();
                                    UpgradePlantil();
                                }
                            }

                        case ConsoleKey.D7:
                            while (true)
                            {
                                Console.Clear();
                                double custo7 = 2500;
                                if (v.upgplantil[6] == 0)
                                {
                                    Console.WriteLine($"┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                                        Plantação Celestial                                     │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│              Desbloqueia a plantação celestial, permitindo plantar hectares por vez            │\r\n│                                           2.5k Acension                                        │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t    ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t    │ 1 - Comprar    │      │  2 - Voltar    │\r\n    \t\t\t    └────────────────┘      └────────────────┘\r\n");
                                    var chavee = Console.ReadKey().Key;



                                    switch (chavee)
                                    {
                                        case ConsoleKey.D1:
                                            if (v.ascension >= custo7)
                                            {
                                                v.ascension -= custo7;
                                                Console.Clear();
                                                Console.WriteLine("Upgrade adaptado com sucesso");
                                                Console.ReadKey();
                                                v.upgplantil[6]++;
                                            }

                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Você não tem dinheiro suficiente para comprar esse upgrade");
                                                Console.WriteLine("Pressione qualquer tecla para voltar");
                                                Console.ReadKey();
                                            }
                                            break;

                                        case ConsoleKey.D2:
                                            UpgradePlantil();
                                            break;

                                        default:
                                            Console.Clear();
                                            break;
                                    }
                                }
                                else
                                {
                                Console.WriteLine($"┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                                        Plantação Celestial                                     │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│              Desbloqueia a plantação celestial, permitindo plantar hectares por vez            │\r\n│                                           Maximizado                                           │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t    ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t    │ 1 - Comprar    │      │  2 - Voltar    │\r\n    \t\t\t    └────────────────┘      └────────────────┘\r\n");
                                Console.ReadKey();
                                UpgradePlantil();
                                }
                            }

                        case ConsoleKey.D8:
                            while (true)
                            {
                                Console.Clear();
                                double custo8 = 100000;
                                if (v.upgplantil[7] == 0)
                                {
                                Console.WriteLine($"┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                                              ???                                               │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                                              ???                                               │\r\n│                                          100k Ascension                                        │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t    ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t    │ 1 - Comprar    │      │  2 - Voltar    │\r\n    \t\t\t    └────────────────┘      └────────────────┘\r\n");
                                    var chavee = Console.ReadKey().Key;



                                    switch (chavee)
                                    {
                                        case ConsoleKey.D1:
                                            if (v.ascension >= custo8)
                                            {
                                                v.ascension -= custo8;
                                                Console.Clear();
                                                Console.WriteLine("Upgrade adaptado com sucesso");
                                                Console.ReadKey();
                                                v.upgplantil[7]++;
                                            }

                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Você não tem dinheiro suficiente para comprar esse upgrade");
                                                Console.WriteLine("Pressione qualquer tecla para voltar");
                                                Console.ReadKey();
                                            }
                                            break;

                                        case ConsoleKey.D2:
                                            UpgradePlantil();
                                            break;

                                        default:
                                            Console.Clear();
                                            break;
                                    }
                                }
                                else
                                {
                                Console.WriteLine($"┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                                              ???                                               │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                                              ???                                               │\r\n│                                           Maximizado                                           │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t    ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t    │ 1 - Comprar    │      │  2 - Voltar    │\r\n    \t\t\t    └────────────────┘      └────────────────┘\r\n");
                                Console.ReadKey();
                                UpgradePlantil();
                                }
                            }

                        case ConsoleKey.D9:
                            Console.Clear();
                            Upgrade.Upgrades();
                            break;
                    }
                }
            }
        }
    }