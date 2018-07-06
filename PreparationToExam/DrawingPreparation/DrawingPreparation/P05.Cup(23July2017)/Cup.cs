using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.Cup_23July2017_
{
    class Cup
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int width = 5 * size;

            char dot = '.';
            char hashtag = '#';
            string format = "{0}{1}{0}";
            int countOfDots = size;
            int countOfHashtags = 3 * size;             

            for (int i = 0; i < size / 2; i++)
            {
                Console.WriteLine(format, new string(dot, countOfDots), new string(hashtag, countOfHashtags));
                countOfDots++;
                countOfHashtags -= 2;
            }

            int countOfMiddleDots = countOfHashtags - 2;

            for (int i = 0; i <= size / 2; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string(dot, countOfDots), new string(dot, countOfMiddleDots));
                countOfMiddleDots -= 2;
                countOfDots++;
            }
            countOfDots--;
            countOfHashtags = size;
            Console.WriteLine(format, new string(dot, countOfDots), new string(hashtag, countOfHashtags));

            countOfHashtags = size + 4;
            countOfDots -= 2;
            int countOfDotsDanceRow = (countOfHashtags - 10) / 2;
            
            for (int i = 0; i < size + 2; i++)
            {

                if (size / 2 == i)
                {
                    Console.WriteLine("{0}D^A^N^C^E^{0}", new string(dot, countOfDots + countOfDotsDanceRow));
                }
                else
                {
                    Console.WriteLine(format, new string(dot, countOfDots), new string(hashtag, countOfHashtags));
                }                
            }
        }
    }
}
