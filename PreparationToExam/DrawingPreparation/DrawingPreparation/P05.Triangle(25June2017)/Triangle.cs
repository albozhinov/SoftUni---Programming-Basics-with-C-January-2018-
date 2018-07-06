using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.Triangle_25June2017_
{
    class Triangle
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int width = (4 * size) + 1;
            int height = (2 * size) + 1;

            char hashtag = '#';
            char whiteSpaces = ' ';
            char dots = '.';
            int countOfHashtags = (width - 2) / 2;
            int countOfWhiteSpaces = 1;
            int countOfDots = 1;
            string format = "{0}{1}{2}{1}{0}";

            Console.WriteLine(new string(hashtag, width));
            
            for (int i = 0; i < size; i++)
            {
                if (size / 2 == i)
                {
                    string symbol = "(@)";
                    Console.WriteLine("{0}{1}{2}{3}{2}{1}{0}", new string(dots, countOfDots), new string(hashtag, countOfHashtags), new string(whiteSpaces, (countOfWhiteSpaces - symbol.Length) / 2), symbol);
                }
                else
                {
                    Console.WriteLine(format, new string(dots, countOfDots), new string(hashtag, countOfHashtags), new string(whiteSpaces, countOfWhiteSpaces));
                }                
                countOfDots++;
                countOfWhiteSpaces += 2;
                countOfHashtags -= 2;
            }
            countOfHashtags = countOfWhiteSpaces - 2;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string(dots, countOfDots), new string(hashtag, countOfHashtags));
                countOfHashtags -= 2;
                countOfDots++;
            }
        }
    }
}
