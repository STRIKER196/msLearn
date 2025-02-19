using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msLearn
{
    internal class AnimalDatabasePrinter
    {
        private static readonly int totalAnimalsCount = Program.ourAnimals.GetLength(0);
        public static void PrintAllOneAnimalAtPage()
        {
            bool isDisplayingRecord = true;

            while (isDisplayingRecord)
            {
                try
                {
                    for (int i = 0; i <= totalAnimalsCount; i++)
                    {
                        int pageNumber = i + 1;

                        Console.Clear();
                        Console.WriteLine("+--------------------------+-----------------------------------------------------------------------+");
                        Console.WriteLine($"|     Pozycja              | index iteratora: i ={i}                                                 |");
                        Console.WriteLine("+--------------------------+-----------------------------------------------------------------------+");

                        for (int j = 0; j < Program.ourAnimals.GetLength(1); j++)
                        {
                            Console.WriteLine("+--------------------------+-----------------------------------------------------------------------+");
                            Console.WriteLine($"|{Program.ourAnimals[i, j]}");
                            Console.WriteLine("+--------------------------+-----------------------------------------------------------------------+");
                        }
                        ShowPageInfo(pageNumber);
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    HandleIndexOutOfRangeException();
                    isDisplayingRecord = false;
                }
            }
        }
        private static int ShowPageInfo(int pageNumber)
        {
            Console.WriteLine(totalAnimalsCount);
            Console.WriteLine("\n");
            Console.WriteLine($"Strona: {pageNumber}");
            Console.WriteLine($"[{pageNumber}] of [{Program.ourAnimals.GetLength(0)}]");
            Console.WriteLine("Wciśnij \"Enter\", aby kontynuuować");
            Console.ReadLine();
            Console.ResetColor();

            return pageNumber;
        }
        private static void HandleIndexOutOfRangeException()
        {

            ConsoleHelper.ChangeTextColor("Red");
            Console.WriteLine("\n\nWyświetlono ostatnią stronę z bazy zwierząt");
            Console.ResetColor();

            ManageUserAction();
            
        }
        private static void ManageUserAction()
        {
            Console.WriteLine("\nWybierz opcję");
            Console.WriteLine("Co chcesz zrobić?");
            Console.WriteLine("1 - Powrócić do początku listy");
            Console.WriteLine("2 - Wyjść do menu");

            int userAction = ConsoleHelper.GetNumberByReadLine();
            while (true)
            {
                switch (userAction)
                {
                    case 1:
                        PrintAllOneAnimalAtPage();
                    break;
                    case 2:
                        Program.Main([]);
                    break;
                    default:
                        ConsoleHelper.ChangeTextColor("Yellow");
                        Console.WriteLine("\nPodana wartośc jest spoza menu");
                        Console.WriteLine("Nastąpi przekierowanie do Ekranu startowego");
                        Console.WriteLine("Wciśnij \"Enter\", aby kontynuuować");
                        Console.ResetColor();
                        Console.ReadKey();
                        Program.Main([]);
                    break;
                }
            }
        }
    }
}
