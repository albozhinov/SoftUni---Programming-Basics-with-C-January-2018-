using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01.Ivanovi_sFamily
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyBudget = double.Parse(Console.ReadLine());
            double firstChild = double.Parse(Console.ReadLine());
            double secondChild = double.Parse(Console.ReadLine());
            double thirdChild = double.Parse(Console.ReadLine());

            double sum = firstChild + secondChild + thirdChild;

            double money = moneyBudget - sum;
            double result = money - (money * 0.1);           

            Console.WriteLine($"{result:f2}");
        }
    }
}
