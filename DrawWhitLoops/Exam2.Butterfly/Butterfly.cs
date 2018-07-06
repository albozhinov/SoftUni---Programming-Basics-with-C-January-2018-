using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2.Butterfly
{
    class Butterfly
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var width = 2 * n - 1;
            var height = 2 * (n - 2) + 1;
            var sideWidth = n - 1;

            for (int i = 0; i < height / 2; i++)
            {
                char symbol = '*';

                if (i % 2 != 0)
                    symbol = '-';

                Console.WriteLine(new string(symbol, (width - 3) / 2) + "\\ /" + new string(symbol, (width - 3) / 2));
            }
            Console.WriteLine(new string(' ', n - 1) + "@");

            for (int k = 0; k < height / 2; k++)
            {
                char symbol = '*';

                if (k % 2 != 0)
                    symbol = '-';

                Console.WriteLine(new string(symbol, (width - 3) / 2) + "/ \\" + new string(symbol, (width - 3) / 2));
            }
        }
    }
}
