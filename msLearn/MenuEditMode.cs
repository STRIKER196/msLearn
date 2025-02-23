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

            if (animalId > 0 && animalId < 9)
            {
                EditModeGui.ShowAnimalInfo(animalId);

                EditModeGui.DisplayActions();

                ConsoleHelper.PrintBackMessage();

                int animalPropertyId = ConsoleHelper.GetNumberByReadLine() - 1;
                EditModeMechanics.EditAnimalProperty(animalId, animalPropertyId);
            }
            if (animalId == 0) { Program.Main([]); }

            ConsoleHelper.UserValueIsOverExpected();
            EditModeMenu();
        }

    }
}
