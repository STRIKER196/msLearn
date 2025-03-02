using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace msLearn.PrintAllAnimalsInfo
{
    internal class MenuAnimalsList
    {
        public static void ManageAction()
        {
            Console.ResetColor();
            Console.Clear();

            AnimalDatabasePrinter.PrintAllOneAnimalAtPage();
        }
    }
}
