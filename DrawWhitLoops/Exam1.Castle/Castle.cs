using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1.Castle
{
    class Castle
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            var colSize = 2 * size;
            var midSize = 2 * size - 2 * (size / 2) - 4;

            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', size/2), new string('_', midSize));
            for (int i = 0; i < size - 3; i++)
            {
                Console.WriteLine("|{0}|", new string(' ', colSize - 2));
            }
            Console.WriteLine("|{0}{1}{0}|", new string(' ', (size/2) + 1), new string('_', midSize));
            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', size/2), new string(' ', midSize));
        }
    }
}
