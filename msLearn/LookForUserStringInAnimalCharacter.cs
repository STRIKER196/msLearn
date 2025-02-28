using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace msLearn
{
    internal static class LookForUserStringInAnimalCharacter
    {
        

        public static void PrintWords()
        {
            string[,] ourAnimals = Program.ourAnimals;

            PrintFunctionInfo();
            Console.ResetColor();

            string? myWord = Console.ReadLine().ToLower() ?? string.Empty;

            FindString(ourAnimals, myWord);
            ConsoleHelper.PrintLine();
            ConsoleHelper.FindWordSuccessful();
            RestartOrBack();
        }

        private static void RestartOrBack()
        {
            PrintAfterSerchMenu();
            int option = ConsoleHelper.GetNumberByReadLine();

            switch (option)
            { 
                case 0:
                    ConsoleHelper.BackToMainMenu();
                    break;
                case 1:
                    PrintWords();
                    break;
                case 2:
                    Console.Clear();
                    RestartOrBack();
                    break;
                default:
                    ConsoleHelper.FindWordUserValueIsOverExpected();
                    RestartOrBack();
                    break;
            }
        }

        private static void PrintAfterSerchMenu()
        {
            Console.ResetColor();
            Console.WriteLine("\n\n+----------+-------------------------------------------------------------------+");
            Console.WriteLine("| Pozycja  | Opis działania:                                                   |");
            Console.WriteLine("+----------+-------------------------------------------------------------------+");
            Console.WriteLine("| 1.       | Wyszukaj inny ciąg.                                               |");
            Console.WriteLine("| 2.       | Wyczyść ekran.                                                    |");
            Console.WriteLine("+----------+-------------------------------------------------------------------+");
            Console.WriteLine("| 0.       | Wybierz \" 0 \", aby wrócić do głownego Menu.                     |");
            Console.WriteLine("+----------+-------------------------------------------------------------------+");
            Console.ResetColor();
        }
        private static void PrintFunctionInfo()
        {
            Console.Clear();
            ConsoleHelper.PrintLine();
            ConsoleHelper.ChangeTextColor("Blue");
            Console.WriteLine("\n\tPodaj ciąg, który mam wyszukać w charakterach dostępnych zwierząt: \n");
            ConsoleHelper.ChangeTextColor("Yellow");
            Console.Write("\nWyszukaj:");
        }

        private static void FindString(string[,] ourAnimals, string lookedWord)
        {
            Console.WriteLine(""); // odstęp

            for (int i = 0; i < ourAnimals.GetLength(0); i++)
            {

                string animalPersonalityDescription = Program.ourAnimals[i, 4] ?? string.Empty;
                Console.Write($"\tZwierzę {i + 1}| ");
                ColoredWord(animalPersonalityDescription, lookedWord);

            }
        }
        private static void ColoredWord(string animalPersonalityDescription, string lookedWord)
        {
            int index = animalPersonalityDescription.IndexOf(lookedWord, StringComparison.OrdinalIgnoreCase);

            while (index != -1)
            {
                Console.Write(animalPersonalityDescription.Substring(0, index));
                ConsoleHelper.ChangeTextColor("Green");
                Console.Write(lookedWord);
                Console.ResetColor();

                animalPersonalityDescription = animalPersonalityDescription.Substring(index + lookedWord.Length);
                index = animalPersonalityDescription.IndexOf(lookedWord, StringComparison.OrdinalIgnoreCase);
            }
            Console.WriteLine(animalPersonalityDescription);
        }
    }
}
