using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.Ivanovi_sHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            int nights = int.Parse(Console.ReadLine());
            string destination = Console.ReadLine().ToLower();
            string transport = Console.ReadLine().ToLower();
            double adultNightCost = 0;
            double childrenNightCost = 0;
            double adultTransport = 0;
            double childrenTransport = 0;
            
            if (destination == "miami")
            {
                if (nights <= 10)
                {
                    adultNightCost = 24.99;
                    childrenNightCost = 14.99;
                }
                else if (nights > 10 && nights <= 15)
                {
                    adultNightCost = 22.99;
                    childrenNightCost = 11.99;
                }
                else if (nights > 15)
                {
                    adultNightCost = 20.00;
                    childrenNightCost = 10.00;
                }
            }
            else if (destination == "canary islands")
            {
                if (nights <= 10)
                {
                    adultNightCost = 32.50;
                    childrenNightCost = 28.50;
                }
                else if (nights > 10 && nights <= 15)
                {
                    adultNightCost = 30.50;
                    childrenNightCost = 25.60;
                }
                else if (nights > 15)
                {
                    adultNightCost = 28.00;
                    childrenNightCost = 22.00;
                }
            }
            else
            {
                if (nights <= 10)
                {
                    adultNightCost = 42.99;
                    childrenNightCost = 39.99;
                }
                else if (nights > 10 && nights <= 15)
                {
                    adultNightCost = 41.00;
                    childrenNightCost = 36.00;
                }
                else if (nights > 15)
                {
                    adultNightCost = 38.50;
                    childrenNightCost = 32.40;
                }
            }
            switch (transport)
            {
                case "train":
                    adultTransport = 22.30;
                    childrenTransport = 12.50;
                    break;
                case "bus":
                    adultTransport = 45.00;
                    childrenTransport = 37.00;
                    break;
                case "airplane":
                    adultTransport = 90.00;
                    childrenTransport = 68.50;
                    break;
            }


            double allPeopleNights = nights * (adultNightCost * 2 + childrenNightCost * 3);
            allPeopleNights += allPeopleNights * 0.25;
            double allPeopleTransport = (2 * adultTransport) + (3 * childrenTransport);
            double result = allPeopleNights + allPeopleTransport;
            Console.WriteLine($"{result:f3}");
        }
    }
}
