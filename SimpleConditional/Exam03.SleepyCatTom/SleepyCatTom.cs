using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam03.SleepyCatTom
{
    class SleepyCatTom
    {
        static void Main(string[] args)
        {
            int holidayDays = int.Parse(Console.ReadLine());

            int holidayPlayDays = holidayDays * 127;
            int workDays = (365 - holidayDays)* 63;
            int allPlayDays = holidayPlayDays + workDays;

            int difference = Math.Abs(allPlayDays - 30000);

            if (30000 < allPlayDays)
            {
                int hours = difference / 60;
                int minutes = difference % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else
            {
                int hours = difference / 60;
                int minutes = difference % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
        }
    }
}
