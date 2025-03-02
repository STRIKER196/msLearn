using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msLearn.CheckIfSomeRecordsAreEmpty
{
    internal class MenuPrintEmptyPositionsInDataBase
    {
        public static void MenuLookForEmptyWord()
        {
            PrintFunction();

            int userOption = ConsoleHelper.GetNumberByReadLine();

            switch (userOption)
            {
                case 0:
                    ConsoleHelper.BackToMainMenu();
                    break;
                case 1:
                    CheckEmptyRecords();
                    break;
                default:
                    ConsoleHelper.BackToMainMenu();
                    break;
            }
            UnexpectedValue();

            
            Console.ReadLine();
        }

        private static void UnexpectedValue()
        {
            ConsoleHelper.PrintLine();
            ConsoleHelper.ChangeTextColor("Red");
            Console.WriteLine("\n\n\tProgram przechwycił nieobsługiwalną wartość.\n\tNastąpi restart Menu.\n\tWciśnij dowolny przycisk.");
            ConsoleHelper.PrintLine();
            MenuLookForEmptyWord();
        }

        private static void PrintFunction()
        {
            Console.Clear();
            ConsoleHelper.PrintLine();
            ConsoleHelper.ChangeTextColor("Magenta");
            Console.Write("| 1.\tUruchom program.\n| 0. \tPowrót do menu głównego\n");
            ConsoleHelper.PrintLine();

        }
        private static void CheckEmptyRecords()
        {
            LoadingScreen.Loading();
            FindEmptyRecords.FindEmptyRecordsInDataBase();

        }


    }
}
