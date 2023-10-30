using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodLand
{
    public class Plantacao
    {
        public static void PlantarArvores()
        {
            if (v.money >= 5)
            {
                v.money -= 5;
                v.trees += 0 + v.upgradetrees;
                Console.WriteLine("Você plantou 1 árvore.");
            }

            else
            {
                Console.WriteLine("Você não tem dinheiro suficiente para plantar árvores.");
            }
        }
    }
}
