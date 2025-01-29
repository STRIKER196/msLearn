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
            string studentResoultLetterGrade = "";

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

            if (studentResoult >= 97)
                studentResoultLetterGrade = "A+";

            else if (studentResoult >= 93)
                studentResoultLetterGrade = "A";

            else if (studentResoult >= 90)
                studentResoultLetterGrade = "A-";

            else if (studentResoult >= 87)
                studentResoultLetterGrade = "B+";

            else if (studentResoult >= 83)
                studentResoultLetterGrade = "B";

            else if (studentResoult >= 80)
                studentResoultLetterGrade = "B-";

            else if (studentResoult >= 77)
                studentResoultLetterGrade = "C+";

            else if (studentResoult >= 73)
                studentResoultLetterGrade = "C";

            else if (studentResoult >= 70)
                studentResoultLetterGrade = "C-";

            else if (studentResoult >= 67)
                studentResoultLetterGrade = "D+";

            else if (studentResoult >= 63)
                studentResoultLetterGrade = "D";

            else if (studentResoult >= 60)
                studentResoultLetterGrade = "D-";

            Console.WriteLine($"{name.PadRight(10)} {studentResoult,8:F2}  {studentResoultLetterGrade}");
        }

        Console.WriteLine("\nPress the Enter key to continue");
        Console.ReadLine();
    }
}