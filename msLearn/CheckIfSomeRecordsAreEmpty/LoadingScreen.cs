using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msLearn.CheckIfSomeRecordsAreEmpty
{
    internal class LoadingScreen
    {
        public static void Loading()
        {
            LoadingText();
            LoadingAnimation();
        }

        private static void LoadingText()
        {
            Console.Clear();
            ConsoleHelper.ChangeTextColor("Cyan");
            Console.WriteLine("\t\nTrwa wyszukiwanie pustych pól w bazie\n\n");
        }

        private static void LoadingAnimation()
        {
            int totalLenghtMark = 10;
            Console.Write("Ładowanie: [");

            for (int i = 0; i <= totalLenghtMark; i++)
            {
                Console.Write("█"); 
                Thread.Sleep(50);
            }

            Console.Write("] \n\n \tGotowe!\n\n");
            Console.WriteLine("Wciśnij \"Enter\", aby rozpocząć");
            Console.ReadLine();
        }
    }
}
