using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using msLearnData;

namespace msLearn
{
    internal class Program
    {
        //Inicjalizuje lokalną onStart() bazę danych i przypisuje jej wartość do zmiennej
        public static string[,] ourAnimals = AnimalsDataHolder.GetSampleData();
        //Baza umiera po zamnięciu onDestroy()

        public static void Main(string[] args)
        {
            //Start
            ShowMenuProgram();
            //Obsługa automatycznego wpisu wartości przez użytkownika
            int userAction = ConsoleHelper.GetNumberByReadLine();
            //Wyświetl wybór użytkownika
            DisplayUserChoice(userAction);
            //Uruchom program
            OpenPorgramFromMenu(userAction);
        }

        private static void OpenPorgramFromMenu(int menuSelection)
        {
            switch (menuSelection)
            {
                case 1:
                    MenuAnimalsList.ManageAction();
                    break;
                case 2:
                    MenuEditMode.EditModeMenu();
                    break;
                case 3:
                    Console.WriteLine("Oprogramowanie w trakcie pracy");
                    break;
                case 4:
                    Console.WriteLine("Oprogramowanie w trakcie pracy");
                    break;
                case 0:
                    Console.Clear();
                    ConsoleHelper.ChangeTextColor("Green");
                    Console.WriteLine("\n\nDo widzenia.");
                    Console.ResetColor();
                    Console.ReadKey();
                    return;
            }
        }

        private static void DisplayUserChoice(int menuSelection)
        {
            Console.Write("\nWybrano pozycję:\t");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{menuSelection}");
            Console.ResetColor();
            Console.WriteLine("Wciśnij \"Enter\", aby rozpocząć");
            Console.ReadKey();
        }

        public static void ShowMenuProgram()
        {
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("Witaj w aplikacji Contoso PetFriends. Dostepne opcje to:\n");
            Console.WriteLine("+----------+-------------------------------------------------------------------+");
            Console.WriteLine("| Pozycja  | Opis działania:                                                   |");
            Console.WriteLine("+----------+-------------------------------------------------------------------+");
            Console.WriteLine("| 1.       | Wypisz wszystkie zarejestrowane zwierzęta w bazie.                |");
            Console.WriteLine("| 2.       | Tryb Edycji.                                                      |");
            Console.WriteLine("| 3.       | Wyświetl wybrane wszystkie zwierzęta o danym charakterze.         |");
            Console.WriteLine("| 4.       | Sprawdź nieuzupełnione pola w Archiwum.                           |");
            Console.WriteLine("+----------+-------------------------------------------------------------------+");
            Console.WriteLine("| 0.       | Wybierz \" 0 \", aby zamknać program.                               |");
            Console.WriteLine("+----------+-------------------------------------------------------------------+");
            Console.ResetColor();
        }
    }
}
