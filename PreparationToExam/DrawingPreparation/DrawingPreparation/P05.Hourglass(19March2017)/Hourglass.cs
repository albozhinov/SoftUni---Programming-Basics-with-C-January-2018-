using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.Hourglass_19March2017_
{
    class Hourglass
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int widthAndHeight = 2 * size + 1;
            int countOfAt = widthAndHeight - 6;

            Console.WriteLine(new string('*', widthAndHeight));
            Console.WriteLine(".*{0}*.", new string(' ', widthAndHeight - 4));

            for (int i = 0; i < size - 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', 2 + i), new string('@', countOfAt));
                countOfAt -= 2;
            }

            Console.WriteLine("{0}*{0}", new string('.', size));

            for (int k = 0; k < size - 2; k++)
            {
                Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', size - 1 - k), new string(' ', k));
            }

            Console.WriteLine(".*{0}*.", new string('@', widthAndHeight - 4));
            Console.WriteLine(new string('*', widthAndHeight));
        }
    }
}
