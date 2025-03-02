using msLearn.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace msLearn.CheckIfSomeRecordsAreEmpty
{
    internal static class FindEmptyRecords
    {
      
        public static void FindEmptyRecordsInDataBase()
        {
            bool isActiveDebugMode = false;
            
            PrintDebugModeInfo();
            int debugModeMenu = ConsoleHelper.GetNumberByReadLine();

            while (debugModeMenu == 1 || debugModeMenu == 2)
            {
                switch (debugModeMenu)
                {
                    case 0:
                        ContosoPetFriends.ShowMenuProgram();
                        break;
                    case 1:
                        isActiveDebugMode = true;
                        VerifyDatabase(isActiveDebugMode);
                        break;
                    case 2:
                        VerifyDatabase(isActiveDebugMode);
                        break;
                    default:
                        Console.WriteLine("\nNie rozpoznano wartości.");
                        FindEmptyRecordsInDataBase();
                        return;
                }
            }
        }

        private static void PrintDebugModeInfo()
        {
            Console.ResetColor();
            ConsoleHelper.PrintLine();
            Console.WriteLine("|\tWłączyć debugMode? \n|\t1.\tTak \n|\t2.\tNie \n|\t0.\tWyjdź do menu głownego");
            ConsoleHelper.PrintLine();
        }

        private static void VerifyDatabase(bool isActiveDebugMode)
        {
            Console.WriteLine();
            for (int i = 0; i < ContosoPetFriends.ourAnimals.GetLength(0); i++)
            {
                for (int j = 0; j < ContosoPetFriends.ourAnimals.GetLength(1); j++)
                {
                    if (j == AnimalId.index0) // Gatunek
                    {
                        LenghtOfIndeksys(i, j, AnimalProperty.SpeciesIndexPrefix, isActiveDebugMode);
                    }
                    if (j == AnimalId.index1) // Id
                    {
                        LenghtOfIndeksys(i, j, AnimalProperty.IdIndexPrefix, isActiveDebugMode);
                    }
                    if (j == AnimalId.index2) // Wiek
                    {
                        LenghtOfIndeksys(i, j, AnimalProperty.AgeIndexPrefix, isActiveDebugMode);
                    }
                    if (j == AnimalId.index3) // Wygląd
                    {
                        LenghtOfIndeksys(i, j, AnimalProperty.PhysicalDescriptionIndexPrefix, isActiveDebugMode);
                    }
                    if (j == AnimalId.index4) // Osobowość
                    {
                        LenghtOfIndeksys(i, j, AnimalProperty.PersonalityDescriptionIndexPrefix, isActiveDebugMode);
                    }
                    if (j == AnimalId.index5) // Nick
                    {
                        LenghtOfIndeksys(i, j, AnimalProperty.NickNameIndexPrefix, isActiveDebugMode);
                    }
                }
                ConsoleHelper.PrintLine();
            }
            Console.ReadLine();
        }

        private static void LenghtOfIndeksys(int i, int j, int animalPropertyIndexPrefix, bool debugModeIsActive)
        {
            int arrayIndexLength = ContosoPetFriends.ourAnimals[i, j].Length;
            int animalIdIteration = PropertyAnimalIdIndex(i, j);

            string arrayValue = ContosoPetFriends.ourAnimals[i, j].Substring(animalPropertyIndexPrefix);

            PrintDebugMessageArrayControll(i, j, debugModeIsActive, arrayIndexLength, animalIdIteration);

            VerifyIndexLenght(i, j, animalPropertyIndexPrefix, debugModeIsActive, arrayIndexLength, animalIdIteration, arrayValue);
        }
        private static void PrintDebugMessageArrayControll(int i, int j, bool debugModeIsActive, int arrayIndexLength, int iterationValue)
        {
            if (debugModeIsActive)
            {
                Console.WriteLine($"Index tablicy i = {i}, j = {j}");
                Console.WriteLine($"Zmienna iterationIndex = {iterationValue}");
                Console.WriteLine($"Zmienna indexLength = {arrayIndexLength}");
            }
        }

        private static void VerifyIndexLenght(int i, int j, int animalPropertyIndex, bool debugModeIsActive, int arrayIndexLength, int iterationValue, string arrayValue)
        {
            int indexController = arrayIndexLength - iterationValue;
            if (indexController == 0)
            {
                IndexIsEmptyMessage(i, j, arrayValue, indexController, debugModeIsActive);
            }
            else
            {
                IndexHasValueMessage(i, j, animalPropertyIndex, iterationValue, arrayIndexLength, debugModeIsActive);
            }
        }

        private static int PropertyAnimalIdIndex(int i, int j)
        {
            return j != 1
                ? ContosoPetFriends.ourAnimals[i, j].IndexOf(" ") + 1
                : ContosoPetFriends.ourAnimals[i, j].IndexOf(" ") + 4;
        }

        private static void IndexHasValueMessage(int i, int j, int animalPropertyIndex, int iterationIndex, int arrayIndexLength, bool debugModeIsActive)
        {
            int number = iterationIndex + animalPropertyIndex;
            if (debugModeIsActive)
            {
                Console.WriteLine($"Index tablicy i = {i}, j = {j}");
                Console.WriteLine($"Stały prefiks w wpisie ma = {arrayIndexLength} znaków:");
                Console.WriteLine($"Ilość liter w wpisie = {iterationIndex} + {animalPropertyIndex} = {number}");
            }
            ConsoleHelper.ChangeTextColor("Green");
            Console.WriteLine("OK");
            Console.ResetColor();
        }

        private static void IndexIsEmptyMessage(int i, int j, string arrayValue, int indexController, bool debugModeIsActive)
        {
            if (debugModeIsActive)
            {
                Console.WriteLine($"Index tablicy i = {i}, j = {j}");
                Console.WriteLine($"Index controller = {indexController}");
                ConsoleHelper.ChangeTextColor("Red");
                Console.WriteLine($"Wpis w bazie bez prefiksu: {arrayValue}");
                ConsoleHelper.ChangeTextColor("Yellow");
                Console.WriteLine($"Wpis w bazie z prefiksem: {ContosoPetFriends.ourAnimals[i, j]}");
                Console.ResetColor();
            }
            ConsoleHelper.ChangeTextColor("Magenta");
            Console.WriteLine("Brak wpisu");
            Console.ResetColor();
        }
    }
}
