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

            do
            {
                
                for (int round = 0; heroHP >= 0; round++)
                {
                    int diceThrow = new Random().Next(1, 3);
                    int randHeroDmg = new Random().Next(1, 7);
                    int randMonsterDmg = new Random().Next(1, 7) + difficultLevel;
                    Console.WriteLine($"\nRunda: {round+1}\n");

                    if (diceThrow == 1)
                    { 
                        Console.WriteLine("W tej rundzie Pierwszy atakuje: Bohater");
                        Console.ForegroundColor = ConsoleColor.Green;
                        monsterHP = (monsterHP - randHeroDmg);
                        Console.WriteLine($"Bohater zadał {randHeroDmg}.pkt obrażeń.");
                        if(monsterHP <= 0)
                            {
                            Console.Clear();
                            Console.ForegroundColor= ConsoleColor.Yellow;
                            Console.WriteLine("'Potwór z Bagien; zdechł!\n\n");
                            Console.WriteLine("Wygrana!");
                            Console.ReadLine() ;
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
                        heroHP = heroHP - randMonsterDmg;
                        if (heroHP <= 0)
                        {
                            Console.Clear() ;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("'Bohater'; zdechł!\n\n");
                            Console.WriteLine("Przegrana!");
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
            }while(monsterHP <= 0);
        }
    }
}