using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09.SumDigits
{
    class SumDigits
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            var sum = 0;           

            while (n != 0)
            {
                int lastDigit = n % 10;
                sum += lastDigit;
                n = n / 10;
            }
            Console.WriteLine(sum);

            // Vtoro Reshenie !!!
            //string num = Console.ReadLine(); 
            //for (int i = 0; i < num.Length; i++)
            //{
            //    int number = int.Parse(num[i].ToString());
            //    sum += number;
            //}
            //Console.WriteLine(sum);
        }
    }
}
