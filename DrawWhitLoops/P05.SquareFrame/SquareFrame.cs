using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.SquareFrame
{
    class SquareFrame
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int calcSize = size - 2;
            string topAndEndRow = "+";
            string middleRows = "|";

            for (int i = 0; i < calcSize; i++)
            {
                topAndEndRow += " -";
            }
            topAndEndRow += " +";
            Console.WriteLine(topAndEndRow);
            
            for (int i = 0; i < calcSize; i++)
            {
                middleRows += " -";
            }
            middleRows += " |";
            for (int i = 0; i < calcSize; i++)
            {
                Console.WriteLine(middleRows);
            }

            Console.WriteLine(topAndEndRow);
        }
    }
}
