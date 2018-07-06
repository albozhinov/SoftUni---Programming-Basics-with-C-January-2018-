using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08.Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int frameSize = size * 2;
            int glassesSize = (2 * size) - 2;
            string topAndBottomLine = new string('*', frameSize) + new string(' ', size) + new string('*', frameSize);
            string middleLine = "*" + new string('/', glassesSize) + "*";
            string whiteSpacec = new string(' ', size);

            Console.WriteLine(topAndBottomLine);
            for (int i = 0; i < size - 2; i++)
            {                
                if ((size - 1) / 2 - 1 == i)
                {
                    Console.WriteLine("{0}{1}{0}", middleLine, new string('|', size));                    
                }
                else
                {
                    Console.WriteLine("{0}{1}{0}", middleLine, whiteSpacec);
                }               
            }
            Console.WriteLine(topAndBottomLine);
            
        }
    }
}
