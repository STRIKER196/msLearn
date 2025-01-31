using System;

namespace msLearn // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

            Decision logic challenge
            In this challenge, you'll implement decision logic based on a series of business rules.
            The business rules specify the access that will be granted to users based on their role-based
            permissions and their career level.
            Code branches will display a different message to the user depending on their permissions and level.
            */

            string permission = "Admin|Manager";
            int level = 53; // <-- zmiana wartosci

            if (permission.Contains("Admin"))
            {
                if (level > 55)
                {
                    Console.WriteLine("Welcome, Super Admin user.");
                }
                else
                {
                    Console.WriteLine("Welcome, Admin user.");
                }
            }
            else if (permission.Contains("Manager"))
            {
                if (level >= 20)
                {
                    Console.WriteLine("Contact an Admin for access.");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient privileges.");
                }
            }
            else
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }

        }
    }
}