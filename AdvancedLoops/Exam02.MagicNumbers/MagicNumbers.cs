using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.MagicNumbers
{
    class MagicNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 1;
            for (int fDigit = 1; fDigit <= 9; fDigit++)
            {
                for (int sDigit = 1; sDigit <= 9; sDigit++)
                {
                    for (int tDigit = 1; tDigit <= 9; tDigit++)
                    {
                        for (int fourDigit = 1; fourDigit <= 9; fourDigit++)
                        {
                            for (int fiveDigit = 1; fiveDigit <= 9; fiveDigit++)
                            {
                                for (int sixDigit = 1; sixDigit <= 9; sixDigit++)
                                {
                                    result = fDigit * sDigit * tDigit * fourDigit * fiveDigit * sixDigit;
                                    if (result == n)
                                    {
                                        Console.Write("{0}{1}{2}{3}{4}{5} ", fDigit, sDigit, tDigit, fourDigit, fiveDigit, sixDigit);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
