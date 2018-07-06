using System;
namespace RectangleArea
{
    class RectangleArea
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double rectangleArea = a * b;
            Console.WriteLine(rectangleArea);
        }
    }
}
