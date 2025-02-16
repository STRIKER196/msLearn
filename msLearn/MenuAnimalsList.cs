using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msLearn
{
    internal class MenuAnimalsList
    {
        public static void ShowAllItemsInArray()
        {
            Console.ResetColor();
            Console.Clear();

            for (int i = 0; i < ourAnimals.GetLength(0); i++)
            {
                int pageCounter = i + 1;

                Console.WriteLine("+--------------------------+-----------------------------------------------------------------------+");
                Console.WriteLine($"|     Pozycja              | index iteratora: i ={i}                                                  |");
                Console.WriteLine("+--------------------------+-----------------------------------------------------------------------+");

                for (int j = 0; j < ourAnimals.GetLength(1); j++)
                {
                    Console.WriteLine("+--------------------------+-----------------------------------------------------------------------+");
                    Console.WriteLine($"|{ourAnimals[i, j]}");
                    Console.WriteLine("+--------------------------+-----------------------------------------------------------------------+");
                }

                Console.WriteLine("\n");
                Console.WriteLine($"Strona: {pageCounter}");
                Console.WriteLine($"[{pageCounter}] of [{ourAnimals.GetLength(0)}]");
                Console.WriteLine("Wciśnij \"Enter\", aby kontynuuować");
                Console.ReadLine();
                Console.ResetColor();
                Console.Clear();
            }
        }
    }
}
