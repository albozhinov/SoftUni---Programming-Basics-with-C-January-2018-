using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15.ThreeEqualsNumbers
{
    class ThreeEqualsNumbers
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());
            string result = "no";
            if (n1 == n2 && n1 == n3 && n2 == n3)
            {
                result = "yes";
            }
            Console.WriteLine(result);
        }
    }
}
