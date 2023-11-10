using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace WoodLand
{
    public class Inicioo
    {
        public static void Inicio()
        {
            Console.CursorVisible = false;
            if (v.ascension >= 1)
            {
                Console.WriteLine($"┌────────────────────────┐\r\n│Madeiras: {Math.Round(v.woodfront, 1),5}{v.l}       │\r\n│Dinheiro: {Math.Round(v.moneyfront, 1),5}{v.m}       │\r\n│Árvores: {Custos.Valor(v.trees), 8}       │\r\n│Prestige: {Custos.Valor(v.prestige), 8}      │\r\n│Ascension:  {Custos.Valor(v.ascension), 8}    │\r\n│                \t │\r\n│                        │\r\n│                        │\r\n│                        │\r\n│                        │\r\n│                        │\r\n│                        │\r\n│                        │\r\n│                        │\r\n│                        │\r\n│                        │\r\n└────────────────────────┘\r\n");
            }
            else if (v.prestige >= 1)
            {
                Console.WriteLine($"┌────────────────────────┐\r\n│Madeiras: {Math.Round(v.woodfront, 1),5}{v.l}       │\r\n│Dinheiro: {Math.Round(v.moneyfront, 1),5}{v.m}       │\r\n│Árvores: {Custos.Valor(v.trees), 8}       │\r\n│Prestige: {Custos.Valor(v.prestige),8}      │\r\n│                \t │\r\n│                        │\r\n│                        │\r\n│                        │\r\n│                        │\r\n│                        │\r\n│                        │\r\n│                        │\r\n│                        │\r\n│                        │\r\n│                        │\r\n└────────────────────────┘\r\n");
            }
            else 
            {
                Console.WriteLine($"┌────────────────────────┐\r\n│Madeiras: {Math.Round(v.woodfront, 1),5}{v.l}       │\r\n│Dinheiro: {Math.Round(v.moneyfront, 1),5}{v.m}       │\r\n│Árvores: {Custos.Valor(v.trees), 8}       │\r\n│                \t │\r\n│                        │\r\n│                        │\r\n│                        │\r\n│                        │\r\n│                        │\r\n│                        │\r\n│                        │\r\n│                        │\r\n│                        │\r\n│                        │\r\n└────────────────────────┘\r\n");
            }
            if (v.money > 10000000000 || v.wood > 10000000000)
            {
                Console.WriteLine("\nEscolha uma ação:");
                Console.WriteLine("1. Coletar Madeira");
                Console.WriteLine("2. Vender Madeira");
                Console.WriteLine("3. Plantar Árvores");
                Console.WriteLine("4. Upgrade");
                Console.WriteLine("5. Sobre o Jogo");
                Console.WriteLine("6. Prestige");
                Console.WriteLine("7. Ascension");
                Console.WriteLine("8. Sair do Jogo");
            }
            else if (v.money > 10000000 || v.wood > 10000000)
            {
                Console.WriteLine("\nEscolha uma ação:");
                Console.WriteLine("1. Coletar Madeira");
                Console.WriteLine("2. Vender Madeira");
                Console.WriteLine("3. Plantar Árvores");
                Console.WriteLine("4. Upgrade");
                Console.WriteLine("5. Sobre o Jogo");
                Console.WriteLine("6. Prestige");
                Console.WriteLine("8. Sair do Jogo");
            }
            else
            {
                Console.WriteLine("\nEscolha uma ação:");
                Console.WriteLine("1. Coletar Madeira");
                Console.WriteLine("2. Vender Madeira");
                Console.WriteLine("3. Plantar Árvores");
                Console.WriteLine("4. Upgrade");
                Console.WriteLine("5. Sobre o Jogo");
                Console.WriteLine("8. Sair do Jogo");
            }
            

            var chave = Console.ReadKey().Key;
            switch (chave)
            {
                case ConsoleKey.D1:
                    Coleta.ColetarMadeira();
                    break;

                case ConsoleKey.D2:
                    Venda.VenderMadeira();
                    break;

                case ConsoleKey.D3:
                    Plantacao.PlantarArvores();
                    break;

                case ConsoleKey.D4:
                    Upgrade.Upgrades();
                    break;

                case ConsoleKey.D5:
                    Console.Clear();
                    Console.WriteLine("Sobre o Jogo - WoodLand\r\nBem-vindo a WoodLand, o reino da natureza onde o poder da madeira está ao seu alcance! Embarque em uma jornada única de crescimento, colheita e renovação em um jogo incremental que vai cativar sua imaginação e habilidades estratégicas.\r\n\r\nPlantio e Colheita Sustentável\r\nEm WoodLand, você assume o papel de um guardião da floresta, encarregado de plantar e colher árvores de forma sustentável. A mecânica central do jogo gira em torno do equilíbrio entre a expansão da sua floresta e a colheita responsável para obter madeira valiosa.\r\n\r\nCultive a sua Floresta\r\nPlante uma variedade de árvores, desde as mais comuns até as mais raras, à medida que você expande seu próprio bosque personalizado, venda sua madeira no mercado e reinvesta os lucros para expandir ainda mais seu império florestal.\r\n\r\nAscensão e Prestígio\r\nGanhe prestígio ao reiniciar o jogo e desbloqueie ascensões poderosas para acelerar seu crescimento. Aumente sua conexão com a natureza, desenvolva técnicas avançadas de cultivo e desbloqueie habilidades místicas para dominar completamente a produção de madeira.");
                    Console.WriteLine("\nDesenvolvido por Pedro David e Richard Martins\n");
                    Console.WriteLine("Pressione qualquer tecla para voltar.");
                    Console.ReadKey();
                    break;

                case ConsoleKey.D6:
                    if (v.money >= 10000000)
                    {
                        int i = -1;
                        while (i == -1)
                        {
                            Console.Clear();
                            Console.WriteLine($" ┌─────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n │                                            Prestige                                             │\r\n └─────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n ┌─────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n │                       Reseta seu progresso em troca de uma moeda valiosa                        │\r\n │                                        {Custos.Valor(v.money/1000000), 8} Prestige                                        │\r\n └─────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t     ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t     │ 1 - Prestige   │      │  2 - Voltar    │\r\n    \t\t\t     └────────────────┘      └────────────────┘");
                            var chavee = Console.ReadKey().Key;

                            switch (chavee)
                            {
                                case ConsoleKey.D1:
                                    Console.Clear();
                                    Console.WriteLine(" ┌─────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n │                                           Confirmação                                           │\r\n └─────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t     ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t     │ 1 - Prestige   │      │  2 - Voltar    │\r\n    \t\t\t     └────────────────┘      └────────────────┘");
                                    var chaveee = Console.ReadKey().Key;

                                    switch (chaveee)
                                    {
                                        case ConsoleKey.D1:
                                            v.prestige += v.money / 1000000;
                                            ResetPrestige();
                                            Console.Clear();
                                            string frase = "Você percebe a si mesmo evoluir e sente o poder de um prestígio.";

                                            foreach (char letra in frase)
                                            {
                                                Console.Write(letra);
                                                Thread.Sleep(75);
                                            }
                                            Console.ReadKey();
                                            i = 1;

                                            break;

                                        case ConsoleKey.D2:
                                            i = 1; ;
                                            break;
                                    }
                                    break;

                                case ConsoleKey.D2:
                                    i = 1;
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();
                    }
                    break;

                case ConsoleKey.D7:
                    if (v.money >= 10000000000)
                    {
                        int i = -1;
                        while (i == -1)
                        {
                            Console.Clear();
                            Console.WriteLine($" ┌─────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n │                                            Ascension                                            │\r\n └─────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n ┌─────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n │                       Reseta seu progresso em troca de uma moeda valiosa                        │\r\n │                                       {Custos.Valor(v.money / 10000000000),8} Ascension                                        │\r\n └─────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t     ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t     │ 1 - Ascension  │      │  2 - Voltar    │\r\n    \t\t\t     └────────────────┘      └────────────────┘");
                            var chavee = Console.ReadKey().Key;

                            switch (chavee)
                            {
                                case ConsoleKey.D1:
                                    Console.Clear();
                                    Console.WriteLine(" ┌─────────────────────────────────────────────────────────────────────────────────────────────────┐\r\n │                                           Confirmação                                           │\r\n └─────────────────────────────────────────────────────────────────────────────────────────────────┘\r\n    \t\t\t     ┌────────────────┐      ┌────────────────┐    \r\n    \t\t\t     │ 1 - Ascension  │      │  2 - Voltar    │\r\n    \t\t\t     └────────────────┘      └────────────────┘");
                                    var chaveee = Console.ReadKey().Key;

                                    switch (chaveee)
                                    {
                                        case ConsoleKey.D1:
                                            v.ascension += v.money / 10000000000;
                                            ResetPrestige();
                                            Console.Clear();
                                            string frase = "Você percebe a si mesmo evoluir e sente o poder de uma ascensão.";

                                            foreach (char letra in frase)
                                            {
                                                Console.Write(letra);
                                                Thread.Sleep(75);
                                            }
                                            Console.ReadKey();
                                            i = 1;
                                            break;

                                        case ConsoleKey.D2:
                                            i = 1; ;
                                            break;
                                    }
                                    break;

                                case ConsoleKey.D2:
                                    i = 1;
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();
                    }
                    break;


                case ConsoleKey.D8:
                    Console.Clear();
                    Banco.AutoSave();
                    Console.WriteLine("Obrigado por jogar!");
                    Environment.Exit(0);
                    break;

                default:
                    Console.Clear();
                    break;
            }
        }

        public static void ResetPrestige()
        {
            Random rnum = new Random();
            v.wood = 0;
            v.trees = rnum.Next(100000, 1000000);
            v.money = 0;
            v.upgradeDPS = 0;
            v.upgradeDPStree = 0;
            for  (int i = 0; i < 4; i++)
            {
                v.upgwood[i] = 0;
                v.upgplantil[i] = 0;
            }
        }

        public static void ResetAscension()
        {
            Random rnum = new Random();
            v.wood = 0;
            v.trees = rnum.Next(100000, 1000000);
            v.money = 0;
            for (int i = 0; i < 6; i++)
            {
                v.upgwood[i] = 0;
                v.upgplantil[i] = 0;
            }
            v.prestige = 0;
            v.upgradeDPS = 0;
            v.upgradeDPStree = 0;
        }
    }
}
