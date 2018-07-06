using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.SoftUniLogo
{
    class SoftUniLogo
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int height = 4 * size - 2;
            int width = 12 * size - 5;

            int firstPart = size * 2;
            int secPart = (size * 2) - 2;
            int countOfHashtags = 1;

            for (int i = 0; i < firstPart; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', (width - countOfHashtags) / 2), new string('#', countOfHashtags));
                countOfHashtags += 6;
            }

            int countOfDots = 3;
            for (int k = 1; k <= secPart; k++)
            {
                if (k <= size - 2)
                {
                    Console.WriteLine("|{0}{1}{2}", new string('.', countOfDots - 1), new string('#', width - (countOfDots * 2)), new string('.', countOfDots));
                    countOfDots += 3;

                }
                else if (k == secPart)
                {
                    Console.WriteLine("@{0}{1}{2}", new string('.', countOfDots - 1), new string('#', width - (countOfDots * 2)), new string('.', countOfDots));
                }
                else
                {
                    Console.WriteLine("|{0}{1}{2}", new string('.', countOfDots - 1), new string('#', width - (countOfDots * 2)), new string('.', countOfDots));
                }
                
            }
        }
    }
}
