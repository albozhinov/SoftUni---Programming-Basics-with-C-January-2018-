using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02
{
    class Illidan
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            int healthOfIllidan = int.Parse(Console.ReadLine());

            int damage = people * power;
            int diff = Math.Abs(damage - healthOfIllidan);

            if (damage < healthOfIllidan)
            {
                Console.WriteLine($"You are not prepared! You need {diff} more points.");
            }
            else
            {
                Console.WriteLine($"Illidan has been slain! You defeated him with {diff} points.");
            }

        }
    }
}
