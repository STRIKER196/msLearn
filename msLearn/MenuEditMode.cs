using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msLearn
{
    internal class MenuEditMode
    {
        public static void ManageAction()
        { 
            ShowEditModeMenu();
        }
 
        private static void ShowEditModeMenu()
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
            Console.WriteLine($"|\tDostępne pozycję ID to: 1, 2, 3, 4, 5, 6.                                                  |");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Blue");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
            Console.WriteLine($"|\tWpisz \"Wróć\", się aby cofnąć się do Menu.                                                  |");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
            Console.ResetColor();

            string userValueInput = ValidateUserInput();

            ShowCurrentAnimalEditModeMenu(userValueInput);

        }

        public static string ValidateUserInput()
        {
            bool hasEditModeMenuDisplayed = false;
            string userValueInput = null;

            while (!hasEditModeMenuDisplayed)
            {
                Console.WriteLine("\nPodaj ID dla popozycji.\nID: ");
                userValueInput = Console.ReadLine()?.Trim() ?? string.Empty;

                if (int.TryParse(userValueInput, out int currentAnimalIndex) && currentAnimalIndex >= 1 && currentAnimalIndex <= 6)
                {
                    currentAnimalIndex--;
                    if (!string.IsNullOrWhiteSpace(userValueInput))
                    {
                        string newAnimalId;
                        newAnimalId = ValidateID();
                        hasEditModeMenuDisplayed = true;
                    }
                    else if (userValueInput == "Wróć")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Wybrano pozycję:");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($" {userValueInput}");
                        Console.Write("Program zamyka ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Tryb Edycji\n\n");
                        Console.ResetColor();
                        Console.WriteLine("Wciśnij \"Enter\", aby kontynuuować");
                        Console.ResetColor();
                        Console.ReadKey();
                        Main([]);
                        break;
                    }
                    else
                    {
                        ConsoleHelper.ChangeTextColor("Red");
                        Console.WriteLine($"Podano wartości z poza zakresu lub wprowadzono niewłaściwą wartość.\nPodana wartość: {userValueInput}");
                        Console.ResetColor();
                    }
                }
            }
            return userValueInput;
        }
        public static string ShowCurrentAnimalEditModeMenu(string CurrentUserValueInput)
        {
            int currentAnimalIndex = 0;

            Console.Clear();
            //Wyświetl Wybraną pozycję
            ConsoleHelper.ChangeTextColor("Blue");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
            Console.Write("|");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkCyan");
            Console.Write($" Tryb edycji   -->  Wartość użytkownika \"{CurrentUserValueInput}\"");
            Console.ResetColor(); ConsoleHelper.ChangeTextColor("Blue");
            Console.WriteLine("\t\t\t\t\t\t\t   |");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+-------------------------------------------------------+");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------------------------------------+");
            Console.Write($"|");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Yellow");
            Console.Write($"\t {ourAnimals[currentAnimalIndex, 0]}");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t   |");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------------------------------------+");
            Console.Write($"|");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Yellow");
            Console.Write($"\t{ourAnimals[currentAnimalIndex, 1]}");
            Console.ResetColor(); ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t  |");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------------------------------------+");
            Console.Write($"|"); Console.ResetColor(); ConsoleHelper.ChangeTextColor("Yellow"); Console.Write($"\t{ourAnimals[currentAnimalIndex, 2]}"); Console.ResetColor(); ConsoleHelper.ChangeTextColor("DarkBlue"); Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t   |");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------------------------------------+");
            Console.Write($"|"); Console.ResetColor(); ConsoleHelper.ChangeTextColor("Yellow"); Console.Write($"\t{ourAnimals[currentAnimalIndex, 3]}");
            Console.ResetColor(); ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t   |");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------------------------------------+");
            Console.Write($"|"); Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Yellow");
            Console.Write($"\t{ourAnimals[currentAnimalIndex, 4]}");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue"); Console.WriteLine("\t\t\t|");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------------------------------------+");
            Console.Write($"|"); Console.ResetColor(); ConsoleHelper.ChangeTextColor("Yellow");
            Console.Write($"\t{ourAnimals[currentAnimalIndex, 5]}");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.WriteLine("\t|");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("DarkBlue");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------------------------------------+");
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Blue");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+-------------------------------------------------------+");
            Console.WriteLine($"|Wpisz \"Wróć\", aby się cofnąć się do wyboru ID.                                                    |");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
            Console.ResetColor();

            return CurrentUserValueInput;
        }
        private static void ShowAllItemsInArray()
        {
            for (int i = 0; i < Program.ourAnimals.GetLength(0); i++)
            {
                int pageCounter = i + 1;

                Console.WriteLine("+--------------------------+-----------------------------------------------------------------------+");
                Console.WriteLine($"|     Pozycja              | index iteratora: i ={i}                                                  |");
                Console.WriteLine("+--------------------------+-----------------------------------------------------------------------+");

                for (int j = 0; j < Program.ourAnimals.GetLength(1); j++)
                {
                    Console.WriteLine("+--------------------------+-----------------------------------------------------------------------+");
                    Console.WriteLine($"|{Program.ourAnimals[i, j]}");
                    Console.WriteLine("+--------------------------+-----------------------------------------------------------------------+");
                }

                Console.WriteLine("\n");
                Console.WriteLine($"Strona: {pageCounter}");
                Console.WriteLine($"[{pageCounter}] of [{Program.ourAnimals.GetLength(0)}]");
                Console.WriteLine("Wciśnij \"Enter\", aby kontynuuować");
                Console.ReadLine();
                Console.ResetColor();
                Console.Clear();
            }
        }
        //Edycja pola AnimalID
        public static string ValidateID()
        {

            bool isAnimalIdValid = false;
            string userValue = string.Empty;
            while (!isAnimalIdValid)
            {
                Console.WriteLine("\nID: ");
                userValue = Console.ReadLine()?.Trim() ?? "";

                if (!string.IsNullOrWhiteSpace(userValue))
                {
                    Console.ResetColor();
                    Console.WriteLine($"Wprowadzono {userValue}");
                    isAnimalIdValid = true;
                }
                else if (userValue == "Wróć") // Zrobić powrót do wyboru opcji edycji
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Wprowadzono:");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($" {userValue}");
                    Console.Write("Powrót do wyboru pozycji z Bazy");
                    Console.ResetColor();
                    Console.WriteLine("Wciśnij \"Enter\", aby kontynuuować");
                    Console.ReadKey();
                    Console.ResetColor();
                    return "Wróć";
                }
                else
                {
                    ChangeTextColor("Red");
                    Console.WriteLine($"Wprowadzono niewłaściwą wartość.\nPodana wartość: {userValue}");
                    Console.ResetColor();
                }
            }
            return userValue;
        }
    }
}
