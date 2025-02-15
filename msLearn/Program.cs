﻿using System;
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

            Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:\n");

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
        public static string GetNewAnimalRecord(int maxPets, string[,] newRecordInArray, string animalID)
        {
            Console.ResetColor();
            string readResult = null;

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
            Console.WriteLine("\nPodaj ID dla popozycji.\nID: ");

            readResult = Console.ReadLine() ?? "".Trim();

            bool editData = true;
            while (editData)
            {            //ourAnimals[i, 0] = "ID #: " + animalID;
                         //ourAnimals[i, 1] = "Species: " + animalSpecies;
                         //ourAnimals[i, 2] = "Age: " + animalAge;
                         //ourAnimals[i, 3] = "Nickname: " + animalNickname;
                         //ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                         //ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
                if (readResult != null && !string.IsNullOrWhiteSpace(readResult))
                {
                    if (readResult == "1" || readResult == "2" ||
                        readResult == "3" || readResult == "4" )
                    {
                        int.TryParse(readResult, out int x);
                        x = x + 1;
                        string newAnimalId;
                        Console.Clear();
                        ChangeTextColor("Blue");
                        Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
                        Console.WriteLine($"|     Tryb edycji   -->  Pozycja ID {readResult} < {newRecordInArray[x, 1].Replace("Species: ", "")}>                                     |");
                        Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
                        Console.WriteLine($"|     Wpisz \"Wróć\", aby się cofnąć się do wyboru ID.                                             |");
                        Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
                        newAnimalId = GetIdValue(animalID);


                    }
                    else if (readResult == "Wróć")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Wybrano pozycję:");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($" {readResult}");
                        Console.Write("Program się zamyka tryb");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Edycji\n\n");
                        Console.ResetColor();
                        Console.WriteLine("Wciśnij \"Enter\", aby kontynuuować");
                        Console.ReadKey();
                        Console.ResetColor();
                        continue;
                    }
                    else
                    {
                        ChangeTextColor("Red");
                        Console.WriteLine($"Podano wartości z poza zakresu lub wprowadzono niewłaściwą wartość.\nPodana wartość: {readResult}");
                        Console.ResetColor();
                    }
                    
                }
            }
            string GetIdValue(string id)
            {
                bool correctInput = false;
                bool goBack = false;
                if (!goBack)
                {
                    while (!correctInput)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("ID: ");
                        id = Console.ReadLine() ?? "".Trim();
                        if (id != null && !string.IsNullOrWhiteSpace(id))
                        {
                            Console.ResetColor();
                            Console.WriteLine($"Wprowadzono {id}");
                            
                            correctInput = true;
                            break;
                        }
                        else if (id == "Wróć")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Wprowadzono:");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($" {id}");
                            Console.Write("Powrót do wyboru pozycji z Bazy");
                            Console.ResetColor();
                            Console.WriteLine("Wciśnij \"Enter\", aby kontynuuować");
                            Console.ReadKey();
                            goBack = true;
                            Console.ResetColor();
                            break;
                        }
                        else
                        {
                            ChangeTextColor("Red");
                            Console.WriteLine($"Wprowadzono niewłaściwą wartość.\nPodana wartość: {readResult}");
                            Console.ResetColor();
                            correctInput = false;
                            continue;
                        }
                    }
                }
                else
                {
                    id = "Wróć"; 
                }
                return id;
            }
            return "";
        }
    }
}