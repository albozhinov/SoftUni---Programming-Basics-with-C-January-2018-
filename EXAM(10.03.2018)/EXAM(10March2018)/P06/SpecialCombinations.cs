using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06
{
    class SpecialCombinations
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());


            for (int firstDigit = 2; firstDigit <= firstNum; firstDigit += 2)
            {
               
                for (int secDigit = 2; secDigit <= secondNum; secDigit++)
                {
                    if (secDigit != 2 && secDigit != 3 && secDigit != 5 && secDigit != 7)
                    {
                        continue;
                    }

                    for (int thirtDigit = 2; thirtDigit <= thirdNum; thirtDigit += 2)
                    {
                        Console.WriteLine($"{firstDigit} {secDigit} {thirtDigit}");                        
                    }
                }
            }
        }
    }
}
