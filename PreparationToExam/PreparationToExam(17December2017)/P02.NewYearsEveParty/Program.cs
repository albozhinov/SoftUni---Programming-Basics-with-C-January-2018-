using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02.NewYearsEveParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            int ivanoviBudget = int.Parse(Console.ReadLine());
            int covertPrice = 20;

            int guestBudget = guests * covertPrice;

            if (ivanoviBudget >= guestBudget)
            {
                var diff = Math.Abs(ivanoviBudget - guestBudget);
                double fireworks = Math.Round(diff * 0.4);
                var donation = diff - fireworks;
                Console.WriteLine($"Yes! {fireworks} lv are for fireworks and {donation} lv are for donation.");
            }
            else
            {
                var diff = Math.Abs(ivanoviBudget - guestBudget);
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {diff} lv more.");
            }
        }
    }
}
