using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02.DeerOfSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double foodFirstDeer = double.Parse(Console.ReadLine());
            double foodSecondDeer = double.Parse(Console.ReadLine());
            double foodThirdDeer = double.Parse(Console.ReadLine());

            double allFoodToDeers = (foodFirstDeer + foodSecondDeer + foodThirdDeer) * days;
            double diff = Math.Abs(food - allFoodToDeers);
            if (food > allFoodToDeers)
            {               
                Console.WriteLine("{0} kilos of food left.", Math.Floor(diff));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(diff));
            }
        }
    }
}
