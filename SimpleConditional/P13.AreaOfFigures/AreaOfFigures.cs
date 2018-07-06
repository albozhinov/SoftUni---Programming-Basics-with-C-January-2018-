using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13.AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string inputFigure = Console.ReadLine();

            if (inputFigure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f3}", Math.Pow(side, 2));
                return;
            }
            else if (inputFigure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f3}", sideA * sideB);
                return;
            }
            else if (inputFigure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double result = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"{result:f3}");
                return;
            }
            else if (inputFigure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double result = (side * height) / 2;
                Console.WriteLine($"{result:f3}");
                return;
            }
        }
    }
}
