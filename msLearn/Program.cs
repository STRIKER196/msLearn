using System;

namespace msLearn // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // initialize variables - graded assignments 
            int currentAssignments = 5;

            string[] studentsName = new string[] { "Sofii", "Andrzej", "Emilia", "Jonasz"};
            int[] sofiiScores = new int[] {90, 86, 87, 98, 100};
            int[] andrzejScores = new int[] { 92, 89, 81, 96, 90 };
            int[] emiliaScores = new int[] {90, 85, 87, 98, 68};
            int[] jonaszScores = new int[] {90, 95, 87, 88, 96};

            Console.WriteLine("Student\t\tGrade\n");
            decimal sofiiScore;
            decimal andrewScore;
            decimal emmaScore;
            decimal loganScore;

            foreach (string name in studentsName)
            { 

                int sofiiSum = 0;
                int andrzejSum = 0;
                foreach (int points in sofiiScores)
                {
                    if (name == "Sofii")
                    { sofiiSum += points; }
                    else if (name == "Andrzej")
                    { andrzejSum += points; }
                }

                sofiiScore = (decimal)sofiiSum / currentAssignments;

                Console.WriteLine($"{name}:\t\t" + sofiiScore + "\tA-");
            }

            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();
        }
    }
}