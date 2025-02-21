using msLearnData;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace msLearn
{
    internal class MenuEditMode
    {
        public static void EditModeMenu()
        {

            ShowEditModeLabel();


            int animalId = ConsoleHelper.GetNumberByReadLine();

            ShowAnimalInfo(animalId);


            DisplayActions();


            ConsoleHelper.PrintBackMessage();

            int animalPropertyId = ConsoleHelper.GetNumberByReadLine() - 1;


            EditAnimalProperty(animalId, animalPropertyId);
        }




        private static void ShowEditModeLabel()
        {
            Console.Clear();
            ConsoleHelper.PrintLine();
            ConsoleHelper.ChangeTextColor("DarkCyan");
            Console.WriteLine($"\tTryb edycji");
            ConsoleHelper.PrintLine();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
            Console.WriteLine($"|\tDo edycji możliwe jest MAX: {Program.ourAnimals.GetLength(0)} pozycji.                                                     |");
            Console.WriteLine($"|\tAby edytować wpisy należy podać numer pozycji ID w bazie.                                  |");
            Console.WriteLine($"|\tDostępne pozycję ID to: 1, 2, 3, 4, 5, 6, 7, 8.                                            |");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Blue");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
            Console.WriteLine($"|\tWpisz \"Wróć\", się aby cofnąć się do Menu.                                                  |");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
            Console.ResetColor();
        }

        private static void ShowAnimalInfo(int animalId)
        {
            //Nagłowek tabeli wybranego zwierzecia
            DisplayAnimalLabel(animalId);

            //Dane wybrengo 
            DisplayAnimalSpecies(animalId);
            DisplayAnimalID(animalId);
            DisplayAnimalAge(animalId);
            DisplayAnimalNick(animalId);
            DisplayAnimalPhysicsDescription(animalId);
            DisplayAnimalCharacter(animalId);
            //Separator - wcięcie
            ConsoleHelper.PrintLine();
        }

        private static void DisplayActions()
        {
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("LightBlue");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|\t1.   |    Edytuj gatunek         |2.    |    Edytuj id            |3.   |    Edytuj wiek      |");
            Console.WriteLine("|\t4.   |    Edytuj opis fizyczny   |5.    |    Edytuj charaktert    |6.   |    Edytuj imię      | ");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|\tWciśnij cyfrę od 1 - 6, aby edytować wskazaną pozycję.                                        |");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.ResetColor();
        }

        private static void EditAnimalSpiece(int animalPropertyID)
        {
            ShowActiveEditLabel();
            DisplayAnimalSpecies(animalPropertyID);
            Console.WriteLine(animalPropertyID);
            DisplayActivEditHelp();

            string text = Console.ReadLine() ?? string.Empty;
            string newUserValue = "Gatunek: " + text;

            OverwriteCurrentAnimalValue(animalPropertyID, 0, newUserValue);
            DisplayAnimalSpecies(animalPropertyID);
            Console.ReadKey();
        }

        private static void EditAnimalProperty(int animalId, int animalPropertyId)
        {
            string newUserValue = string.Empty;
            //userValue++; // przywrócenie wartości indeksu
            if (animalPropertyId == 0) //Spiecies
            {
                EditAnimalSpiece(animalPropertyId);
                return;
            }

            if (animalId == 2) //ID
            {
                Console.ResetColor();
                ConsoleHelper.ChangeTextColor("Red");
                Console.WriteLine("\n\tWartość Id jest generowan automatycznie na bazie 1 lotery gatunku i pozycji indeksu w bazie.");
                Console.ResetColor();
                Console.ReadKey();

            }
            if (animalId == 3) // wiek
            {

                EditAnimalSpiece(animalPropertyId);
                return;
            }
            if (animalId == 4) //opis fizyczny
            {

                EditAnimalSpiece(animalPropertyId);
                return;
            }
            if (animalId == 5) // charakter
            {

                EditAnimalSpiece(animalPropertyId);
                return;
            }
            if (animalId == 6) // nick
            {

                EditAnimalSpiece(animalPropertyId);
                return;
            }
            if (animalId == 0) // exit
            {
                Console.WriteLine("WYBRANO WRÓĆ");
                Console.ReadKey();
                EditModeMenu();
                //MECHANIZAM WRÓĆ
            }
        }

        private static void OverwriteCurrentAnimalValue(int animalId, int animalPropertyId, string newValue)
        {
            Console.Clear();
            Console.Write("Zapisywanie nowej wartości:");
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.WriteLine($"\n{newValue}");

            string currentValue = Program.ourAnimals[animalId, animalPropertyId];

            if (currentValue == newValue)
            {
                ShowEditErrorMessage();
                return;
            }

            Program.ourAnimals[animalId, animalPropertyId] = newValue;

            ShowEditSuccessMessage();
        }

        private static void ShowEditErrorMessage()
        {
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Red");
            Console.WriteLine("\nW trakcie zapisu doszło do nieoczekiwanego błędu");
            Console.ResetColor();
        }

        private static void ShowEditSuccessMessage()
        {
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Green");
            Console.WriteLine("\n\nDane zostały zapisane poprawnie");
            Console.ResetColor();
        }

        private static void DisplayActivEditHelp()
        {
            ConsoleHelper.PrintLine();
            ConsoleHelper.ChangeTextColor("Green");
            Console.WriteLine("|\tZatwierdź nową wartość wciskając \"Enter\".");
            ConsoleHelper.PrintLine();
            Console.WriteLine("\nNową wartość:");
        }

        private static void ShowActiveEditLabel()
        {
            //Console.Clear();
            ConsoleHelper.PrintLine();
            ConsoleHelper.ChangeTextColor("Green");
            Console.WriteLine("\n|\tEdytujesz teraz:");
            ConsoleHelper.PrintLine();
        }

        private static void DisplayAnimalLabel(int animalId)
        {
            Console.Clear();
            ConsoleHelper.ChangeTextColor("Blue");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.Write("|");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkCyan");
            Console.Write($"\tTryb edycji   -->  Wartość użytkownika \"{animalId}\"");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Blue");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.ResetColor();
        }

        public static void DisplayAnimalID(int animalId)
        {
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.Write($"|");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Yellow");
            Console.Write($"\t{Program.ourAnimals[animalId, 1]} \n");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.Write($"|\n");
            Console.ResetColor();

        }

        public static void DisplayAnimalAge(int animalId)
        {
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.Write($"|");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Yellow");
            Console.Write($"\t{Program.ourAnimals[animalId, 2]} \n");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.Write($"|\n");
            Console.ResetColor();

        }

        public static void DisplayAnimalSpecies(int animalId)
        {
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.Write($"|");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Yellow");
            Console.Write($"\t{Program.ourAnimals[animalId, 0]} \n");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.Write($"|\n");
            Console.ResetColor();
        }

        public static void DisplayAnimalNick(int animalId)
        {
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.Write($"|");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Yellow");
            Console.Write($"\t{Program.ourAnimals[animalId, 5]} \n");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.Write($"|\n");
            Console.ResetColor();
        }

        public static void DisplayAnimalPhysicsDescription(int animalId)
        {
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.Write($"|");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Yellow");
            Console.Write($"\t{Program.ourAnimals[animalId, 3]} \n");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.Write($"|\n");
            Console.ResetColor();
        }

        public static void DisplayAnimalCharacter(int animalId)
        {
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.Write($"|");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Yellow");
            Console.Write($"\t{Program.ourAnimals[animalId, 4]} \n");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.Write($"|\n");
            Console.ResetColor();
        }

    }
}
