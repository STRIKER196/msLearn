using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace msLearn // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? readUserValue;
            bool dataInput = false;
            int tryTaskOneCount = 1;
            int userReadText;

            Console.WriteLine("Podaj wartość, która mieście się w zakresie liczbowym 5-10");
            do
            {
                Console.WriteLine($"Próba nr: {tryTaskOneCount}");
                readUserValue = Console.ReadLine();
                if (readUserValue != null) // założenie ćwiczenia wiec musi zostać
                {
                    if (int.TryParse(readUserValue, out userReadText))
                    {
                        if (userReadText > 5 && userReadText < 10)
                        {

                            Console.Write($"Twoja wartość to: \"");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"{readUserValue}");
                            Console.ResetColor();
                            Console.WriteLine("\" i jest poprawna.");
                            dataInput = true;
                        }
                        else
                        {
                            Console.Write("Najwyraźniej twoja wartość jest nieprawidłowa.");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($" \"{readUserValue}\"");
                            Console.ResetColor();
                            Console.WriteLine("Przeczytaj instrukcję raz jeszcze i dostosuj się do niej.");
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Twoja wartość nie składa się z liczb. Przeczytaj instrukcję raz jeszcze i dostosuj się do niej.");
                        Console.ResetColor();
                    }
                }

                tryTaskOneCount++;

            } while (!dataInput);

            Console.WriteLine("\n\nDruga część zadania");

            string adm = "Administrator";
            string man = "Kierownik";
            string usr = "Użytkownik";
            bool verify = false;
            int tryTaskTwoCount = 1;
            string role;

            Console.WriteLine("Jaką role wykorzystujesz do działania programu");
            Console.WriteLine($"Dostępne role to:\n{adm}\t{man}\t{usr}");


            do
            {
                Console.WriteLine($"Próba weryfikacji roli nr: {tryTaskTwoCount}");
                Console.WriteLine("Wprowadz nazwę roli");
                role = Console.ReadLine()?.ToLower().Trim() ?? "";
                Console.WriteLine("");

            readResult = Console.ReadLine().ToLower() ?? "";
            if (readResult != null && int.TryParse().readRes)
            {
                menuSelection = readResult.ToLower();
            }
            while (!verify);
            Console.WriteLine("Logowanie udane :)");
            Console.ReadLine();
            // gotowe ćwicznie nie robiłemgo
            Console.WriteLine("\n\nTrzecia część zadania");

            string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
            int stringsCount = myStrings.Length;

            string myString = "";
            int periodLocation = 0;

            for (int i = 0; i < stringsCount; i++)
            {
                myString = myStrings[i];
                periodLocation = myString.IndexOf(".");

                string mySentence;

                // extract sentences from each string and display them one at a time
                while (periodLocation != -1)
                {

                    // first sentence is the string value to the left of the period location
                    mySentence = myString.Remove(periodLocation);

                    // the remainder of myString is the string value to the right of the location
                    myString = myString.Substring(periodLocation + 1);

                    // remove any leading white-space from myString
                    myString = myString.TrimStart();

                    // update the comma location and increment the counter
                    periodLocation = myString.IndexOf(".");

                    Console.WriteLine(mySentence);
                }

                mySentence = myString.Trim();
                Console.WriteLine(mySentence);
            }
        }
    }
}