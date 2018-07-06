using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11.EqualWords
{
    class EqualWords
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string input1 = Console.ReadLine().ToLower();

            if (input == input1)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
