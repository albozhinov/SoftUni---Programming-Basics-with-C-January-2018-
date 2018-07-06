using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13.NumberPyramid
{
    class NumberPyramid
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberToPrint = 0;
            for (int row = 1; row <= n && numberToPrint != n; row++)
            {                
                for (int col = 0; col < row && numberToPrint != n; col++)
                {
                    numberToPrint++;
                    Console.Write(numberToPrint + " ");                    
                }
                Console.WriteLine();                                
            }
        }
    }
}
