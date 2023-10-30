using WoodLand;
using System;
using System.Threading;
using WindowsInput;
using WindowsInput.Native;
using System.Runtime.Intrinsics.X86;

namespace WoodLand
{
    public class Program
    {
        public static void Main()
        {
                Banco.Saves();
                //Timer wds = new Timer(Tempo, null, 0, 10000); // Rodar uma função a cada 10000 milisegundos
                Timer wds = new Timer(Tempo, null, 0, 1000);
                Arvore(); // Rodar a geração de árvores aleatórias
                v.a();
                //Tela.Teste(); //Não funciona no Windows 11, DLL diferentes.   
                while (v.trees > 0)
                {
                    Console.Clear();
                    Wood.NumerosWood();
                    Money.NumerosMoney();
                    Inicioo.Inicio();
                }
                if (v.trees < 1)
                {
                    Console.Clear();
                    string final = "Você desmatou o mundo inteiro, já não há mais árvores no mundo e isso causou sua morte";
                    string final2 = "Seu progresso será resetado e uma nova jornada irá começar";
                    ResetaProgresso();
                    Banco.Saves();
                    foreach (char letra in final)
                    {
                        Console.Write(letra);
                        Thread.Sleep(60);
                    }
                    Console.WriteLine();
                    foreach (char letra in final2)
                    {
                        Console.Write(letra);
                        Thread.Sleep(60);
                    }
                    
                    Console.ReadKey();
                    Environment.Exit(0);
                }
        }

        public static void Tempo(object state)
        {
            Banco.AutoSave();
            v.wood += v.upgradeDPS;
            v.trees -= v.upgradeDPS;
            v.trees += v.upgradeDPStree;
            //InputSimulator refresh = new InputSimulator(); //Cria uma classe InputSimulator
            //refresh.Keyboard.KeyPress(VirtualKeyCode.SPACE); //Envia o "espaço" para limpar a tela no console. 
        }

        public static void Arvore()
        {
            if (v.trees <= 0)
            {
                Random rnum = new Random();
                v.trees = rnum.Next(100000, 1000000);
            }
        }

        public static void ResetaProgresso()
        {
            v.wood = 0;
            v.trees = 0;
            v.money = 0;
            v.prestige = 0;
            v.ascension = 0;
            v.upgradeDPS = 0;
            v.upgradeDPStree = 0;
            for (int i = 0; i < v.upgwood.Length; i++)
            {
                v.upgwood[i] = 0;
                v.upgplantil[i] = 0;
                v.upgascension[i] = 0;
            }
        }
    }
}

