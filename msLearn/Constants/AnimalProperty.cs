using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msLearn.Constants
{
    internal static class AnimalProperty
    {
        public const string Age = "Wiek";
        public const string Id = "Id";
        public const string Species = "Gatunek";
        public const string PhysicalDescription = "Opis fizyczny:";
        public const string PersonalityDescription = "Opis charakteru";
        public const string NickName = "Nick";

        public const int AgeIndexPrefix = 6;
        public const int IdIndexPrefix = 6;
        public const int SpeciesIndexPrefix = 9;
        public const int PhysicalDescriptionIndexPrefix = 26;
        public const int PersonalityDescriptionIndexPrefix = 11;
        public const int NickNameIndexPrefix = 6;
    }
    //ourAnimals[i, AnimalPropertyId.Id] = "ID #: " + animalID;
    //ourAnimals[i, AnimalPropertyId.Species] = "Gatunek: " + animalSpecies;
    //ourAnimals[i, AnimalPropertyId.Age] = "Wiek: " + animalAge;
    //ourAnimals[i, AnimalPropertyId.PhysicalDescription] = "Opis fizyczny zwierzęcia: " + animalPhysicalDescription;
    //ourAnimals[i, AnimalPropertyId.PersonalityDescription] = "Charakter: " + animalPersonalityDescription;
    //ourAnimals[i, AnimalPropertyId.NickName] = "Nick: " + animalNickname;
 

    
}
