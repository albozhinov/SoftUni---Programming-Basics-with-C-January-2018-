using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12.SpeedInfo
{
    class SpeedInfo
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string speedInfo = "slow";

            if (n > 10 && n <= 50)
            {
                speedInfo = "average";
            }
            else if (n > 50 && n <= 150)
            {
                speedInfo = "fast";
            }
            else if (n > 150 && n <= 1000)
            {
                speedInfo = "ultra fast";
            }
            else if (n > 1000)
            {
                speedInfo = "extremely fast";
            }

            Console.WriteLine(speedInfo);
        }
    }
}
