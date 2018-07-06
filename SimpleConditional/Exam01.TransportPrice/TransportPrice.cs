using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam01.TransportPrice
{
    class TransportPrice
    {
        static void Main(string[] args)
        {
            int kilometers = int.Parse(Console.ReadLine());
            var dayOrNight = Console.ReadLine();
            double tariff = 0;
            double taxi = 0.70;
            double price = 0;

            if (kilometers < 20)
            {
                switch (dayOrNight)
                {
                    case "day":
                        tariff = 0.79;
                        break;
                    case "night":
                        tariff = 0.90;
                        break;                        
                }
                price = (kilometers * tariff) + taxi;
            }
            else if (kilometers >= 20 && kilometers < 100)
            {
                price = kilometers * 0.09;
            }
            else if (kilometers >= 100)
            {
                price = kilometers * 0.06;
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}
