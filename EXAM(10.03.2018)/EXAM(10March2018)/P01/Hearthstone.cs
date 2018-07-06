using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01
{
    class Hearthstone
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());
            double pricePerDeck = double.Parse(Console.ReadLine());
            double coffePrice = double.Parse(Console.ReadLine());
            double priceOfAdventure = double.Parse(Console.ReadLine());

            int timeForCoffe = 5;
            int timeToBuyDeck = 6;
            int timeToBueAdventure = 4;
            int timeToBreak = time - (timeToBueAdventure + timeToBuyDeck + timeForCoffe);
            double moneyLeft = (3 * pricePerDeck) + (2 * coffePrice) + priceOfAdventure;

            Console.WriteLine($"{moneyLeft:f2}");
            Console.WriteLine(timeToBreak);
        }
    }
}
