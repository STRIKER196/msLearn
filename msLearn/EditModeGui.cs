using msLearn.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msLearn
{
    internal class EditModeGui
    {
        public static void ShowEditModeTitle()
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
            Console.WriteLine($"|\tWybierz 0, aby wrócoć do głownego menu.                                                    |");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
            Console.ResetColor();
        }

        /// <summary>
        /// Print all animal details by animalId
        /// </summary>
        /// <param name="animalId">Id wskazaujący na pierwszą pozycję w tabeli ourAnimals[AnimalID,const].</param>
        public static void ShowAnimalInfo(int animalId)
        {
            DisplayAnimalHeader(animalId);
            PrintAnimalSpecies(animalId);
            PrintAnimalId(animalId);
            PrintAnimalAge(animalId);
            PrintAnimalPhysicalDescription(animalId);
            PrintAnimalPersonalityDescription(animalId);
            PrintAnimalNick(animalId);
            ConsoleHelper.PrintLine();
        }

        public static void DisplayActions()
        {
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkCyan");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.WriteLine($"|\t{AnimalID.Species +1}.   |    Edytuj gatunek         |{AnimalID.Id + 1}.    |    Edytuj id            |{AnimalID.Age + 1}.   |    Edytuj wiek      |");
            Console.WriteLine($"|\t{AnimalID.PhysicalDescription + 1}.   |    Edytuj opis fizyczny   |{AnimalID.PersonalityDescription + 1}.    |    Edytuj charaktert    |{AnimalID.NickName + 1}.   |    Edytuj imię      | ");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|\tWciśnij cyfrę od 1 - 6, aby edytować wskazaną pozycję.                                        |");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.ResetColor();
        }

        private static void DisplayAnimalHeader(int animalId)
        {
            Console.Clear();
            ConsoleHelper.ChangeTextColor("Blue");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.Write("|");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkCyan");
            Console.Write($"\tTryb edycji   -->  Wartość użytkownika \"{animalId}\"\n");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Blue");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.ResetColor();
        }
        public static void PrintAnimalId(int animalId)
        {
            PrintAnimalProperty(animalId, AnimalID.Id);
        }
        public static void PrintAnimalSpecies(int animalId)
        {
            PrintAnimalProperty(animalId, AnimalID.Species);
        }
        public static void PrintAnimalAge(int animalId)
        {
            PrintAnimalProperty(animalId, AnimalID.Age);

        }
        public static void PrintAnimalNick(int animalId)
        {
            PrintAnimalProperty(animalId, AnimalID.NickName);
        }
        public static void PrintAnimalPhysicalDescription(int animalId)
        {
            PrintAnimalProperty(animalId, AnimalID.PhysicalDescription);
        }
        public static void PrintAnimalPersonalityDescription(int animalId)
        {
            PrintAnimalProperty(animalId, AnimalID.PersonalityDescription);
        }
        private static void PrintAnimalProperty(int animalId, int animalPropertyId)
        {
            ConsoleHelper.PrintLine();
            Console.Write($"|");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Yellow");
            Console.Write($"\t{Program.ourAnimals[animalId, animalPropertyId]} \n");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.Write($"|\n");
            Console.ResetColor();
        }

    }
}
