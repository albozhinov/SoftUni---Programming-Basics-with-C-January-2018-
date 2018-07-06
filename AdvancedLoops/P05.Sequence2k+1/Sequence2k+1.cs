using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.Sequence2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var result = 1;

            for (int i = 0; i < n && result <= n; i++)
            {               
                Console.WriteLine(result);
                result = (result * 2) + 1;
            }
        }
    }
}
