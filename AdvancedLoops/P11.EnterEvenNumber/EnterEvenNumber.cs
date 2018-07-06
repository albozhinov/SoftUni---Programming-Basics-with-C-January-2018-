using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11.EnterEvenNumber
{
    class EnterEvenNumber
    {
        static void Main(string[] args)
        {
            int number = 1;
            var evenNum = int.TryParse(Console.ReadLine(), out number);
            
            
            while (!evenNum || number % 2 != 0)
            {
                evenNum = int.TryParse(Console.ReadLine(), out number);

            }
            Console.WriteLine(number);
        }
    }
}
