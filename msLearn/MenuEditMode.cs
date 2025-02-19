using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace msLearn
{
    internal class MenuEditMode
    {
        public static void EditModeMenu()
        {
            DisplayEditModeLabel();

            int userValue = ConsoleHelper.GetNumberByReadLine();

            DisplayAnimalBy(userValue);

        }


        private static void DisplayEditModeLabel()
        {
            Console.Clear();
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Blue");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
            Console.Write("|"); 
            Console.ResetColor(); ConsoleHelper.ChangeTextColor("DarkCyan");
            Console.Write($"\tTryb edycji");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Blue");
            Console.WriteLine("                                                                                |");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
            Console.ResetColor();
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
        private static int EdytujWybranąPozycję()
        {
            int mleko = 0;
            return mleko;
        }
        public static void DisplayAnimalBy(int userValue)
        {
            bool isAnimalInEdit = false;
            userValue--;
            //Nagłowek tabeli wybranego zwierzecia
            DisplayAnimalLabel(userValue);

            //Dane wybrengo 
            DisplayAnimalSpeciesBy(userValue);
            DisplayAnimalIDBy(userValue);
            DisplayAnimalAgeBy(userValue);
            DisplayAnimalNickBy(userValue);
            DisplayAnimalPhysicsDescriptionBy(userValue);
            DisplayAnimalCharacterBy(userValue);
            //Separator - wcięcie
            ConsoleHelper.PrintLineInConsole();

            //Komunikat o wyborze parametru do edycji
            DisplayActions();

            //Wybór pola z menu
            int editIndex = ConsoleHelper.GetNumberByReadLine();
            ActionMenu(userValue, editIndex);

            //Stopka tabeli
            ConsoleHelper.PrintBackMessageInConsole();
        }

        private static void DisplayActions()
        {
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("LightBlue");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|\t1.   |    Edytuj gatunek         |2.    |    Edytuj id            |3.   |    Edytuj wiek           |");
            Console.WriteLine("|\t4.   |    Edytuj opis fizyczny   |5.    |    Edytuj charaktert    |6.   |    Edytuj imię           | ");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|\tWciśnij cyfrę od 1 - 6, aby edytować wskazaną pozycję.                                             |");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.ResetColor();
        }

        private static int ActionMenu(int userValue, int editIndex)
        {
            Console.ResetColor();
            Console.Clear();

            ActiveEdit(userValue);

            return editIndex;
        }

        private static string ActiveEdit(int userValue)
        {
            string newUserValue = string.Empty;
            bool correctValue = false;
            userValue++;

            if (userValue >= 1 && userValue < 7)
            { 
                while (!correctValue)
                {
                    ConsoleHelper.PrintLineInConsole();
                    ConsoleHelper.ChangeTextColor("Green");
                    Console.WriteLine("|\tEdytujesz teraz:");
                    ConsoleHelper.PrintLineInConsole();

                    if (userValue == 1)
                    {
                        DisplayAnimalSpeciesBy(userValue);
                    }
                    else if (userValue == 2)
                    {
                        Console.WriteLine("Wartość Id jest generowan automatycznie na bazie 1 lotery gatunku i pozycji indeksu w bazie.");
                    }
                    else if (userValue == 3)
                    {
                        DisplayAnimalAgeBy(userValue);
                    }
                    else if (userValue == 4)
                    {
                        DisplayAnimalPhysicsDescriptionBy(userValue);
                    }
                    else if (userValue == 5)
                    {
                        DisplayAnimalCharacterBy(userValue);
                    }
                    else if (userValue == 6)
                    {
                        DisplayAnimalNickBy(userValue);
                    }

                    ConsoleHelper.PrintLineInConsole();
                    ConsoleHelper.ChangeTextColor("Green");
                    Console.WriteLine("|\tZatwierdź nową wartość wciskając \"Enter\".");
                    ConsoleHelper.PrintLineInConsole();
                    Console.WriteLine("\nNową wartość:");

                    string text = Console.ReadLine() ?? string.Empty;

                    if (userValue == 1)
                    {
                        newUserValue = "Gatunek: " + text;
                    }
                    else if (userValue == 2)
                    {
                        Console.WriteLine("Wartość Id jest generowan automatycznie na bazie 1 lotery gatunku i pozycji indeksu w bazie.");
                    }
                    else if (userValue == 3)
                    {
                        newUserValue = "Wiek: " + text;
                    }
                    else if (userValue == 4)
                    {
                        newUserValue = "Opis fizyczny zwierzęcia: " + text;
                    }
                    else if (userValue == 5)
                    {
                        newUserValue = "Charakter: " + text;
                    }
                    else if (userValue == 6)
                    {
                        newUserValue = "Nick: " + text;
                    } 
                   
                    correctValue = true;
                }
            }
            else if (userValue == 0)
            {
                Console.WriteLine("WYBRANO WRÓĆ");
                Console.ReadKey();
                //MECHANIZAM WRÓĆ
            }
            else
            { 
                Console.WriteLine("coś się zjebało");
            }
            return newUserValue;
        }

        //private static string ValidateStringUserInput()
        //{
        //    bool hasEditModeMenuDisplayed = false;
        //    string? userValueInput = null;

        //    while (!hasEditModeMenuDisplayed)
        //    {
        //        Console.WriteLine("\nWybierz pozycję do edycji\nID: ");
        //        userValueInput = Console.ReadLine()?.Trim() ?? string.Empty;

        //        if (int.TryParse(userValueInput, out int currentAnimalIndex))
        //        {
        //            currentAnimalIndex--;
        //            if (!string.IsNullOrWhiteSpace(userValueInput))
        //            {
        //                string newAnimalId;
        //                newAnimalId = ValidateID();
        //                hasEditModeMenuDisplayed = true;
        //            }
        //            else if (userValueInput == "Wróć")
        //            {
        //                Console.Clear();
        //                Console.ForegroundColor = ConsoleColor.Yellow;
        //                Console.Write("Wybrano pozycję:");
        //                Console.ForegroundColor = ConsoleColor.Green;
        //                Console.WriteLine($" {userValueInput}");
        //                Console.Write("Program zamyka ");
        //                Console.ForegroundColor = ConsoleColor.Blue;
        //                Console.WriteLine("Tryb Edycji\n\n");
        //                Console.ResetColor();
        //                Console.WriteLine("Wciśnij \"Enter\", aby kontynuuować");
        //                Console.ResetColor();
        //                Console.ReadKey();
        //                Program.Main([]);
        //                break;
        //            }
        //            else
        //            {
        //                ConsoleHelper.ChangeTextColor("Red");
        //                Console.WriteLine($"Podano wartości z poza zakresu lub wprowadzono niewłaściwą wartość.\nPodana wartość: {userValueInput}");
        //                Console.ResetColor();
        //            }
        //        }
        //    }
        //    return userValueInput;
        //}
        // Tylko nagłowek z Menu z pozycją użytkownika
        private static void DisplayAnimalLabel(int byFirstUserIndex)
        {
            byFirstUserIndex++;
            Console.Clear();
            ConsoleHelper.ChangeTextColor("Blue");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.Write("|");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkCyan");
            Console.Write($" Tryb edycji   -->  Wartość użytkownika \"{byFirstUserIndex}\"  ");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Blue");
            Console.WriteLine("\t\t\t\t\t\t\t   |");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.ResetColor();
        }

        // Wartości z Bazy
        public static void DisplayAnimalIDBy(int userValue)
        {
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.Write($"|");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Yellow");
            Console.Write($"\t{Program.ourAnimals[userValue, 0]} \n");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.Write($"|\n");
            Console.ResetColor();

        }
        public static void DisplayAnimalAgeBy(int userValue)
        {
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.Write($"|");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Yellow");
            Console.Write($"\t{Program.ourAnimals[userValue, 1]} \n");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.Write($"|\n");
            Console.ResetColor();

        }
        public static void DisplayAnimalSpeciesBy(int userValue)
        {
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.Write($"|");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Yellow");
            Console.Write($"\t{Program.ourAnimals[userValue, 2]} \n");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.Write($"|\n");
            Console.ResetColor();
        }
        public static void DisplayAnimalNickBy(int userValue)
        {
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.Write($"|");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Yellow");
            Console.Write($"\t{Program.ourAnimals[userValue, 3]} \n");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.Write($"|\n");
            Console.ResetColor();
        }
        public static void DisplayAnimalPhysicsDescriptionBy(int userValue)
        {
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.Write($"|");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Yellow");
            Console.Write($"\t{Program.ourAnimals[userValue, 4]} \n");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.Write($"|\n");
            Console.ResetColor();
        }
        public static void DisplayAnimalCharacterBy(int userValue)
        {
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.Write($"|");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Yellow");
            Console.Write($"\t{Program.ourAnimals[userValue, 5]} \n");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.Write($"|\n");
            Console.ResetColor();
        }

    }
}
