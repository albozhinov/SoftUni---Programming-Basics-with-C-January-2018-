using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.PowerOfTwo
{
    class PowerOfTwo
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var result = 1;

            for (int i = 0; i <= n; i++)
            {                
                result = (int)Math.Pow(2, i);
                Console.WriteLine(result);
            }
        }
    }
}
