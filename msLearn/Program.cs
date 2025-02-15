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

            int maxPets = 8;
            string? readResult;
            string menuSelection = "";

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


            Console.Clear();

            Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:\n");

            Console.WriteLine("+----------+-------------------------------------------------------------------+");
            Console.WriteLine("| Pozycja  | Opis działania                                                    |");
            Console.WriteLine("+----------+-------------------------------------------------------------------+");
            Console.WriteLine("| 1.       | List all of our current pet information                           |");
            Console.WriteLine("| 2.       | Add a new animal friend to the ourAnimals array                   |");
            Console.WriteLine("| 3.       | Ensure animal ages and physical descriptions are complete         |");
            Console.WriteLine("| 4.       | Ensure animal nicknames and personality descriptions are complete |");
            Console.WriteLine("| 5.       | Edit an animal’s age                                              |");
            Console.WriteLine("| 6.       | Edit an animal’s personality description                          |");
            Console.WriteLine("| 7.       | Display all cats with a specified characteristic                  |");
            Console.WriteLine("| 8.       | Display all dogs with a specified characteristic                  |");
            Console.WriteLine("+----------+-------------------------------------------------------------------+");
            Console.WriteLine("| Exit     | Wpisz słowo \"Exit\", wby wyjść z programu                          |");
            Console.WriteLine("+----------+-------------------------------------------------------------------+");

            Console.WriteLine("\nEnter your selection number (or type Exit to exit the program)");

            bool correctReadResultValue = false;

            while (!correctReadResultValue)
            {
                readResult = Console.ReadLine()?.ToLower() ?? "";
                if (readResult != null && !string.IsNullOrWhiteSpace(readResult)){correctReadResultValue = true;}
            }

            Console.Write("You selected menu option");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" {menuSelection}.");
            Console.ResetColor();
            Console.WriteLine("Press the Enter key to continue");

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("+--------------------------+------------------------------------------+");
                Console.WriteLine($"|\tProperty\t\t\t\t\t\tindex: i ={i}\t\t|\tValue\t\t\t\t|");
                Console.WriteLine("+--------------------------+------------------------------------------+");

                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("+--------------------------+------------------------------------------+");
                    Console.WriteLine($"|{ourAnimals[i, j]}");
                    Console.WriteLine("+--------------------------+------------------------------------------+");
                }
                Console.WriteLine("");

            }

            //ourAnimals[i, 0] = "ID #: " + animalID;
            //ourAnimals[i, 1] = "Species: " + animalSpecies;
            //ourAnimals[i, 2] = "Age: " + animalAge;
            //ourAnimals[i, 3] = "Nickname: " + animalNickname;
            //ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
            //ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

            // pause code execution
            readResult = Console.ReadLine();
        }
    }
}