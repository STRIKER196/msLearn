using msLearn.Constants;
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

            bool isAnimalIdsCorrect = false;
            while (!isAnimalIdsCorrect)
            {
                int animalId = GetAnimalId();

                if (animalId > 0 && animalId < 6)
                {
                    PrintAnimalIdHeader(animalId);

                    int animalPropertyId = GetAnimalPropertyId();

                    ActiveEditAnimalProperty(animalId, animalPropertyId);

                    ConsoleHelper.EditSuccessful();
                }
                if (animalId == 0)
                {
                    ConsoleHelper.BackToMainMenu();
                }
                ConsoleHelper.UserValueIsOverExpected();
                Console.ReadLine();
                Console.Clear();
                EditModeMenu();
            }
            ConsoleHelper.UnexpectedError();
        }

        private static void ActiveEditAnimalProperty(int animalId, int animalPropertyId)
        {
            EditModeMechanics.EditAnimalProperty(animalId, animalPropertyId);
        }

        private static int GetAnimalId()
        {
            return ConsoleHelper.GetNumberByReadLine();
        }
        private static int GetAnimalPropertyId()
        {
            int animalPropertyId = ConsoleHelper.GetNumberByReadLine() - 1; /// animalPropertyId (1-6) and -1 is for index in array
            return animalPropertyId;
        }
        private static void PrintAnimalIdHeader(int animalId)
        {
            EditModeGui.ShowAnimalInfo(animalId);
            EditModeGui.DisplayActions();
            ConsoleHelper.PrintBackMessage();
        }
    }
}
