using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.LuckyNumbers
{
    class LuckyNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int firstDigit = 1; firstDigit <= 9; firstDigit++)
            {
                for (int secDigit = 1; secDigit <= 9; secDigit++)
                {                    
                    for (int thirdDigit = 1; thirdDigit <= 9; thirdDigit++)
                    {
                        for (int fourthDigit = 1; fourthDigit <= 9; fourthDigit++)
                        {
                            bool equalNumber = (firstDigit + secDigit) == (thirdDigit + fourthDigit);
                            bool division = number % (firstDigit + secDigit) == 0;
                            if (equalNumber && division)
                            {
                                Console.Write("{0}{1}{2}{3} ", firstDigit, secDigit, thirdDigit , fourthDigit);
                            }                            
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
