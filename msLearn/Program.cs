using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using msLearn2;

namespace msLearn
{
    internal class Program
    {
        public static string[,] ourAnimals = AnimalsDataHolder.GetSampleData();

        public static void Main(string[] args)
        {
            // TUTAJ RESTART
            ShowMenuProgram();

            int menuSelection = ConsoleHelper.GetNumberByReadLine();

            
            Console.Write("\nWybrano pozycję:\t");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{menuSelection}");
            Console.ResetColor();
            Console.WriteLine("Wciśnij \"Enter\", aby rozpocząć");
            Console.ReadKey();

            switch (menuSelection)
            {
                case 1 :
                    MenuAnimalsList.ManageAction();
                    break;
                case 2 :
                    MenuEditMode.ShowEditModeMenu();
                    break;
                case 3 :
                    Console.WriteLine("Oprogramowanie w trakcie pracy");
                    break;
                case 4 :
                    Console.WriteLine("Oprogramowanie w trakcie pracy");
                    break;

            }
        }


        public static string GetMenuOption()
        {
            
            string readResult = null;
            bool correctReadResultValue = false;
            
            while (!correctReadResultValue)
            {
                Console.WriteLine("\nWprowadz wartość pozycji, którą ma wykonać program");
                readResult = (Console.ReadLine() ?? "").Trim().Replace(".","");
                if (readResult != null && !string.IsNullOrWhiteSpace(readResult))
                {
                    if (readResult == "Exit")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Wybrano pozycję:");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($" {readResult}\n");
                        Console.WriteLine("Program się zamyka...\n\n");
                        Console.WriteLine("Wciśnij \"Enter\", aby kontynuuować");
                        Console.ReadKey();
                        Environment.Exit(0);

                    }
                    else if
                    (
                        readResult == "1" || readResult == "2" ||
                        readResult == "3" || readResult == "4" ||
                        readResult == "5" || readResult == "6" ||
                        readResult == "7" || readResult == "8"
                    ) 
                    {
                        break;
                    }
                    else
                    {
                        ConsoleHelper.ChangeTextColor("Magenta");
                        Console.WriteLine("Program nie rozpoznał wartości.");
                        Console.ResetColor();
                    }
                    correctReadResultValue = true;
                }
                else
                {
                    ConsoleHelper.ChangeTextColor("Red");
                    Console.WriteLine("Program nie rozpoznał wartości lub wciśnieto Enter.");
                    Console.ResetColor();
                }
                correctReadResultValue = false;
            }
            return readResult;
        }
        public static void ShowMenuProgram()
        {
            Console.ResetColor();
            Console.Clear();

            Console.WriteLine("Witaj w aplikacji Contoso PetFriends. Dostepne opcje to:\n");

            Console.WriteLine("+----------+-------------------------------------------------------------------+");
            Console.WriteLine("| Pozycja  | Opis działania                                                    |");
            Console.WriteLine("+----------+-------------------------------------------------------------------+");
            Console.WriteLine("| 1.       | Wypisz wszystkie zarejestrowane zwierzęta w bazie.                |");
            Console.WriteLine("| 2.       | Tryb Edycji.                                                      |");
            Console.WriteLine("| 3.       | Wyświetl wybrane wszystkie zwierzęta o danym charakterze.         |");
            Console.WriteLine("| 4.       | Sprawdź nieuzupełnione pola w Archiwum.                           |");
            Console.WriteLine("+----------+-------------------------------------------------------------------+");
            Console.WriteLine("| Exit     | Wpisz słowo \"Exit\", wby wyjść z programu.                         |");
            Console.WriteLine("+----------+-------------------------------------------------------------------+");
            Console.ResetColor();
        }

    }
}
