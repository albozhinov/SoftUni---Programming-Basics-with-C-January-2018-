using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.Crown_7May2017_
{
    class Crown
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int width = (2 * size) - 1;
            int height = (size / 2) + 4;

            Console.WriteLine("@{0}@{0}@", new string(' ', size - 2));
            Console.WriteLine("**{0}*{0}**", new string(' ', size - 3));

            int countOfWhiteSpaces = size - 5;
            int countOfMiddleDots = 1;
            int countOfSideDots = 1;
            for (int i = 1; i < (size / 2) - 1; i++)
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', countOfSideDots), new string(' ', countOfWhiteSpaces), new string('.', countOfMiddleDots));
                countOfWhiteSpaces -= 2;
                countOfMiddleDots += 2;
                countOfSideDots = 1 + i;
            }

            Console.WriteLine("*{0}*{1}*{0}*", new string('.', countOfSideDots), new string('.', countOfMiddleDots));
            countOfSideDots++;
            
            Console.WriteLine("*{0}{1}.{1}{0}*", new string('.', countOfSideDots), new string('*', countOfMiddleDots / 2));
            Console.WriteLine(new string('*', width));
            Console.WriteLine(new string('*', width));
        }
    }
}
