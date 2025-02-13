using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace msLearn // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? userValue;
            bool dataInput = false;
            int tryTaskOneCount = 1;

            Console.WriteLine("Podaj wartość, która mieście się w zakresie liczbowym 5-10");
            do
            {
                Console.WriteLine($"Próba nr: {tryTaskOneCount}");
                userValue = Console.ReadLine();
                if (userValue != null)
                {
                    if (int.TryParse(userValue, out var userReadText))
                    {
                        if (userReadText >= 5 && userReadText <= 10)
                        {
                            
                            Console.Write($"Twoja wartość to: \"");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"{userValue}");
                            Console.ResetColor();
                            Console.WriteLine("\" i jest poprawna.");
                            dataInput = true;
                        }
                        else 
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Najwyraźniej twoja wartość jest nieprawidłowa.");
                            Console.WriteLine($" \"{userValue}\"");
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

            }while (dataInput == false);

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

                if (!string.IsNullOrWhiteSpace(role))
                {
                    if (role == adm.ToLower() ||
                        role == man.ToLower() ||
                        role == usr.ToLower())
                    {
                        Console.Write("Wprowadzono wartość: (");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"{role}");
                        Console.ResetColor();
                        Console.WriteLine(") została zaakceptowana");
                        verify = true;
                    }
                    else 
                    {
                        Console.Write("Rola która wprowadzono '");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{role}");
                        Console.ResetColor();
                        Console.WriteLine("' nie odpowiada przedstawionemu schematowi");
                        Console.Write("Dostępne role to:");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\n{adm}\t{man}\t{usr}");
                        Console.ResetColor();
                    }
                }
                else
                {

                    Console.WriteLine("Twoja wprowadzona wartość musi być pusta lub posiadać sam znak biały");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\"  \"");
                    Console.WriteLine(". Popraw swoją wartość i wprowadź odpowiednią role");
                    Console.ResetColor();
                }
                tryTaskTwoCount++;
            }
            while (!verify);
            Console.WriteLine("Logowanie udane :)");
            Console.ReadLine();
        }
    }
}