using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.EvenPowersOfTwo
{
    class EvenPowersOfTwo
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var result = 1;

            for (int i = 0; i <= n; i += 2)
            {
                result = (int)Math.Pow(2, i);
                Console.WriteLine(result);
            }
        }
    }
}
