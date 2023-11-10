using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WoodLand
{
    public class Madeira
    {
        public static void UpgradeMadeira()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("┌───────────────────────────────────────┐\r\n│               Upgrades                │\r\n│                                       │\r\n│1 - Melhoria na Coleta de Madeira      │\r\n│2 - Máquinas de Corte Automático       │\r\n│3 - Madeira de Vibranium               │\r\n│4 - Corte Reduzido                     │\r\n│5 - Serra de Vibranium                 │\r\n│6 - Maquina de Coleta de Vibranium     │\r\n│7 - Serra Celestial                    │\r\n│8 - Maquina de Coleta Celestial        │\r\n│9 - Sair                               │\r\n└───────────────────────────────────────┘\r\n");
                var chave = Console.ReadKey().Key;

                switch (chave)
                {
                    case ConsoleKey.D1:
                        while (true) {
                        Console.Clear();
                        double custo1 = (500 * Math.Pow(1.10, v.upgwood[0]));
                        Console.WriteLine($" ┌─────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n │                                        Upgrade - Coleta                                         │\r\n └─────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n ┌─────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n │                       Esse upgrade adicionara +3 à sua coleta de madeira                        │\r\n │                                           R$ {Custos.Valor(custo1),8}                                           │\r\n └─────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t     ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t     │ 1 - Comprar    │      │  2 - Voltar    │\r\n    \t\t\t     └────────────────┘      └────────────────┘");
                        var chavee = Console.ReadKey().Key;
                            switch (chavee)
                            {
                                case ConsoleKey.D1:
                                    if (v.money >= custo1)
                                    {
                                        v.upgradewood = 2 + (2 * v.upgwood[0]);
                                        v.money -= custo1;
                                        Console.Clear();
                                        Console.WriteLine("Upgrade adaptado com sucesso");
                                        Console.ReadKey();
                                        v.upgwood[0]++;
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
                                    UpgradeMadeira();
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
                            double custo2 = (10000 * Math.Pow(1.50, v.upgwood[1]));
                            Console.WriteLine($" ┌─────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n │                                   Upgrade - Coleta Automática                                   │\r\n └─────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n ┌─────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n │                            Esse upgrade coletará madeira automáticamente                        │\r\n │                                            R$ {Custos.Valor(custo2), 8}                                          │\r\n └─────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t    ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t    │ 1 - Comprar    │      │  2 - Voltar    │\r\n    \t\t\t    └────────────────┘      └────────────────┘");
                            var chavee = Console.ReadKey().Key;
 

                            
                            switch (chavee)
                            {
                                case ConsoleKey.D1:
                                if (v.money >= custo2)
                                {
                                    v.upgradeDPS = 10 * v.upgwood[1];
                                    v.money -= custo2;
                                    Console.Clear();
                                    Console.WriteLine("Upgrade adaptado com sucesso");
                                    Console.ReadKey();
                                    v.upgwood[1]++;
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
                                    UpgradeMadeira();
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
                            double custo3 = (1000000 * Math.Pow(2.10, v.upgwood[2]));
                            Console.WriteLine($"┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                                      Madeira de Vibranium                                      │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│     Madeira nobre de alto valor, alto lucro e procura muito alta devido a sua raridade         │\r\n│                                          R$ {Custos.Valor(custo3),8}                                           │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t    ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t    │ 1 - Comprar    │      │  2 - Voltar    │\r\n    \t\t\t    └────────────────┘      └────────────────┘");
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
                                        v.upgwood[2]++;
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
                                    UpgradeMadeira();
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
                            double custo4 = 10000000;
                            if (v.upgwood[3] == 0)
                            {
                                Console.WriteLine($"┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                                      Upgrade - Corte Reduzido                                  │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                          Esse upgrade diminuí a coleta de árvores por vez                      │\r\n│                                            R$ 10M                                              │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t    ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t    │ 1 - Comprar    │      │  2 - Voltar    │\r\n    \t\t\t    └────────────────┘      └────────────────┘");
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
                                            v.upgwood[3]++;
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
                                        UpgradeMadeira();
                                        break;

                                    default:
                                        Console.Clear();
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine($"┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                                      Upgrade - Corte Reduzido                                  │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                          Esse upgrade diminuí a coleta de árvores por vez                      │\r\n│                                            Maximizado                                          │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t    ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t    │ 1 - Comprar    │      │  2 - Voltar    │\r\n    \t\t\t    └────────────────┘      └────────────────┘");
                                Console.ReadKey();
                                UpgradeMadeira();
                            }
                        }

                    case ConsoleKey.D5:
                        while (true)
                        {
                            Console.Clear();
                            double custo5 = v.custoCinco;
                            if (v.upgwood[4] == 0)
                            {
                            Console.WriteLine($"┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                                        Serra de Vibranium                                      │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│  Serra eletrica com a ultima tecnologia existente na terra com metal vibranium em sua lamina   │\r\n│                                       Custo: 1k Prestige                                       │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t    ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t    │ 1 - Comprar    │      │  2 - Voltar    │\r\n    \t\t\t    └────────────────┘      └────────────────┘");
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
                                            v.upgwood[4]++;
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
                                        UpgradeMadeira();
                                        break;

                                    default:
                                        Console.Clear();
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine($"┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                                        Serra de Vibranium                                      │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│  Serra eletrica com a ultima tecnologia existente na terra com metal vibranium em sua lamina   │\r\n│                                            Maxizado                                            │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t    ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t    │ 1 - Comprar    │      │  2 - Voltar    │\r\n    \t\t\t    └────────────────┘      └────────────────┘");
                                Console.ReadKey();
                                UpgradeMadeira();
                            }
                        }

                    case ConsoleKey.D6:
                        while (true)
                        {
                            Console.Clear();
                            double custo6 = v.custoSeis;
                            if (v.upgwood[5] == 0)
                            {
                                Console.WriteLine($"┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                                 Maquina de Coleta de Vibranium                                 │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│               Maquinario de alta coleta de madeira e com desempenho de outro mundo             │\r\n│                                       Custo: 5k Prestige                                       │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t    ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t    │ 1 - Comprar    │      │  2 - Voltar    │\r\n    \t\t\t    └────────────────┘      └────────────────┘");
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
                                            v.upgwood[5]++;
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
                                        UpgradeMadeira();
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
                                UpgradeMadeira();
                            }
                        }

                    case ConsoleKey.D7:
                        while (true)
                        {
                            Console.Clear();
                            double custo7 = v.custoSete;
                            if (v.upgwood[6] == 0)
                            {
                                Console.WriteLine($"┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                                        Serra Celestial                                         │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│   Serra forjada em Uru em Nidavellir a serra das serras somente que é digndo pode usa-la       │\r\n│                                       Custo: 500 Ascension                                     │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t    ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t    │ 1 - Comprar    │      │  2 - Voltar    │\r\n    \t\t\t    └────────────────┘      └────────────────┘\r\n");
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
                                            v.upgwood[6]++;
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
                                        UpgradeMadeira();
                                        break;

                                    default:
                                        Console.Clear();
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine($"┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                                        Serra Celestial                                         │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│   Serra forjada em Uru em Nidavellir a serra das serras somente que é digndo pode usa-la       │\r\n│                                            Maximizado                                          │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t    ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t    │ 1 - Comprar    │      │  2 - Voltar    │\r\n    \t\t\t    └────────────────┘      └────────────────┘\r\n");
                                Console.ReadKey();
                                UpgradeMadeira();
                            }
                        }

                    case ConsoleKey.D8:
                        while (true)
                        {
                            Console.Clear();
                            double custo8 = v.custoOito;
                            if (v.upgwood[7] == 0)
                            {
                                Console.WriteLine($"┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                                   Maquina de Coleta Celestial                                  │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│       Maquina forjada em Uru em Nidavellir,Nunca vera uma maquina que coletara e plantara      │\r\n│                                       Custo: 5k Ascension                                      │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t    ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t    │ 1 - Comprar    │      │  2 - Voltar    │\r\n    \t\t\t    └────────────────┘      └────────────────┘");
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
                                            v.upgwood[7]++;
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
                                        UpgradeMadeira();
                                        break;

                                    default:
                                        Console.Clear();
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine($"┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│                                   Maquina de Coleta Celestial                                  │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n┌────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n│       Maquina forjada em Uru em Nidavellir,Nunca vera uma maquina que coletara e plantara      │\r\n│                                           Maximizado                                           │\r\n└────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t    ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t    │ 1 - Comprar    │      │  2 - Voltar    │\r\n    \t\t\t    └────────────────┘      └────────────────┘");
                                Console.ReadKey();
                                UpgradeMadeira();
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

//Console.WriteLine(" Usuario:\r\n┌──────────────────────────────┐\r\n│                             │\r\n└──────────────────────────────┘\r\n Senha:\r\n┌──────────────────────────────┐\r\n│                             │\r\n└──────────────────────────────┘\r\n\r\n┌────────────────────┐  \r\n│  1 - Entrar  │\r\n└────────────────────┘  \r\n\r\n┌────────────────────┐\r\n│  2 - Criar  │\r\n└────────────────────┘")