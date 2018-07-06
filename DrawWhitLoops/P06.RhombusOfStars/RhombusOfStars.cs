using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.RhombusOfStars
{
    class RhombusOfStars
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int calcSize = size - 1;
            int countWhiteSpacec = size - 1;

            for (int row = 1; row <= size; row++)
            {
                for (int k = 0; k < countWhiteSpacec; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");

                for (int col = 0; col < row - 1; col++)
                {
                    Console.Write(" *");
                }
                countWhiteSpacec--;
                Console.WriteLine();
            }
            countWhiteSpacec = 1;
            for (int row = calcSize; row > 0; row--)
            {
                for (int k = 0; k < countWhiteSpacec; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");

                for (int col = 0; col < row - 1; col++)
                {
                    Console.Write(" *");
                }
                countWhiteSpacec++;
                Console.WriteLine();
            }
        }
    }
}
