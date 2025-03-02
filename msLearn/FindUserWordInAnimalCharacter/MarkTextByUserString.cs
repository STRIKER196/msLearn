using msLearn.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace msLearn
{
    internal static class MarkTextByUserString
    {

        public static void PrintMarkedWordFromDataBase()
        {
            string[,] ourAnimals = CopntosoPetFriends.ourAnimals;

            PrintBeforeSearchInfo();
            Console.ResetColor();

            string? myWord = Console.ReadLine().ToLower() ?? string.Empty;

            MarkMyWord(ourAnimals, myWord);
            ConsoleHelper.PrintLine();
            ConsoleHelper.FindMyWordSuccessful();
            RestartOrBack();
        }

        private static void RestartOrBack()
        {
            PrintAfterSerchOptions();
            int option = ConsoleHelper.GetNumberByReadLine();

            switch (option)
            { 
                case 0:
                    ConsoleHelper.BackToMainMenu();
                    break;
                case 1:
                    PrintMarkedWordFromDataBase();
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

        private static void PrintAfterSerchOptions()
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
        private static void PrintBeforeSearchInfo()
        {
            Console.Clear();
            ConsoleHelper.PrintLine();
            ConsoleHelper.ChangeTextColor("Blue");
            Console.WriteLine("\n\tPodaj ciąg, który mam wyszukać w charakterach dostępnych zwierząt: \n");
            ConsoleHelper.ChangeTextColor("Yellow");
            Console.Write("\nWyszukaj:");
        }

        private static void MarkMyWord(string[,] ourAnimals, string lookedWord)
        {
            
            Console.Write($"\n\tWskazany ciąg jest zakolorowany na Zielono.\n");
            for (int i = 0; i < ourAnimals.GetLength(0); i++)
            {
                string animalPersonalityDescription = CopntosoPetFriends.ourAnimals[i ,AnimalPropertyId.PersonalityDescription] ?? string.Empty;
                Console.Write($"\tZwierzę {i +1}| ");
                ColoredWord(animalPersonalityDescription, lookedWord);

            }
        }
        /// <summary>
        /// Wyszykuje wskzana ciąg jako frazę w docelowej wartości. IndexOf(lookedWord, index, StringComparison.OrdinalIgnoreCase) Igonoruje wielkość literaz w wyszukiwanej wartości.
        /// </summary>
        /// <param name="animalPersonalityDescription"> </param>
        /// <param name="lookedWord"> String, szukany ciąg.</param>
        private static void ColoredWord(string animalPersonalityDescription, string lookedWord)
        {
            
            int index = 0;
            while (index < animalPersonalityDescription.Length)
            {
                int foundIndex = animalPersonalityDescription.IndexOf(lookedWord ,index, StringComparison.OrdinalIgnoreCase);

                if (foundIndex == -1)
                {
                    Console.Write(animalPersonalityDescription.Substring(index));
                    break;
                }

                if (foundIndex > index)
                {
                    Console.Write(animalPersonalityDescription.Substring(index ,(foundIndex - index)));
                }

                ConsoleHelper.ChangeTextColor("Green");
                Console.Write(animalPersonalityDescription.Substring(foundIndex ,lookedWord.Length));
                Console.ResetColor();

                index = foundIndex + lookedWord.Length;

                if (index >= animalPersonalityDescription.Length)
                {
                    break;
                }
            }

            Console.WriteLine();
        }

    }
}
