using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using msLearn.Constants;
using msLearnData;

namespace msLearn
{
    internal class Program
    {
        public static string[,] ourAnimals = AnimalsDataHolder.GetSampleData();

        public static void Main(string[] args)
        {
            CountTargetSpecies();

            //ShowMenuProgram();

            //int userAction = ConsoleHelper.GetNumberByReadLine();

            //PrintUserChoice(userAction);
            //OpenProgramFromMenu(userAction);
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
        private static void CountTargetSpecies()
        {
            string[,] ourAnimls = Program.ourAnimals;
            int ourAnimalsArrayLenght = ourAnimals.GetLength(0);
            Dictionary <string,int> dict = new Dictionary<string,int>();

            for (int i = 0; i < ourAnimls.GetLength(0); i++)
            {
                string currentSpeciesInIteration = ourAnimls[i, AnimalPropertyId.Species].ToLower().Substring(8);

                if (dict.ContainsKey(currentSpeciesInIteration))
                {
                    dict[currentSpeciesInIteration] += 1;
                }
                else 
                { 
                    dict[currentSpeciesInIteration] = 1;
                }
            }
            foreach (KeyValuePair<string, int> item in dict)
            {
                Console.Write(item.Key + " : " + item.Value);
            }
            Console.ReadLine();

        }
    }
}
