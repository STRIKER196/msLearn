using System;

internal class Program
{
    private static void Main(string[] args)
    {
        decimal currentAssignments = 5;

        string[] studentsName = new string[] { "Sofii", "Andrzej", "Emilia", "Jonasz" };
        int[] sofiiScores = new int[] { 90, 86, 87, 98, 100 };
        int[] andrzejScores = new int[] { 92, 89, 81, 96, 90 };
        int[] emiliaScores = new int[] { 90, 85, 87, 98, 68 };
        int[] jonaszScores = new int[] { 90, 95, 87, 88, 96 };

        int[] currentScoreHolder = new int[5];

        Console.WriteLine($"{"Student".PadRight(10)} {"Grade",8}");



        foreach (string name in studentsName)
        {
            int studentScoresSum = 0;
            decimal studentResoult = 0;

            if (name == "Sofii")
            {
                currentScoreHolder = sofiiScores;
            }
            else if (name == "Andrzej")
            {
                currentScoreHolder = andrzejScores;
            }
            else if (name == "Emilia")
            {
                currentScoreHolder = emiliaScores;
            }
            else if (name == "Jonasz")
            {
                currentScoreHolder = jonaszScores;
            }

            foreach (int points in currentScoreHolder)
            {
                studentScoresSum += points;
                studentResoult = (decimal)studentScoresSum / currentAssignments;
            }

            Console.WriteLine($"{name.PadRight(10)} {studentResoult,8:F2}  A-");
        }

        Console.WriteLine("\nPress the Enter key to continue");
        Console.ReadLine();
    }
}