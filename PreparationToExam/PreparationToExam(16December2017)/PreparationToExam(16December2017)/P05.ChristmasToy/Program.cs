using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.ChristmasToy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 5 * n;
            int middleSymbol = n + 2;
            Console.WriteLine("{0}{1}{0}", new string('-', (width - n) / 2), new string('*', n));

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}*{2}*{1}{0}", new string('-', (width - n - 4) / 2 - 2 * i),
                    new string('*', i), new string('&', middleSymbol));
                middleSymbol += 2;
            }
            for (int k = 0; k < n / 2; k++)
            {                             
                Console.WriteLine("{0}**{1}**{0}", new string('-', n - 1 - k), new string('~', width - 4 - 2 * n + 2 + 2 *k));
                middleSymbol += 2;
            }            
            Console.WriteLine("{0}*{1}*{0}", new string('-', n / 2), new string('|', width - n - 2));
            for (int j = n / 2; j > 0; j--)
            {
                middleSymbol -= 2;
                Console.WriteLine("{0}**{1}**{0}", new string('-', n - j), new string('~', width - 4 - 2 * n + 2 * j));
            }
            for (int c = n / 2; c > 0; c--)
            {
                middleSymbol -= 2;
                Console.WriteLine("{0}{1}*{2}*{1}{0}", new string('-', (width - n - 4) / 2 - 2 * c + 2), new string('*', c - 1),
                    new string('&', middleSymbol));
            }
            Console.WriteLine("{0}{1}{0}", new string('-', (width - n) / 2), new string('*', n));
        }
    }
}
