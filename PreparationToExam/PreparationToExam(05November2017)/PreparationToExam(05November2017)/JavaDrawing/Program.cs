using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaDrawing
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int width = 3 * size + 6;
            int height = 3 * size + 1;

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("{0}~ ~ ~", new string(' ', size));
            }
            Console.WriteLine(new string('=', width - 1));
            for (int i = 1; i <= size - 2; i++)
            {
                if (size / 2 == i)
                {
                    int countOfTilde = ((size * 2 + 4) - 4) / 2;
                    Console.WriteLine("|{0}JAVA{0}|{1}|", new string('~', countOfTilde), new string(' ', size - 1));
                }
                else
                {
                    Console.WriteLine("|{0}|{1}|", new string('~', 2 * size + 4), new string(' ', size - 1));
                }                
            }
            Console.WriteLine(new string('=', width - 1));

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("{0}\\{1}/",new string(' ', i), new string('@', 2 * size + 4 - (i * 2)));
            }

            Console.WriteLine(new string('=', 2 * size + 6));
        }
    }
}
