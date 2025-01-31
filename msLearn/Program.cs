using System;
using System.Numerics;
using System.Reflection.Metadata;

namespace msLearn // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//PRZYDATNE, WYPISYWANIE TABLICY OD KONCA DO PRZODU
             * 
            string[] names = { "Alex", "Eddie", "David", "Michael" };
            for (int i = names.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }
            
            //Update
            string[] names = { "Alex", "Eddie", "David", "Michael" };
            for (int i = 0; i < names.Length; i++)
                if (names[i] == "David") names[i] = "Sammy";

            foreach (var name in names) Console.WriteLine(name);
            */
            string fizzName = "Fizz";
            string buzzName = "Buzz";

            for (int number = 1; number <= 100; number++)
            {

                if ((number % 3 == 0) && (number % 5 == 0))
                {
                    Console.WriteLine($"{number} - {fizzName}{buzzName}");
                }
                else if  (number % 3 == 0)
                {
                     Console.WriteLine($"{number} - {fizzName}");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine($"{number} - {buzzName}");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}