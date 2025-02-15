using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace msLearn
{
    internal class Program
    {
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
                    animalSpecies = "dog";
                    animalID = "d1";
                    animalAge = "2";
                    animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
                    animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                    animalNickname = "lola";
                }
                else if (i == 1)
                {
                    animalSpecies = "dog";
                    animalID = "d2";
                    animalAge = "9";
                    animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                    animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                    animalNickname = "loki";
                }
                else if (i == 2)
                {
                    animalSpecies = "cat";
                    animalID = "c3";
                    animalAge = "1";
                    animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                    animalPersonalityDescription = "friendly";
                    animalNickname = "Puss";
                }
                else if (i == 3)
                {
                    animalSpecies = "cat";
                    animalID = "c4";
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
                    ShowAllItemInArray(maxPets,ourAnimals);
                    break;
                deafault:
                    
                    Console.WriteLine("Soft in work");
                    break;
            }





            //ourAnimals[i, 0] = "ID #: " + animalID;
            //ourAnimals[i, 1] = "Species: " + animalSpecies;
            //ourAnimals[i, 2] = "Age: " + animalAge;
            //ourAnimals[i, 3] = "Nickname: " + animalNickname;
            //ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
            //ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
            // pause code execution
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
                        ConsoleColorChange("Magenta");
                        Console.WriteLine("Program nie rozpoznał wartości.");
                        Console.ResetColor();
                    }
                    correctReadResultValue = true;
                }
                else
                {
                    ConsoleColorChange("Red");
                    Console.WriteLine("Program nie rozpoznał wartości lub wciśnieto Enter.");
                    Console.ResetColor();
                }
                correctReadResultValue = false;
            }
            return readResult;
        }
        public static void ShowMenuProgram()
        {
            Console.Clear();

            Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:\n");

            Console.WriteLine("+----------+-------------------------------------------------------------------+");
            Console.WriteLine("| Pozycja  | Opis działania                                                    |");
            Console.WriteLine("+----------+-------------------------------------------------------------------+");
            Console.WriteLine("| 1.       | Wypisz wszystkie zarejestrowane zwięrzęta w bazie                 |");
            Console.WriteLine("| 2.       | Add a new animal friend to the ourAnimals array                   |");
            Console.WriteLine("| 3.       | Ensure animal ages and physical descriptions are complete         |");
            Console.WriteLine("| 4.       | Ensure animal nicknames and personality descriptions are complete |");
            Console.WriteLine("| 5.       | Edit an animal’s age                                              |");
            Console.WriteLine("| 6.       | Edit an animal’s personality description                          |");
            Console.WriteLine("| 7.       | Display all cats with a specified characteristic                  |");
            Console.WriteLine("| 8.       | Display all dogs with a specified characteristic                  |");
            Console.WriteLine("+----------+-------------------------------------------------------------------+");
            Console.WriteLine("| Exit     | Wpisz słowo \"Exit\", wby wyjść z programu                        |");
            Console.WriteLine("+----------+-------------------------------------------------------------------+");
        }
        public static string ConsoleColorChange(string color)
        {
            string errorMessage = "Zła wartość koloru wysłana do Metody ConsoleColorChange()";
            if (Enum.TryParse(color,true, out ConsoleColor consoleColor)) {Console.ForegroundColor = consoleColor; return color; }
            return errorMessage;
        }
        public static void ShowAllItemInArray(int pets, string[,] animals)
        {
            Console.Clear();

            for (int i = 0; i < pets; i++)
            {
                Console.WriteLine("+--------------------------+-----------------------------------------------------------------------+");
                Console.WriteLine($"|     Pozycja              | index iteracji: i ={i+1}                                                  |");
                Console.WriteLine("+--------------------------+-----------------------------------------------------------------------+");

                for (int j = 0; j < 6; j++)
                {
                    Console.WriteLine("+--------------------------+-----------------------------------------------------------------------+");
                    Console.WriteLine($"|{animals[i, j]}");
                    Console.WriteLine("+--------------------------+-----------------------------------------------------------------------+");
                }
                int page = i + 1;
                Console.WriteLine("\n");
                Console.WriteLine($"Strona: {page}");
                Console.WriteLine($"[{page}] of [{animals.GetLength(0)}]");
                Console.WriteLine("Wciśnij \"Enter\", aby kontynuuować");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}