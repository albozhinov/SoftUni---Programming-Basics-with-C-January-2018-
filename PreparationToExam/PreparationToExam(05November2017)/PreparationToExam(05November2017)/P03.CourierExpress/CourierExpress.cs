using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.CourierExpress
{
    class CourierExpress
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            string serviceType = Console.ReadLine().ToLower();
            int kilometers = int.Parse(Console.ReadLine());

            double pricePerKilometer = 0.03;
            double price = 0.0;
            
                if (weight >= 1 && weight <= 10)
                {
                    pricePerKilometer = 0.05;
                }
                else if (weight >= 11 && weight <= 40)
                {
                    pricePerKilometer = 0.10;
                }
                else if (weight >= 41 && weight <= 90)
                {
                    pricePerKilometer = 0.15;
                }
                else if (weight >= 91)
                {
                    pricePerKilometer = 0.20;
                }

                price = pricePerKilometer * kilometers;

                
            if (serviceType == "express")
            {
                double charge = 0.80;
                if (weight >= 1 && weight <= 10)
                {
                    charge = 0.40;
                }
                else if (weight >= 11 && weight <= 40)
                {
                    charge = 0.05;
                }
                else if (weight >= 41 && weight <= 90)
                {
                    charge = 0.02;
                }
                else if (weight >= 91)
                {
                    charge = 0.01;
                }
                pricePerKilometer *= charge;
                double chargePrice = pricePerKilometer * weight;
                double chargePricePerKilometer = kilometers * chargePrice;
                double totalPrice = chargePricePerKilometer + price;
                Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {totalPrice:f2} lv.");
            }
            else
            {
                Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {price:f2} lv.");
            }

        }
    }
}
