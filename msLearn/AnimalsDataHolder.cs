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
                    animalPhysicalDescription = "�redniej wielko�ci, kremowa, samica golden retriever wa��ca oko�o 65 funt�w. Nauczona czysto�ci w domu.";
                    animalPersonalityDescription = "Uwielbia, gdy drapie si� j� po brzuchu i lubi goni� sw�j ogon. Daje mn�stwo buziak�w.";
                    animalNickname = "lola";
                }
                else if (i == 1)
                {
                    animalSpecies = "Pies";
                    animalID = "d2";
                    animalAge = "9";
                    animalPhysicalDescription = "Du�y, czerwonobr�zowy samiec golden retriever wa��cy oko�o 85 funt�w. Nauczony czysto�ci w domu.";
                    animalPersonalityDescription = "Uwielbia, gdy pociera si� mu uszy, gdy wita ci� przy drzwiach � albo w ka�dej chwili! Lubi si� przytula� i dawa� psie u�ciski.";
                    animalNickname = "loki";
                }
                else if (i == 2)
                {
                    animalSpecies = "Kot";
                    animalID = "c3";
                    animalAge = "1";
                    animalPhysicalDescription = "Ma�a, bia�a samica wa��ca oko�o 8 funt�w. Nauczona korzystania z kuwety.";
                    animalPersonalityDescription = "Przyjazna.";
                    animalNickname = "Puss";
                }
                else if (i == 3)
                {
                    animalSpecies = "Kot";
                    animalID = "c4";
                    animalAge = "?";
                    animalPhysicalDescription = "Ma�y, zwinny kot o mi�kkim futrze, kt�ry uwielbia drzemki na s�o�cu i zabawy z pi�rkami. Ciekawski, towarzyski i zawsze gotowy na przytulanie.";
                    animalPersonalityDescription = "Ma mi�kkie, puszyste futro, jest zwinny i szybki, ciekawski i towarzyski, uwielbia drzemki na s�o�cu, lubi zabawy z pi�rkami, jest przyjazny i skory do przytulania.";
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
                ourAnimals[i, 4] = "Opis fizyczny zwierz�cia: " + animalPhysicalDescription;
                ourAnimals[i, 5] = "Charakter: " + animalPersonalityDescription;

            }
            return ourAnimals;
        }
    }
}