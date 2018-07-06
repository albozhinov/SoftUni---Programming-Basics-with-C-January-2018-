using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05
{
    class Arrow
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int width = size + 5;

            Console.WriteLine("{0}^{0}", new string('_', (width - 1) / 2));
            Console.WriteLine("{0}/|\\{0}", new string('_', (width -3) / 2));

            int countOfTire = (width - 5) / 2;
            //int part = size / 2 + 2;

            for (int i = 0; i < size / 2; i++)
            {
                Console.WriteLine("{0}/{1}|||{1}\\{0}", new string('_', countOfTire - i), new string('.', i));                
            }
            Console.WriteLine("{0}/..|||..\\{0}", new string('_', (width - 9) / 2));
            Console.WriteLine("{0}/.|||.\\{0}", new string('_', (width - 7) / 2));


            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("{0}|||{0}", new string('_', (width - 3)/ 2));
            }
            Console.WriteLine("{0}~~~{0}", new string('_', (width - 3) / 2));

            for (int i = 0; i < size / 2; i++)
            {
                Console.WriteLine("{0}//{1}!{1}\\\\{0}", new string('_', ((width - 5) / 2) - i), new string('.', i));
            }
        }
    }
}
