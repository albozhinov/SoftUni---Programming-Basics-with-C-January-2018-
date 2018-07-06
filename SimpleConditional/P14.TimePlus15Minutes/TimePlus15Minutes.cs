using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14.TimePlus15Minutes
{
    class TimePlus15Minutes
    {
        static void Main()
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secNum = int.Parse(Console.ReadLine());

            secNum += 15;
            if (secNum >= 60)
            {
                firstNum++;
                secNum -= 60;
            }
            if (firstNum == 24)
            {
                firstNum -= 24;
            }
            Console.WriteLine($"{firstNum}:{secNum:D2}");

        }
    }
}
