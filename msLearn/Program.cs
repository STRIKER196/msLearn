using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace msLearn // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ćwiczenie — tworzenie tablic i pętli foreach
            */
            

            int[] wynikSophi = new int[] { 90, 86, 87, 98, 100 };
            int[] wynikAndrew = new int[] { 92, 85, 87, 98, 68 };
            int[] wynikEmmy = new int[] { 90, 85, 87, 88, 96 };
            int[] wynikLogana = new int[] { 90, 95, 87, 88, 96 };

            string[] imionaStudentow = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
            int iloscOcenWZadaniach = wynikSophi.Length;

            foreach (string imie in imionaStudentow)
            {
                if (imie == "Sophia")
                { 
                    int sumaPunktowSophi = 0;
                    decimal punktySophi;

                    foreach (int punkty in wynikSophi)
                    {
                        sumaPunktowSophi += punkty;
                    }


                    punktySophi = (decimal)sumaPunktowSophi / iloscOcenWZadaniach;

                    Console.WriteLine("Student\t\tGrade\n");
                    Console.WriteLine("Sophia:\t\t" + punktySophi + "\tA-");
                }
            }

            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();
        }

    }
}