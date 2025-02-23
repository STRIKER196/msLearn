using msLearnData;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace msLearn
{
    internal class MenuEditMode
    {
        public static void EditModeMenu()
        {
            EditModeGui.ShowEditModeTitle();

            int animalId = ConsoleHelper.GetNumberByReadLine();

            EditModeGui.ShowAnimalInfo(animalId);

            EditModeGui.DisplayActions();

            ConsoleHelper.PrintBackMessage();

            int animalPropertyId = ConsoleHelper.GetNumberByReadLine() - 1;

            EditModeMechanics.EditAnimalProperty(animalId, animalPropertyId);

            Console.Clear();
            Program.Main([]);
        }
    }
}
