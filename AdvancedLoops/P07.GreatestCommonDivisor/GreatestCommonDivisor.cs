using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07.GreatestCommonDivisor
{
    class GreatestCommonDivisor
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int div = a < b ? a : b;
            int greater = a > b ? a : b;
            var result = 1;

            while (result != 0)
            {
                result = greater % div;
                greater = div;
                div = result;
            }
            Console.WriteLine(greater);
        }
    }
}
