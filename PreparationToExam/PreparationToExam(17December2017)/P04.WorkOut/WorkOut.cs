using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.WorkOut
{
    class WorkOut
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double kilometers = double.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());
            double sumKilometers = kilometers;
            for (int i = 1; i <= days; i++)
            {                                
                procent = procent / 100;
                kilometers += kilometers * procent;
                sumKilometers += kilometers;
                if (i < days)
                {
                    procent = double.Parse(Console.ReadLine());
                }   
            }
            double diff = Math.Ceiling(Math.Abs(1000 - sumKilometers));            

            if (1000 < sumKilometers)
            {
                Console.WriteLine($"You've done a great job running {diff} more kilometers!");
            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {diff} more kilometers");
            }
        }
    }
}
