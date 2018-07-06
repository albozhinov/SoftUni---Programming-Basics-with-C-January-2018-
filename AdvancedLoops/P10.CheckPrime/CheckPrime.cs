using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10.CheckPrime
{
    class CheckPrime
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string primeNumber = "Prime";

            if (n < 2)
            {
                primeNumber = "Not Prime";
            }
            else
            {
                for (int i = 1; i < Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        primeNumber = "Not Prime";
                    }
                }
            }         
            
            Console.WriteLine(primeNumber);
        }
    }
}
