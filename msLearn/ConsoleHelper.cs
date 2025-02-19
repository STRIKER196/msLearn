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
                ConsoleHelper.ChangeTextColor("Red");
                Console.WriteLine("\nWpisz poprawna wartość.");
                Console.ResetColor();
            } while (true);
        }

        public static void PrintLineInConsole()
        {
            //Wypełnienie tabeli
            Console.ResetColor();
            ChangeTextColor("DarkBlue");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.ResetColor();
        }

        public static void PrintBackMessageInConsole()
        {
            Console.ResetColor();
            ChangeTextColor("Blue");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.WriteLine($"|0.   |    Wróć                                                                                      |");
            Console.WriteLine("+-----------------------------------------------------------------------------------------------------+");
            Console.ResetColor();
        }
    }
}
 