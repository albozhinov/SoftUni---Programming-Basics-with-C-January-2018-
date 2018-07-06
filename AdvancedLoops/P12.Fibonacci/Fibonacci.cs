using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12.Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int f0 = 1;
            int f1 = 1;
            int sum = 0;
            if (n < 2)
            {
                Console.WriteLine(f0);
                Environment.Exit(0);
            }
            else
            {
                for (int i = 1; i < n; i++)
                {
                    sum = f0 + f1;
                    f0 = f1;
                    f1 = sum;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
