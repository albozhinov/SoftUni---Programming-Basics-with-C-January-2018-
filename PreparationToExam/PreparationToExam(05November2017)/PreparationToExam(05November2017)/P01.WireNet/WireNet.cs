using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01.WireNet
{
    class WireNet
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            double heightOfWireNet = double.Parse(Console.ReadLine());
            double pricePerMeter = double.Parse(Console.ReadLine());
            double weightPerMeter = double.Parse(Console.ReadLine());

            double peremeter = 2 * lenght + 2 * width;
            double cost = pricePerMeter * peremeter;
            double weight = (peremeter * heightOfWireNet) * weightPerMeter;

            Console.WriteLine("{0}", peremeter);
            Console.WriteLine("{0:f2}", cost);
            Console.WriteLine("{0:f3}", weight);

        }
    }
}
