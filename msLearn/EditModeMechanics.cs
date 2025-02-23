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
                case AnimalID.Species: EditAnimalSpeciec(animalId); break;
                case AnimalID.Id: EditAnimalId(); break;
                case AnimalID.Age: EditAnimalAge(animalId); break;
                case AnimalID.PhysicalDescription: EditAnimalPhysicalDescription(animalId); break;
                case AnimalID.PersonalityDescription: EditAnimalPersonalDescription(animalId); break;
                case AnimalID.NickName: EditAnimalNick(animalId); break;
                
                default:
                    Console.WriteLine("\nWYBRANO WRÓĆ");
                    Console.ReadKey();
                    MenuEditMode.EditModeMenu();
                    break;
            }
        }
        public static void EditAnimalId()
        {
            PrintAnimalIdCannotBeModyfiet();
        }
        public static void EditAnimalSpeciec(int animalId)
        {
            EditAnimalProperty(animalId, AnimalProperty.Species, AnimalID.Species, (i) => EditModeGui.PrintAnimalSpecies(i));
        }
        public static void EditAnimalAge(int animalId)
        {
            EditAnimalProperty(animalId, AnimalProperty.Age, AnimalID.Age, (i) => EditModeGui.PrintAnimalAge(i));
        }
        public static void EditAnimalPhysicalDescription(int animalId)
        {
            EditAnimalProperty(animalId, AnimalProperty.PhysicalDescription, AnimalID.PhysicalDescription, (i) => EditModeGui.PrintAnimalPhysicalDescription(i));
        }
        public static void EditAnimalPersonalDescription(int animalId)
        {
            EditAnimalProperty(animalId, AnimalProperty.PersonalityDescription, AnimalID.PersonalityDescription, (i) => EditModeGui.PrintAnimalPersonalityDescription(i));
        }
        public static void EditAnimalNick(int animalId)
        {
            EditAnimalProperty(animalId, AnimalProperty.NickName, AnimalID.NickName, (i) => EditModeGui.PrintAnimalNick(i));
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
            //Console.Clear();
            ConsoleHelper.PrintLine();
            ConsoleHelper.ChangeTextColor("Green");
            Console.WriteLine("|\tEdytujesz teraz:");
            ConsoleHelper.PrintLine();
        }

        private static void PrintAnimalIdCannotBeModyfiet() 
        {
            Console.ResetColor();
            ConsoleHelper.ChangeTextColor("Red");
            Console.WriteLine("\n\tWartość Id jest generowan automatycznie na bazie 1 lotery gatunku i pozycji indeksu w bazie.");
            Console.ResetColor();
            Console.ReadKey();
        }
        private static void EditAnimalProperty(int animalId, string animalPropertyName, int animalPropertyId, Action<int> printAction)
        {
            PrintActiveEditLabel();
            printAction(animalId);
            Console.WriteLine(animalId);
            PrintActivEditHelp();

            string userText = Console.ReadLine() ?? string.Empty;
            string newUserValue = animalPropertyName + ": " + userText;

            EditCurrentAnimalValue(animalId, animalPropertyId, newUserValue);
            printAction(animalId);
            Console.ReadKey();
        }
        private static void EditCurrentAnimalValue(int animalId, int animalPropertyId, string newValue)
        {
            Console.Clear();
            ConsoleHelper.PrintLine();
            Console.WriteLine("|\t Zapisywanie nowej wartości:");
            ConsoleHelper.PrintLine();
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

// EditModeGui.PrintAnimalSpecies(animalId);
