using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3.Stop
{
    class Stop
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
                       
            var pointNumber = n + 1;
            var underscore = (n * 2) + 1;

            Console.WriteLine(new string('.', pointNumber) + new string('_', underscore) + new string('.', pointNumber));
            pointNumber--;
            underscore -= 2;
            for (int i = 0; i < n; i++)
            {                
                Console.WriteLine(new string('.', pointNumber) + "//" + new string('_', underscore) + "\\\\" + new string('.', pointNumber));
                underscore += 2;
                pointNumber--;
            }
            Console.WriteLine("//" + new string('_', (underscore - 5) / 2) + "STOP!" + new string('_', (underscore - 5) / 2) + "\\\\");

            for (int k = 0; k < n; k++)
            {
                Console.WriteLine(new string('.', pointNumber) + "\\\\" + new string('_', underscore) + "//" + new string('.', pointNumber));
                underscore -= 2;
                pointNumber++;
            }
        }
    }
}
