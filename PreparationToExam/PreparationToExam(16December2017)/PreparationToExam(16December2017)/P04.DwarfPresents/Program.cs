using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.DwarfPresents
{
    class Program
    {
        static void Main(string[] args)
        {
            int dwarf = int.Parse(Console.ReadLine());
            int money = int.Parse(Console.ReadLine());
            double presentPrice = 0;
            double sum = 0;
            for (int i = 0; i < dwarf; i++)
            {
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "sand clock":
                        presentPrice = 2.20;
                        break;
                    case "magnet":
                        presentPrice = 1.50;
                        break;
                    case "cup":
                        presentPrice = 5;
                        break;
                    case "t-shirt":
                        presentPrice = 10;
                        break;
                }
                sum += presentPrice;
            }
            if (money >= sum)
            {
                Console.WriteLine($"Santa Claus has {Math.Abs(money - sum):f2} more leva left!");
            }
            else
            {
                Console.WriteLine($"Santa Claus will need {Math.Abs(money - sum):f2} more leva.");
            }
        }
    }
}
