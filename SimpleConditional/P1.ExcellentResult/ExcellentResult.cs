using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1.ExcellentResult
{
    class ExcellentResult
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            if (n >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }            
        }
    }
}
