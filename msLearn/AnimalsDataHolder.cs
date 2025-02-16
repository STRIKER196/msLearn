namespace msLearn2 {
    public class AnimalsDataHolder {
        public static string[,] GetSampleData()
        {
            string[,] ourAnimals = new string[6, 7];
            string animalSpecies;
            string animalID;
            string animalAge;
            string animalPhysicalDescription;
            string animalPersonalityDescription;
            string animalNickname;

            for (int i = 0; i < ourAnimals.GetLength(0); i++)
            {
                if (i == 0)
                {
                    animalSpecies = "Pies";
                    animalID = "d1";
                    animalAge = "2";
                    animalPhysicalDescription = "Œredniej wielkoœci, kremowa, samica golden retriever wa¿¹ca oko³o 65 funtów. Nauczona czystoœci w domu.";
                    animalPersonalityDescription = "Uwielbia, gdy drapie siê j¹ po brzuchu i lubi goniæ swój ogon. Daje mnóstwo buziaków.";
                    animalNickname = "lola";
                }
                else if (i == 1)
                {
                    animalSpecies = "Pies";
                    animalID = "d2";
                    animalAge = "9";
                    animalPhysicalDescription = "Du¿y, czerwonobr¹zowy samiec golden retriever wa¿¹cy oko³o 85 funtów. Nauczony czystoœci w domu.";
                    animalPersonalityDescription = "Uwielbia, gdy pociera siê mu uszy, gdy wita ciê przy drzwiach – albo w ka¿dej chwili! Lubi siê przytulaæ i dawaæ psie uœciski.";
                    animalNickname = "loki";
                }
                else if (i == 2)
                {
                    animalSpecies = "Kot";
                    animalID = "c3";
                    animalAge = "1";
                    animalPhysicalDescription = "Ma³a, bia³a samica wa¿¹ca oko³o 8 funtów. Nauczona korzystania z kuwety.";
                    animalPersonalityDescription = "Przyjazna.";
                    animalNickname = "Puss";
                }
                else if (i == 3)
                {
                    animalSpecies = "Kot";
                    animalID = "c4";
                    animalAge = "?";
                    animalPhysicalDescription = "Ma³y, zwinny kot o miêkkim futrze, który uwielbia drzemki na s³oñcu i zabawy z piórkami. Ciekawski, towarzyski i zawsze gotowy na przytulanie.";
                    animalPersonalityDescription = "Ma miêkkie, puszyste futro, jest zwinny i szybki, ciekawski i towarzyski, uwielbia drzemki na s³oñcu, lubi zabawy z piórkami, jest przyjazny i skory do przytulania.";
                    animalNickname = "";
                }
                else if (i == 4)
                {
                    animalSpecies = "Papuga";
                    animalID = "p5";
                    animalAge = "?";
                    animalPhysicalDescription = "";
                    animalPersonalityDescription = "";
                    animalNickname = "";
                }
                else
                {
                    animalSpecies = "";
                    animalID = "";
                    animalAge = "";
                    animalPhysicalDescription = "";
                    animalPersonalityDescription = "";
                    animalNickname = "";
                }

                ourAnimals[i, 0] = "ID #: " + animalID;
                ourAnimals[i, 1] = "Gatunek: " + animalSpecies;
                ourAnimals[i, 2] = "Wiek: " + animalAge;
                ourAnimals[i, 3] = "Nick: " + animalNickname;
                ourAnimals[i, 4] = "Opis fizyczny zwierzêcia: " + animalPhysicalDescription;
                ourAnimals[i, 5] = "Charakter: " + animalPersonalityDescription;

            }
            return ourAnimals;
        }
    }
}