using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7.SumSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int result = n1 + n2 + n3;

            if (result < 60)
            {
                Console.WriteLine($"0:{result.ToString("D2")}");
            }
            else if (result > 60 && result <= 119)
            {
                result -= 60;
                Console.WriteLine($"1:{result.ToString("D2")}");
            }
            else if (result > 120 && result <= 179)
            {
                result -= 120;
                Console.WriteLine($"2:{result.ToString("D2")}");
            }
            else if (result == 60)
            {
                Console.WriteLine($"1:00");
            }
            else if (result == 120)
            {
                Console.WriteLine("2:00");
            }
        }
    }
}
