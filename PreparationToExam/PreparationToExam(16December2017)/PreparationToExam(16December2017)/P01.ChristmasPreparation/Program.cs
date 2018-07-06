using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01.ChristmasPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int paper = int.Parse(Console.ReadLine());
            int textile = int.Parse(Console.ReadLine());
            double liquid = double.Parse(Console.ReadLine());
            double percenteg = double.Parse(Console.ReadLine());

            double paperPrice = 5.80;
            double textilePrice = 7.20;
            double liquidPrice = 1.20;

            double paperCost = paper * paperPrice;
            double textileCost = textile * textilePrice;
            double liquidCost = liquid * liquidPrice;
            percenteg /= 100;
            double sum = paperCost + textileCost + liquidCost;
            double discountCost = sum * percenteg;
            double result = sum - discountCost;
            Console.WriteLine("{0:f3}", result);
        }
    }
}
