using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msLearn
{
    internal class PrintAllAnimalsInDataBase
    {
        public static void PrintAllOneAnimalAtPage()
        {
            bool display = true;
            while (display)
            {
                for (int i = 0; i < Program.ourAnimals.GetLength(0); i++)
                {
                    int pageCounter = i + 1;

                    Console.WriteLine("+--------------------------+-----------------------------------------------------------------------+");
                    Console.WriteLine($"|     Pozycja              | index iteratora: i ={i}                                                 |");
                    Console.WriteLine("+--------------------------+-----------------------------------------------------------------------+");

                    for (int j = 0; j < Program.ourAnimals.GetLength(1); j++)
                    {
                        Console.WriteLine("+--------------------------+-----------------------------------------------------------------------+");
                        Console.WriteLine($"|{Program.ourAnimals[i, j]}");
                        Console.WriteLine("+--------------------------+-----------------------------------------------------------------------+");
                    }

                    Console.WriteLine("\n");
                    Console.WriteLine($"Strona: {pageCounter}");
                    Console.WriteLine($"[{pageCounter}] of [{Program.ourAnimals.GetLength(0)}]");
                    Console.WriteLine("Wciśnij \"Enter\", aby kontynuuować");
                    Console.ReadLine();
                    Console.ResetColor();
                    Console.Clear();
                }
            }

        }
    }
}
