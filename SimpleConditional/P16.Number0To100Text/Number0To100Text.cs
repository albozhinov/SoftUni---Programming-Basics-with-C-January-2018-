using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16.Number0To100Text
{
    class Number0To100Text
    {
        static void Main(string[] args)
        {
            string[] numbersToNine = new string[]
            {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",};
            string[] number = new string[]
                { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};
            int num = int.Parse(Console.ReadLine());
            int secDigit = num % 10;
            if (num < 10)
            {

            }
        }
    }
}
