using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sword
{
    class Sword
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int width = (size * 2) + 1;

            Console.WriteLine("{0}/^\\{0}", new string('#', size - 1));

            int countOfWhiteSpaces = 3;
            int countOfHashtags = (width - 5) / 2;
            for (int i = 0; i < size / 2; i++)
            {
                Console.WriteLine("{0}.{1}.{0}", new string('#', countOfHashtags), new string(' ', countOfWhiteSpaces));
                countOfHashtags--;
                countOfWhiteSpaces += 2;                
            }
            countOfHashtags++;
            int countOfMiddwhiteSpaces = size / 2;
            int countOfMiddHashtags = countOfHashtags;

            Console.WriteLine("{0}|{1}S{1}|{0}", new string('#', countOfMiddHashtags), new string(' ', countOfMiddwhiteSpaces));

            Console.WriteLine("{0}|{1}O{1}|{0}", new string('#', countOfMiddHashtags), new string(' ', countOfMiddwhiteSpaces));
            Console.WriteLine("{0}|{1}F{1}|{0}", new string('#', countOfMiddHashtags), new string(' ', countOfMiddwhiteSpaces));
            Console.WriteLine("{0}|{1}T{1}|{0}", new string('#', countOfMiddHashtags), new string(' ', countOfMiddwhiteSpaces));

            int heightMiddlePart = size + 3;

            for (int i = 0; i < heightMiddlePart - 7; i++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('#', countOfHashtags), new string(' ', width - (2 * countOfHashtags + 2)));
            }
            Console.WriteLine("{0}|{1}U{1}|{0}", new string('#', countOfMiddHashtags), new string(' ', countOfMiddwhiteSpaces));
            Console.WriteLine("{0}|{1}N{1}|{0}", new string('#', countOfMiddHashtags), new string(' ', countOfMiddwhiteSpaces));
            Console.WriteLine("{0}|{1}I{1}|{0}", new string('#', countOfMiddHashtags), new string(' ', countOfMiddwhiteSpaces));

            Console.WriteLine("@{0}@", new string('=', width - 2));
            countOfHashtags += 2;
            for (int i = 0; i < size / 2; i++)
            {                
                Console.WriteLine("{0}|{1}|{0}", new string('#', countOfHashtags), new string(' ', width - (2 * countOfHashtags + 2)));
            }
            Console.WriteLine("{0}\\{1}/{0}", new string('#', countOfHashtags), new string('.', width - (2 * countOfHashtags + 2)));
        }
    }
}
