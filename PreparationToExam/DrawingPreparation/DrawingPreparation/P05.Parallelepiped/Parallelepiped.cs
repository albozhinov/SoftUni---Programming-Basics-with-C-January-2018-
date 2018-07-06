using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.Parallelepiped
{
    class Parallelepiped
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int height = 4 * size + 2;
            int width = 3 * size + 1;

            int countOfTilde = size - 2;
            int countOfDots = width - 2 - countOfTilde;
            string tilde = new string('~', countOfTilde);

            Console.WriteLine("+{0}+{1}", tilde, new string('.', countOfDots));

            
            for (int i = 0; i < height / 2; i++)
            {
                Console.WriteLine("|{0}\\{1}\\{2}", new string('.', i) ,tilde, new string('.', (size * 2) - i));                
            }

            for (int k = 0; k < height / 2; k++)
            {
                Console.WriteLine("{0}\\{1}|{2}|", new string('.', k),new string('.', (size * 2) - k),tilde);
            }
            Console.WriteLine("{0}+{1}+", new string('.', countOfDots), tilde);
            
        }
    }
}
