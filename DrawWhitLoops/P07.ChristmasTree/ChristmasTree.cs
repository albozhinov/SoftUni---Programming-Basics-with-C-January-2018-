using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07.ChristmasTree
{
    class ChristmasTree
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int sizeRows = size + 1;
            int countWhiteSpacec = size;

            //for (int row = 0; row < sizeRows; row++)
            //{
            //    for (int i = 0; i < countWhiteSpacec; i++)
            //    {
            //        Console.Write(' ');
            //    }
            //    for (int i = 0; i < row; i++)
            //    {
            //        Console.Write('*');
            //    }

            //    Console.Write(" | ");

            //    for (int i = 0; i < row; i++)
            //    {
            //        Console.Write('*');
            //    }

            //    countWhiteSpacec--;
            //    Console.WriteLine();
            //}

            for (int row = 0; row < sizeRows; row++)
            {
                Console.Write(new string(' ', countWhiteSpacec));
                Console.Write(new string('*', row));
                Console.Write(" | ");
                Console.Write(new string('*', row));
                countWhiteSpacec--;
                Console.WriteLine();
            }
        }
    }
}
