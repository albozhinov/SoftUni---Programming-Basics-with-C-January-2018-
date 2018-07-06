using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10.Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int topCeilingStar = size % 2 == 0 ? 2 : 1;
            int row = size % 2 == 0 ? 1 : 0;
            int rows = (size - row) / 2;
            int countDashes = (size - 1) / 2;
            int countMidDashes = topCeilingStar;
            string topAndBotRows = new string('-', countDashes) + new string('*', topCeilingStar) + new string('-', countDashes);

            Console.WriteLine(topAndBotRows);
            countDashes--;
            for (int i = 0; i < rows; i++)
            {

                string sideDashes = new string('-', countDashes);
                string midDashes = new string('-', countMidDashes);
                
                Console.WriteLine("{0}*{1}*{0}", sideDashes, midDashes);
                countDashes--;
                countMidDashes += 2;
            }
            rows--;
            countMidDashes -= 4;
            countDashes += 2;
            for (int i = 0; i < rows; i++)
            {
                string sideDashes = new string('-', countDashes);
                string midDashes = new string('-', countMidDashes);

                Console.WriteLine("{0}*{1}*{0}", sideDashes, midDashes);
                countDashes++;
                countMidDashes -= 2;
            }

            if (size > 2)
            {
                Console.WriteLine(topAndBotRows);
            }
        }
    }
}
