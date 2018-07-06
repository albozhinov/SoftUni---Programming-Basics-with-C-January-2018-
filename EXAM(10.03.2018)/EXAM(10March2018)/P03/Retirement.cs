using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03
{
    class Retirement
    {
        static void Main(string[] args)
        {
            string gender = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            int ageOfPractice = int.Parse(Console.ReadLine());

            if (gender != "male" && gender != "female")
            {
                Console.WriteLine("Invalid input.");
                Environment.Exit(0);
            }            
            else if (age < 1 || ageOfPractice < 1)
            {
                Console.WriteLine("Invalid input.");
                Environment.Exit(0);
            }

            if (gender == "female")
            {
                int diffAge = 61 - age;
                int diffPractice = 35 - ageOfPractice;

                if (age >= 61 && ageOfPractice >= 35)
                {
                    Console.WriteLine($"Ready to retire at {age} and {ageOfPractice} years of experience!");
                }
                else if (age < 61 && ageOfPractice >= 35)
                {                    
                    Console.WriteLine($"Worked enough, but not old enough. Years left to retirement: {diffAge}.");
                }
                else if (age >= 61 && ageOfPractice < 35)
                {                    
                    Console.WriteLine($"Old enough, but haven't worked enough. Work experience left to retirement: {diffPractice}.");
                }
                else
                {                  
                    Console.WriteLine($"Too early. Years left to retirement: {diffAge}. Work experience left to retirement: {diffPractice}.");
                }
            }

            if (gender == "male")
            {
                int diffAge = 64 - age;
                int diffPractice = 38 - ageOfPractice;

                if (age >= 64 && ageOfPractice >= 38)
                {
                    Console.WriteLine($"Ready to retire at {age} and {ageOfPractice} years of experience!");
                }
                else if (age < 64 && ageOfPractice >= 38)
                {
                    Console.WriteLine($"Worked enough, but not old enough. Years left to retirement: {diffAge}.");
                }
                else if (age >= 64 && ageOfPractice < 38)
                {
                    Console.WriteLine($"Old enough, but haven't worked enough. Work experience left to retirement: {diffPractice}.");
                }
                else
                {
                    Console.WriteLine($"Too early. Years left to retirement: {diffAge}. Work experience left to retirement: {diffPractice}.");
                }
            }
        }
    }
}
