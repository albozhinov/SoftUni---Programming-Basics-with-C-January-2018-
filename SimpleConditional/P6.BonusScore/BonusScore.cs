using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6.BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double result = 0;

            if (n <= 100)
            {
                result = 5;
            }
            else if (n > 100 && n <= 1000)
            {
                result = n * 0.2;
            }
            else if (n > 1000)
            {
                result = n * 0.1;
            }
            if (n % 2 == 0)
            {
                result += 1;
            }
            else if (n % 5 == 0)
            {
                result += 2;
            }

            Console.WriteLine(result);
            Console.WriteLine(n + result);
        }
    }
}
