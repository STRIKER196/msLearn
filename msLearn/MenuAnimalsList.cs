﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace msLearn
{
    internal class MenuAnimalsList
    {
        public static void ManageAction()
        {
            Console.ResetColor();
            Console.Clear();

            PrintAllAnimalsInDataBase.PrintAllOneAnimalAtPage();
        }


    }
}
