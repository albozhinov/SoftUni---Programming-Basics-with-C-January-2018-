using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChrimstamsSock
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
           
            int height = 3 * size + 3;           

            Console.WriteLine("|{0}|", new string('-', 2 * size));
            Console.WriteLine("|{0}|", new string('*', 2 * size));
            Console.WriteLine("|{0}|", new string('-', 2 * size));
            
            int partOfTop = size - 1;
            int countOfTire = 0;
            int countOfTilde = 0;

            for (int i = 0; i < partOfTop; i++)
            {
                countOfTire = (size * 2 - 2 - (2 * i)) / 2;
                countOfTilde = 2 + (2 * i);
                Console.WriteLine("|{0}{1}{0}|", new string('-', countOfTire), new string('~', countOfTilde));
            }

            for (int i = 0; i < partOfTop - 1; i++)
            {
                countOfTilde -= 2;
                countOfTire++;
                Console.WriteLine("|{0}{1}{0}|", new string('-', countOfTire), new string('~', countOfTilde));
            }

            for (int i = 0; i < size + 3; i++)
            {
                if (i == size + 2)
                {
                    Console.WriteLine("{0}\\{1})", new string('-', i), new string('_', size * 2 + 1));
                }
                else if (i == size / 2)
                {
                    Console.WriteLine("{0}\\{1}MERRY{1}\\", new string('-', i), new string('.', ((size * 2 + 1) - 5) / 2));
                }
                else if (i == (size / 2) + 2)
                {
                    Console.WriteLine("{0}\\{1}X-MAS{1}\\", new string('-', i), new string('.', ((size * 2 + 1) - 5) / 2));
                }
                else
                {
                    Console.WriteLine("{0}\\{1}\\", new string('-', i), new string('.', size * 2 + 1));
                }
            }
        }
    }
}
