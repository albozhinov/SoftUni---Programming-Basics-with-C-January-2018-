using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.VetetableShop
{
    class PipeInPool
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double x = h * p1;
            double y = h * p2;
            double z = x + y;
            
            if (z <= v)
            {
                double p1Procent = (x / z) * 100;
                double p2Procent = (y / z) * 100;
                double z1 = (z / v * 100);
                Console.WriteLine($"The pool is {Math.Truncate(z1)}% full. Pipe 1: {Math.Truncate(p1Procent)}%. Pipe 2: {Math.Truncate(p2Procent)}%.");
            }
            else
            {
                double overFlows = Math.Abs(z - v);
                Console.WriteLine($"For {h} hours the pool overflows with {overFlows:f1} liters.");
            }
        }
    }
}
