using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.MultiplyTable
{
    class MultiplyTable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int lastDigit = n % 10;
            n /= 10;
            int midDigit = n % 10;
            n /= 10;
            int firstDigit = n % 10;

            for (int firstNumber = 1; firstNumber <= lastDigit; firstNumber++)
            {
                for (int secNumber = 1; secNumber <= midDigit; secNumber++)
                {
                    for (int thirdNumber = 1; thirdNumber <= firstDigit; thirdNumber++)
                    {
                        int result = firstNumber * secNumber * thirdNumber;
                        Console.WriteLine($"{firstNumber} * {secNumber} * {thirdNumber} = {result};");
                    }
                }
            }
        }
    }
}
