using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam04.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int vineyard = int.Parse(Console.ReadLine());
            double grapes = double.Parse(Console.ReadLine());
            int wineLitters = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double sumGrapes = vineyard * grapes;
            double wine = (0.4 * sumGrapes) / 2.5;
            double diff = Math.Abs(wine - wineLitters);
            double workersPart = diff / workers;

            if (wine > wineLitters || wine == wineLitters)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(diff)} liters left -> {Math.Ceiling(workersPart)} liters per person.");                
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(diff)} liters wine needed.");
            }
        }
    }
}
