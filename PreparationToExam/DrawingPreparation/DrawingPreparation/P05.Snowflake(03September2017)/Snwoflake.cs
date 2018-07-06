using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.Snowflake_03September2017_
{
    class Snwoflake
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int width = 2 * size + 3;
            int height = 2 * size + 1;
            string format = "{0}*{1}*{1}*{0}";
            int countMiddleDots = size;
            int countSideDots = 0;

            for (int i = 0; i < size; i++)
            {                
                if (i == size - 1)
                {
                    Console.WriteLine("{0}*****{0}", new string('.', (width - 5) / 2));
                    break;
                }
                Console.WriteLine(format, new string('.', countSideDots), new string('.', countMiddleDots));
                countSideDots++;
                countMiddleDots--;
            }
            Console.WriteLine(new string('*', width));

            for (int i = 0; i < size; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("{0}*****{0}", new string('.', (width - 5) / 2));
                    continue;
                }
                countSideDots--;
                countMiddleDots++;
                Console.WriteLine(format, new string('.', countSideDots), new string('.', countMiddleDots));
            }
        }
    }
}
