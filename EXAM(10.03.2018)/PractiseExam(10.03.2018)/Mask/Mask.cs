using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Mask
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int width = (2 * size) + 2;

            for (int i = 0; i < size - 1; i++)
            {
                Console.WriteLine("{0}/{1}|  |{1}\\", new string(' ', size - 2 - i), new string(' ', i));
            }

            Console.WriteLine(new string('-', width));
            Console.WriteLine("|{0}_{1}_{0}|", new string(' ', (width - 4 - (size + 1)) / 2), new string(' ', size + 1));
            Console.WriteLine("|{0}@{1}@{0}|", new string(' ', (width - 4 - (size + 1)) / 2), new string(' ', size + 1));

            for (int i = 0; i < size / 2; i++)
            {
                Console.WriteLine("|{0}|", new string(' ', width - 2));
            }

            Console.WriteLine("|{0}OO{0}|", new string(' ', (width - 4) / 2));
            Console.WriteLine("|{0}/  \\{0}|", new string(' ', (width - 6) / 2));
            Console.WriteLine("|{0}||||{0}|", new string(' ', (width - 6) / 2));

            int countOfAcutus = width - 2;
            for (int i = 0; i < size + 1; i++)
            {
                Console.WriteLine("{0}{1}{2}", new string('\\', 1 + i), new string('`', countOfAcutus), new string('/', 1 + i));
                countOfAcutus -= 2;
            }
        }
    }
}
