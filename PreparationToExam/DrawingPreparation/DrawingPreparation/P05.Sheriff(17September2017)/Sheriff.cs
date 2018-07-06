using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.Sheriff_17September2017_
{
    class Sheriff
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int width = 3 * size;
            int height = 2 * size;
            string textFormat = "{0}{1}{0}";
            string symbol = "x";
            string dots = new string('.', (width - symbol.Length) / 2);
            Console.WriteLine(textFormat, dots, symbol);

            symbol = "/x\\";
            dots = new string('.', (width - symbol.Length) / 2);
            Console.WriteLine(textFormat, dots, symbol);

            symbol = "x|x";
            dots = new string('.', (width - symbol.Length) / 2);
            Console.WriteLine(textFormat, dots, symbol);

            int countDots = ((width - (2 * size)) - 1) / 2;
            int countX = size;
            string middleText = "{0}{1}|{1}{0}";
            for (int i = 0; i <= size / 2; i++)
            {
                Console.WriteLine(middleText, new string('.', countDots), new string('x', countX));
                countX++;
                countDots--;
            }
            countDots++;
            countX--;
            for (int i = 0; i < size / 2; i++)
            {
                countX--;
                countDots++;
                Console.WriteLine(middleText, new string('.', countDots), new string('x', countX));                
            }
            symbol = "/x\\";
            dots = new string('.', (width - symbol.Length) / 2);
            Console.WriteLine(textFormat, dots, symbol);

            symbol = "\\x/";
            dots = new string('.', (width - symbol.Length) / 2);
            Console.WriteLine(textFormat, dots, symbol);

            for (int i = 0; i <= size / 2; i++)
            {
                Console.WriteLine(middleText, new string('.', countDots), new string('x', countX));
                countX++;
                countDots--;
            }

            countDots++;
            countX--;
            for (int i = 0; i < size / 2; i++)
            {
                countX--;
                countDots++;
                Console.WriteLine(middleText, new string('.', countDots), new string('x', countX));
            }
            symbol = "x|x";
            dots = new string('.', (width - symbol.Length) / 2);
            Console.WriteLine(textFormat, dots, symbol);

            symbol = "\\x/";
            dots = new string('.', (width - symbol.Length) / 2);
            Console.WriteLine(textFormat, dots, symbol);

            Console.WriteLine("{0}x{0}", new string('.', (width - 1) / 2));
        }
    }
}
