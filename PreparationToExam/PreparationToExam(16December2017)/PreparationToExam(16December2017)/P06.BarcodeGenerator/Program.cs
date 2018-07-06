using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine();
            string secNum = Console.ReadLine();
            char zero = '0';

            int firstDigit1 = firstNum[0] - zero;
            int secDigit1 = firstNum[1] - zero;
            int thirdDigit1 = firstNum[2] - zero;
            int fourthDigit1 = firstNum[3] - zero;

            int firstDigit2 = secNum[0] - zero;
            int secDigit2 = secNum[1] - zero;
            int thirdDigit2 = secNum[2] - zero;
            int fourthDigit2 = secNum[3] - zero;


            for (int i = firstDigit1; i <= firstDigit2; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                for (int j = secDigit1; j <= secDigit2; j++)
                {
                    if (j % 2 == 0)
                    {
                        continue;
                    }
                    for (int k = thirdDigit1; k <= thirdDigit2; k++)
                    {
                        if (k % 2 == 0)
                        {
                            continue;
                        }
                        for (int c = fourthDigit1; c <= fourthDigit2; c++)
                        {
                            if (c % 2 != 0)
                            {
                                Console.Write("{0}{1}{2}{3} ", i, j, k, c);
                            }                            
                        }
                    }
                }
            }
        }
    }
}
