using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using msLearn2;

namespace msLearn
{
    internal class Program
    {
        private static string[,] ourAnimals = AnimalsDataHolder.GetSampleData();

        public static string ChangeTextColor(string color)
        {
            string errorMessage = "Zła wartość koloru wysłana do Metody ConsoleColorChange()";
            if (Enum.TryParse(color, true, out ConsoleColor consoleColor)) { Console.ForegroundColor = consoleColor; return color; }
            return errorMessage;
        }
        static void Main(string[] args)
        {
            // TUTAJ RESTART
            ShowMenuProgram();

            string menuSelection = GetMenuOption();

            Console.Write("Wybrano pozycję:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" {menuSelection}.");
            Console.ResetColor();
            Console.WriteLine("Wciśnij \"Enter\", aby rozpocząć");
            Console.ReadKey();

            switch (menuSelection)
            {
                case "1":
                    ShowAllItemsInArray();
                    break;
                case "2":
                    ShowEditModeMenu();
                    break;
                case "3":
                    Console.WriteLine("Oprogramowanie w trakcie pracy");
                    break;
                case "4":
                    Console.WriteLine("Oprogramowanie w trakcie pracy");
                    break;

            }
        }


        public static string GetMenuOption()
        {
            
            string readResult = null;
            bool correctReadResultValue = false;
            
            while (!correctReadResultValue)
            {
                Console.WriteLine("\nWprowadz wartość pozycji, którą ma wykonać program");
                readResult = (Console.ReadLine() ?? "").Trim().Replace(".","");
                if (readResult != null && !string.IsNullOrWhiteSpace(readResult))
                {
                    if (readResult == "Exit")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Wybrano pozycję:");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($" {readResult}");
                        Console.WriteLine("Program się zamyka...\n\n");
                        Console.WriteLine("Wciśnij \"Enter\", aby kontynuuować");
                        Console.ReadKey();
                        Environment.Exit(0);

                    }
                    else if
                    (
                        readResult == "1" || readResult == "2" ||
                        readResult == "3" || readResult == "4" ||
                        readResult == "5" || readResult == "6" ||
                        readResult == "7" || readResult == "8"
                    ) 
                    {
                        break;
                    }
                    else
                    {
                        ChangeTextColor("Magenta");
                        Console.WriteLine("Program nie rozpoznał wartości.");
                        Console.ResetColor();
                    }
                    correctReadResultValue = true;
                }
                else
                {
                    ChangeTextColor("Red");
                    Console.WriteLine("Program nie rozpoznał wartości lub wciśnieto Enter.");
                    Console.ResetColor();
                }
                correctReadResultValue = false;
            }
            return readResult;
        }
        public static void ShowMenuProgram()
        {
            Console.ResetColor();
            Console.Clear();

            Console.WriteLine("Wiraj w aplikacji Contoso PetFriends. Dostepne opcje to:\n");

            Console.WriteLine("+----------+-------------------------------------------------------------------+");
            Console.WriteLine("| Pozycja  | Opis działania                                                    |");
            Console.WriteLine("+----------+-------------------------------------------------------------------+");
            Console.WriteLine("| 1.       | Wypisz wszystkie zarejestrowane zwięrzęta w bazie.                |");
            Console.WriteLine("| 2.       | Tryb Edycji.                                                      |");
            Console.WriteLine("| 3.       | Wyświetl wybrane wszystkie zwierzęta o danym charakterze.         |");
            Console.WriteLine("| 4.       | Sprawdź nieuzupełnione pola w Archiwum.                           |");
            Console.WriteLine("+----------+-------------------------------------------------------------------+");
            Console.WriteLine("| Exit     | Wpisz słowo \"Exit\", wby wyjść z programu.                         |");
            Console.WriteLine("+----------+-------------------------------------------------------------------+");
            Console.ResetColor();
        }



        //Wejście W tryb Edycji
        public static void ShowEditModeMenu()
        {
            Console.Clear();
            Console.ResetColor();
            ChangeTextColor("Blue");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
            Console.Write("|"); Console.ResetColor(); ChangeTextColor("DarkCyan"); Console.Write($"\tTryb edycji"); Console.ResetColor(); ChangeTextColor("Blue"); Console.WriteLine("                                                                                |");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
            Console.ResetColor();
            ChangeTextColor("DarkBlue");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
            Console.WriteLine($"|\tDo edycji możliwe jest MAX: {ourAnimals.GetLength(0)} pozycji.                                                     |");
            Console.WriteLine($"|\tAby edytować wpisy należy podać numer pozycji ID w bazie.                                  |");
            Console.WriteLine($"|\tDostępne pozycję ID to: 1, 2, 3, 4, 5, 6.                                                  |");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
            Console.ResetColor();
            ChangeTextColor("Blue");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
            Console.WriteLine($"|\tWpisz \"Wróć\", się aby cofnąć się do Menu.                                                  |");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
            Console.ResetColor();

            string userValueInput = ValidateUserInput();

            ShowCurrentAnimalEditModeMenu(userValueInput);

        }

        //Sprawdź poprawnie wprowadzone ID
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
                        ChangeTextColor("Red");
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
            ChangeTextColor("Blue");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
            Console.Write("|");
            Console.ResetColor();
            ChangeTextColor("DarkCyan");
            Console.Write($" Tryb edycji   -->  Wartość użytkownika \"{CurrentUserValueInput}\"");
            Console.ResetColor(); ChangeTextColor("Blue");
            Console.WriteLine("\t\t\t\t\t\t\t   |");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+-------------------------------------------------------+");
            Console.ResetColor();
            ChangeTextColor("DarkBlue");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------------------------------------+");
            Console.Write($"|");
            Console.ResetColor();
            ChangeTextColor("Yellow");
            Console.Write($"\t {ourAnimals[currentAnimalIndex, 0]}");
            Console.ResetColor();
            ChangeTextColor("DarkBlue");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t   |");
            Console.ResetColor();
            ChangeTextColor("DarkBlue");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------------------------------------+");
            Console.Write($"|"); 
            Console.ResetColor(); 
            ChangeTextColor("Yellow"); 
            Console.Write($"\t{ourAnimals[currentAnimalIndex, 1]}"); 
            Console.ResetColor(); ChangeTextColor("DarkBlue");
             Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t  |");
            Console.ResetColor();
            ChangeTextColor("DarkBlue");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------------------------------------+");
            Console.Write($"|"); Console.ResetColor(); ChangeTextColor("Yellow"); Console.Write($"\t{ourAnimals[currentAnimalIndex, 2]}"); Console.ResetColor(); ChangeTextColor("DarkBlue"); Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t   |");
            Console.ResetColor();
            ChangeTextColor("DarkBlue");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------------------------------------+");
            Console.Write($"|"); Console.ResetColor(); ChangeTextColor("Yellow"); Console.Write($"\t{ourAnimals[currentAnimalIndex, 3]}");
            Console.ResetColor(); ChangeTextColor("DarkBlue");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t   |");
            Console.ResetColor();
            ChangeTextColor("DarkBlue");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------------------------------------+");
            Console.Write($"|"); Console.ResetColor();
            ChangeTextColor("Yellow");
            Console.Write($"\t{ourAnimals[currentAnimalIndex, 4]}");
            Console.ResetColor();
            ChangeTextColor("DarkBlue"); Console.WriteLine("\t\t\t|");
            Console.ResetColor();
            ChangeTextColor("DarkBlue");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------------------------------------+");
            Console.Write($"|"); Console.ResetColor(); ChangeTextColor("Yellow");
            Console.Write($"\t{ourAnimals[currentAnimalIndex, 5]}");
            Console.ResetColor();
            ChangeTextColor("DarkBlue");
            Console.WriteLine("\t|");
            Console.ResetColor();
            ChangeTextColor("DarkBlue");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------------------------------------------------------+");
            Console.ResetColor();
            ChangeTextColor("Blue");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+-------------------------------------------------------+");
            Console.WriteLine($"|Wpisz \"Wróć\", aby się cofnąć się do wyboru ID.                                                    |");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
            Console.ResetColor();

            return CurrentUserValueInput;
        }
        public static void ShowEditModeMenuSeletion()
        { 

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
