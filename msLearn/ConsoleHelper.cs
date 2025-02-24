using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msLearn
{
    internal class ConsoleHelper
    {
        public static string ChangeTextColor(string color)
        {
            string errorMessage = "Zła wartość koloru wysłana do Metody ConsoleColorChange()";

            if (Enum.TryParse(color, true, out ConsoleColor consoleColor)) 
            { 
                Console.ForegroundColor = consoleColor; 
                return color;
            }

            return errorMessage;
        }

        public static int GetNumberByReadLine()
        {
            do
            {
                ConsoleKeyInfo inputKey = Console.ReadKey();

                if (int.TryParse(inputKey.KeyChar.ToString(), out int key))
                {
                    return key;
                }
                ChangeTextColor("Red");
                Console.WriteLine("\nWpisz poprawna wartość.");
                Console.ResetColor();
            } while (true);
        }

        public static void PrintLine()
        {
            //Wypełnienie tabeli
            Console.ResetColor();
            ChangeTextColor("DarkBlue");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.ResetColor();
        }

        public static void PrintBackMessage()
        {
            Console.ResetColor();
            ChangeTextColor("Blue");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.WriteLine($"|0.   |    Wróć                                                                                       |");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.ResetColor();
        }
        public static void BackToMainMenu()
        {
            ConsoleHelper.ChangeTextColor("Red");
            Console.WriteLine("\n\n\tPowrót do głównego menu.\n\tWciśnij dowolny przycisk.");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            Program.Main([]);
        }
        public static void BackToEditModeMainScreen()
        {
            ConsoleHelper.ChangeTextColor("Red");
            Console.WriteLine("\n\n\tPowrót do wyboru zwierzęcia.\n\tWciśnij dowolny przycisk.");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            Program.Main([]);
        }
        public static void UserValueIsOverExpected()
        {
            ConsoleHelper.ChangeTextColor("Red");
            Console.WriteLine("\n\n\tWprowadzona wartość przez użytkownika jest większa lub mniejsza niż wskazana dopuszczalna wartość.\n\tWciśnij dowolny przycisk.");
            Console.ResetColor();
            Console.ReadKey();
            MenuEditMode.EditModeMenu();
        }
        public static void UnexpectedError()
        {
            ConsoleHelper.ChangeTextColor("Red");
            Console.WriteLine("\n\n\tWystąpił nieoczekiwany błąd.\n\tWciśnij dowolny przycisk.\n\tProgram uruchomi się ponownie");
            Console.ReadLine();
            Console.Clear();
            Program.Main([]);
        }
        public static void EditSuccessful()
        {
            ConsoleHelper.ChangeTextColor("Green");
            Console.WriteLine("\n\n\tOperacja zakończona.\n\tWciśnij dowolny przycisk.\n\tPowrót do menu edycji");
            Console.ReadLine();
            Console.Clear();
            MenuEditMode.EditModeMenu();
        }
    }
}
 