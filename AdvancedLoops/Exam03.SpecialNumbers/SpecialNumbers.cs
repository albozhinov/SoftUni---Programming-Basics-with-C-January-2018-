using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam03.SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int c = 1; c <= 9; c++)
                        {
                            if (n % i == 0 && n % j == 0 && n % k == 0 && n % c == 0)
                            {
                                Console.Write($"{i}{j}{k}{c} ");
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
