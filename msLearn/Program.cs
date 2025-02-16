using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace msLearn
{
    internal class Program
    {
        public static string ChangeTextColor(string color)
        {
            string errorMessage = "Zła wartość koloru wysłana do Metody ConsoleColorChange()";
            if (Enum.TryParse(color, true, out ConsoleColor consoleColor)) { Console.ForegroundColor = consoleColor; return color; }
            return errorMessage;
        }
        static void Main(string[] args)
        {
            //zmienne wspisywane do tablicy
            string animalSpecies = "";
            string animalID = "";
            string animalAge = "";
            string animalPhysicalDescription = "";
            string animalPersonalityDescription = "";
            string animalNickname = "";
            int maxPets = 5;

            string[,] ourAnimals = new string[maxPets, 6];

            //wartości zmiennych wpisane do tablicy
            for (int i = 0; i < maxPets; i++)
            {
                if (i == 0)
                {
                    animalSpecies = "Pies";
                    animalID = "d1";
                    animalAge = "2";
                    animalPhysicalDescription = "Średniej wielkości, kremowa, samica golden retriever ważąca około 65 funtów. Nauczona czystości w domu.";
                    animalPersonalityDescription = "Uwielbia, gdy drapie się ją po brzuchu i lubi gonić swój ogon. Daje mnóstwo buziaków.";
                    animalNickname = "lola";
                }
                else if (i == 1)
                {
                    animalSpecies = "Pies";
                    animalID = "d2";
                    animalAge = "9";
                    animalPhysicalDescription = "Duży, czerwonobrązowy samiec golden retriever ważący około 85 funtów. Nauczony czystości w domu.";
                    animalPersonalityDescription = "Uwielbia, gdy pociera się mu uszy, gdy wita cię przy drzwiach – albo w każdej chwili! Lubi się przytulać i dawać psie uściski.";
                    animalNickname = "loki";
                }
                else if (i == 2)
                {
                    animalSpecies = "Kot";
                    animalID = "c3";
                    animalAge = "1";
                    animalPhysicalDescription = "Mała, biała samica ważąca około 8 funtów. Nauczona korzystania z kuwety.";
                    animalPersonalityDescription = "Przyjazna.";
                    animalNickname = "Puss";
                }
                else if (i == 3)
                {
                    animalSpecies = "Kot";
                    animalID = "c4";
                    animalAge = "?";
                    animalPhysicalDescription = "Mały, zwinny kot o miękkim futrze, który uwielbia drzemki na słońcu i zabawy z piórkami. Ciekawski, towarzyski i zawsze gotowy na przytulanie.";
                    animalPersonalityDescription = "Ma miękkie, puszyste futro, jest zwinny i szybki, ciekawski i towarzyski, uwielbia drzemki na słońcu, lubi zabawy z piórkami, jest przyjazny i skory do przytulania.";
                    animalNickname = "";
                }
                else if (i == 4)
                {
                    animalSpecies = "Papuga";
                    animalID = "p5";
                    animalAge = "?";
                    animalPhysicalDescription = "";
                    animalPersonalityDescription = "";
                    animalNickname = "";
                }
                else
                {
                    animalSpecies = "";
                    animalID = "";
                    animalAge = "";
                    animalPhysicalDescription = "";
                    animalPersonalityDescription = "";
                    animalNickname = "";
                }

                ourAnimals[i, 0] = "ID #: " + animalID;
                ourAnimals[i, 1] = "Species: " + animalSpecies;
                ourAnimals[i, 2] = "Age: " + animalAge;
                ourAnimals[i, 3] = "Nickname: " + animalNickname;
                ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
            }

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
                    ShowAllItemsInArray(ourAnimals);
                break;
                case "2":
                    GetNewAnimalRecord(maxPets, ourAnimals, animalID);
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
                readResult = Console.ReadLine() ?? "".Trim().Replace(".","");
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
                        // Przekazuje string w metodzie, ponieważ input moze być stringiem lub intem
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

        public static void ShowAllItemsInArray(string[,] animals)
        {
            Console.ResetColor();
            Console.Clear();

            for (int i = 0; i < animals.GetLength(0); i++)
            {
                int pageCounter = i + 1;

                Console.WriteLine("+--------------------------+-----------------------------------------------------------------------+");
                Console.WriteLine($"|     Pozycja              | index iteratora: i ={i}                                                  |");
                Console.WriteLine("+--------------------------+-----------------------------------------------------------------------+");

                for (int j = 0; j < animals.GetLength(1); j++)
                {
                    Console.WriteLine("+--------------------------+-----------------------------------------------------------------------+");
                    Console.WriteLine($"|{animals[i, j]}");
                    Console.WriteLine("+--------------------------+-----------------------------------------------------------------------+");
                }

                Console.WriteLine("\n");
                Console.WriteLine($"Strona: {pageCounter}");
                Console.WriteLine($"[{pageCounter}] of [{animals.GetLength(0)}]");
                Console.WriteLine("Wciśnij \"Enter\", aby kontynuuować");
                Console.ReadLine();
                Console.ResetColor();
                Console.Clear();
            }
        }
        public static string GetNewAnimalRecord(int maxPets, string[,] animalsDatabase, string animalID)
        {
            Console.ResetColor();
            string userValueInput = null;
            Console.Clear();
            ChangeTextColor("Blue");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
            Console.WriteLine($"|     Tryb edycji                                                                                  |");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
            ChangeTextColor("DarkBlue");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
            Console.WriteLine($"|     Do edycji możliwe jest MAX: {maxPets} pozycji.                                                       |");
            Console.WriteLine($"|     Aby edytować wpisy należy podać numer pozycji ID wpisu.                                      |");
            Console.WriteLine($"|     Dostępne pozycję to: 1, 2, 3, 4, 5, 6.                                                       |");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
            ChangeTextColor("Blue");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
            Console.WriteLine($"|     Wpisz \"Wróć\", się aby cofnąć się do Menu.                                                    |");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
            Console.ResetColor();

            bool hasAnimalIdChanged = false;

            while (!hasAnimalIdChanged)
            {

                Console.WriteLine("\nPodaj ID dla popozycji.\nID: ");
                userValueInput = Console.ReadLine()?.Trim() ?? "";

                if (!string.IsNullOrWhiteSpace(userValueInput))
                {
                    if (int.TryParse(userValueInput, out int currentAnimalIndex) && currentAnimalIndex >= 1 && currentAnimalIndex <= 4)
                    {
                        currentAnimalIndex = currentAnimalIndex - 1;
                        string newAnimalId;

                        Console.Clear();
                        ChangeTextColor("Blue");
                        Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
                        Console.WriteLine($"|     Tryb edycji   -->  Pozycja ID {userValueInput}  <{animalsDatabase[currentAnimalIndex, 1].Replace("Species: ", "")}>                                     |");
                        Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
                        Console.WriteLine($"|     Wpisz \"Wróć\", aby się cofnąć się do wyboru ID.                                             |");
                        Console.WriteLine("+--------------------------------------------------------------------------------------------------+");


                        newAnimalId = GetIdValue(animalID);
                        Console.WriteLine($"Wstawiono: {newAnimalId} jako nowe ID");
                        hasAnimalIdChanged = true;
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

            return hasAnimalIdChanged ? "Zmieniono ID zwierzęcia" : "Nie zmieniono ID zwierzęcia";
        }
        public static string GetIdValue(string userValue)
        {
            bool isAnimalIdValid = false;

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
                else if (userValue == "Wróć")
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
        //TODO: Usunąc po zakończeniu poprawek
    }
}