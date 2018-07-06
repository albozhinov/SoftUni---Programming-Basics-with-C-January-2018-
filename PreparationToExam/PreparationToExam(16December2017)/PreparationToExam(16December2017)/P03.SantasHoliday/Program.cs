using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.SantasHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string rooms = Console.ReadLine().ToLower();
            string rating = Console.ReadLine().ToLower();
            days--;
            double roomPrice = 0;
            double discount = 0;
            double ratingValue = 0;

            switch (rooms)
            {
                case "room for one person":
                    roomPrice = 18.00;                    
                    break;
                case "apartment":
                    roomPrice = 25.00;
                    discount = 0.35;
                    if (days < 10)
                    {
                        discount = 0.30;
                    }
                    else if (days > 15)
                    {
                        discount = 0.50;
                    }                    
                    break;
                case "president apartment":
                    roomPrice = 35.00;
                    discount = 0.15;
                    if (days < 10)
                    {
                        discount = 0.10;
                    }
                    else if (days > 15)
                    {
                        discount = 0.20;
                    }
                    break;                
            }
            roomPrice *= days;
            roomPrice -= roomPrice * discount;

            if (rating == "positive")
            {
                ratingValue = 0.25;
                roomPrice += roomPrice * ratingValue;
            }
            else if (true)
            {
                ratingValue = 0.1;
                roomPrice -= roomPrice * ratingValue;
            }            
            Console.WriteLine("{0:f2}", roomPrice);
        }
    }
}
