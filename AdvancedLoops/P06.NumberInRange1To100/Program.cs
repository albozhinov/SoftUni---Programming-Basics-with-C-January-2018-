using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.NumberInRange1To100
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());          
               
            while (n <= 0 || n > 100)
            {
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(n);
        }
    }
}
