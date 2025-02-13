using System;
using System.Security.Cryptography.X509Certificates;

namespace msLearn // Note: actual namespace depends on the project name.
{
    /*
     * ĆWICZENIE LEKCJI: Stworzenie prostej gry na bazie do-while, które polega na zbijaniu punktów zdrowia.
    Bohater jak i przeciwnik mają po 10 punktów zdrowia. każdy z nich moze zatakować raz na turę.
    Wartość ataków obejmuje rzut kostką (1-6). Całość kończy się w momencie pokonania jednego z postaci.
    Gra może być przerwana, zrestartowana lub wyłączona. Na koniec gry jesteś pytany o restart lub koniec.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int difficultLevel = 1;
            int heroHP = 20;
            int monsterHP = 30;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Gra ak'a D&D - deafet enemy before he defeat you");
            Console.WriteLine("Naciśnij dowolny przycisk aby zacząć");
            Console.WriteLine("Po każdej rundzie będziesz musiał wcisnąć dowolny przycisk na klawiaturze");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"START \n Poziom trudności: {difficultLevel}\n\n");
            Console.WriteLine($"Bohater ma na start {heroHP} pkt. życia");
            Console.WriteLine($"Znalazłeś przeciwnika. Jest to 'Potwór z Bagien'. Wygląda na to, że ma {monsterHP} pkt.życia");
            Console.WriteLine("----WALKA SIĘ ROZPOCZEŁA----");

            Random rand = new Random();
            do
            {
                
                for (int round = 0; heroHP >= 0; round++)
                {
                    int diceThrow = rand.Next(1, 3);
                    int randHeroDmg = rand.Next(1, 7);
                    int randMonsterDmg = rand.Next(1, 7) + difficultLevel;
                    Console.WriteLine($"\nRunda: {round+1}\n");
                    Console.WriteLine("1 - Bohater  2 - Potwór");
                    Console.WriteLine($"Rzut kostką: {diceThrow} : 1 - Bohater  2 - Potwór\n\n");
                    if (diceThrow == 1)
                    { 
                        Console.WriteLine("W tej rundzie Pierwszy atakuje: Bohater");
                        Console.ForegroundColor = ConsoleColor.Green;
                        monsterHP -= randHeroDmg;
                        Console.WriteLine($"Bohater zadał {randHeroDmg}.pkt obrażeń.");
                        if(monsterHP <= 0)
                            {
                            Console.Clear();
                            Console.ForegroundColor= ConsoleColor.Yellow;
                            Console.WriteLine("🎉 Zwycięstwo! Pokonałeś Potwora z Bagien! 🎉");
                            Console.WriteLine("Czy chcesz spróbować ponownie? (T/N) \n lub \n");
                            Console.WriteLine("Naciśnij Enter, aby zakończyć...");
                            string restart = Console.ReadLine().ToUpper();
                            if (restart == "T")
{ 
                            
                            }
                            Console.Clear();
                            break;
                            }
                        Console.WriteLine($"Potworowi zostało jescze: {monsterHP}.pkt zdrowia.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();

                    }
                    else 
                    { 
                        Console.WriteLine("W tej rundzie atakuje: Potwór");
                        Console.ForegroundColor = ConsoleColor.Red;
                        heroHP -= randMonsterDmg;
                        if (heroHP <= 0)
                        {
                            Console.Clear() ;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("💀 Bohater poległ w walce... 💀");
                            Console.WriteLine("Przegrana!");
                            Console.WriteLine("Naciśnij Enter, aby zakończyć...");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        Console.WriteLine($"Potwór zadał {randMonsterDmg}.pkt obrażeń");
                        Console.WriteLine($"Bohaterowi zostało jescze: {heroHP}.pkt zdrowia.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                    }
                }
            }while(heroHP > 0 && monsterHP > 0);
        }
    }
}