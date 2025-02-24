using msLearn.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msLearn
{
    internal class EditModeMechanics
    {
        public static void EditAnimalProperty(int animalId, int animalPropertyId)
        {
            switch (animalPropertyId)
            {
                case AnimalPropertyId.Species: EditAnimalSpeciec(animalId); break;
                case AnimalPropertyId.Id: EditAnimalId(); break;
                case AnimalPropertyId.Age: EditAnimalAge(animalId); break;
                case AnimalPropertyId.PhysicalDescription: EditAnimalPhysicalDescription(animalId); break;
                case AnimalPropertyId.PersonalityDescription: EditAnimalPersonalDescription(animalId); break;
                case AnimalPropertyId.NickName: EditAnimalNick(animalId); break;
                
                default:
                    if (animalPropertyId > 6)
                    {
                        ConsoleHelper.UserValueIsOverExpected();
                    }
                    MenuEditMode.EditModeMenu();
                    break;
            }
        }
        public static void EditAnimalId()
        {
            PrintAnimalIdCannotBeModyfiet();
            PrintBackMessage();
        }
        public static void EditAnimalSpeciec(int animalId)
        {
            EditAnimalProperty(animalId, AnimalProperty.Species, AnimalPropertyId.Species, (i) => EditModeGui.PrintAnimalSpecies(i));
            PrintBackMessage();
            Console.ReadLine();
        }
        public static void EditAnimalAge(int animalId)
        {
            EditAnimalProperty(animalId, AnimalProperty.Age, AnimalPropertyId.Age, (i) => EditModeGui.PrintAnimalAge(i));
            PrintBackMessage();
        }
        public static void EditAnimalPhysicalDescription(int animalId)
        {
            EditAnimalProperty(animalId, AnimalProperty.PhysicalDescription, AnimalPropertyId.PhysicalDescription, (i) => EditModeGui.PrintAnimalPhysicalDescription(i));
            PrintBackMessage();
        }
        public static void EditAnimalPersonalDescription(int animalId)
        {
            EditAnimalProperty(animalId, AnimalProperty.PersonalityDescription, AnimalPropertyId.PersonalityDescription, (i) => EditModeGui.PrintAnimalPersonalityDescription(i));
            PrintBackMessage();
        }
        public static void EditAnimalNick(int animalId)
        {
            EditAnimalProperty(animalId, AnimalProperty.NickName, AnimalPropertyId.NickName, (i) => EditModeGui.PrintAnimalNick(i));
            PrintBackMessage();
        }

        public static void ShowEditErrorMessage()
        {
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("LightBlue");
            Console.WriteLine("\n Nowa wartość jest identyczna z poprzednią");
            Console.ResetColor();
        }
        public static void ShowEditSuccessMessage()
        {
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Green");
            Console.WriteLine("\n\nDane zostały zapisane poprawnie.");
            Console.ResetColor();
        }
        public static void PrintActivEditHelp()
        {
            ConsoleHelper.PrintLine();
            ConsoleHelper.ChangeTextColor("Green");
            Console.WriteLine("|\tZatwierdź nową wartość wciskając \"Enter\".");
            ConsoleHelper.PrintLine();
            Console.WriteLine("\nNową wartość:");
        }
        public static void PrintActiveEditLabel()
        {
            Console.WriteLine("");
            ConsoleHelper.PrintLine();
            ConsoleHelper.ChangeTextColor("Green");
            Console.WriteLine("|\tEdytujesz teraz:");
            ConsoleHelper.PrintLine();
        }

        public static void PrintBackMessage()
        {
            ConsoleHelper.PrintLine();
            Console.WriteLine("|\t Wcisnij \"Enter\", by przejść, aby kontynuować.");
        }

        private static void PrintAnimalIdCannotBeModyfiet() 
        {
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Red");
            Console.WriteLine("\n\tWartość Id jest generowan automatycznie na bazie 1 lotery gatunku i pozycji indeksu w bazie.");
            Console.ResetColor();
            Console.ReadKey();
        }
        /// <summary>
        /// Nadpisywanie wartości w tablicy [<paramref name="animalId"/>,<paramref name="animalPropertyId"/>], stringiem (<paramref name="animalPropertyName"/>+ ": " +userText) użytkownika. Drukowanie zmodyfikowanej wartości printAction (<paramref name="animalId"/).>
        /// </summary>
        /// <param name="animalId">ID zwierzęcia.</param>
        /// <param name="animalPropertyName">Stała wartość tekstowa.</param>
        /// <param name="animalPropertyId">Stałe ID właściwości zwierzęcia.</param>
        /// <param name="printAction">Przesyłanie wartości animalID do funkcji drukującej tekst.</param>
        private static void EditAnimalProperty(int animalId, string animalPropertyName, int animalPropertyId, Action<int> printAction)
        {

            Console.WriteLine("\nNowa wartość:");
            printAction(animalId);
            PrintActivEditHelp();
                
            string userText = Console.ReadLine() ?? string.Empty;
            string newUserValue = animalPropertyName + ": " + userText;

            EditCurrentAnimalValue(animalId, animalPropertyId, newUserValue);
            printAction(animalId);
        }
        private static void EditCurrentAnimalValue(int animalId, int animalPropertyId, string newValue)
        {
            Console.Clear();
            ConsoleHelper.PrintLine();
            Console.WriteLine("|\t Zapisywanie nowej wartości:");
            ConsoleHelper.PrintLine();
            Console.ResetColor();
            Console.WriteLine("Stara wartość:");
            ConsoleHelper.ChangeTextColor("DarkBlue");
            string currentValue = Program.ourAnimals[animalId, animalPropertyId];
            Console.WriteLine($"|\t{currentValue}");
            ConsoleHelper.PrintLine();

            if (currentValue == newValue)
            { 
                ShowEditErrorMessage();
                return;
            }
            Program.ourAnimals[animalId, animalPropertyId] = newValue;

            ShowEditSuccessMessage();
        }


    }
}
