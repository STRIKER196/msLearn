using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using msLearn.Constants;
using msLearn.DataBase;
using msLearn.EditMode;
using msLearn.FindUserWordInAnimalCharacter;
using msLearn.PrintAllAnimalsInfo;
using msLearn.CheckIfSomeRecordsAreEmpty;


namespace msLearn
{
    internal class ContosoPetFriends
    {

        public static string[,] ourAnimals = AnimalsDataHolder.GetSampleData();

        public static void Main(string[] args)
        {

            ShowMenuProgram();

            int userAction = ConsoleHelper.GetNumberByReadLine();

            PrintUserChoice(userAction);
            OpenProgramFromMenu(userAction);
        }

        private static void OpenProgramFromMenu(int menuSelection)
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
                    MenuFindWordInDataBase.MenuLookForUserText();
                    break;
                case 4:
                    LookForEmptyRecords.MenuCheckEmptyRecords();
                    Console.WriteLine("Oprogramowanie w trakcie pracy. Wciśnij dowony przycisk");
                    Console.ReadLine();
                    break;
                case 0:
                    Console.Clear();
                    ConsoleHelper.ChangeTextColor("Green");
                    Console.WriteLine("\n\nDo widzenia.");
                    Console.ResetColor();
                    Console.ReadLine();
                    break;
            }
        }

        private static void PrintUserChoice(int menuSelection)
        {
            Console.Write($"\nWybrano pozycję:\t");
            ConsoleHelper.ChangeTextColor("Green");
            Console.WriteLine(menuSelection);
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
            Console.WriteLine("| 0.       | Wybierz \" 0 \", aby zamknąć program.                               |");
            Console.WriteLine("+----------+-------------------------------------------------------------------+");
            Console.ResetColor();
        }
    }
}
