using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02.Lutenica
{
    class Lutenica
    {
        static void Main(string[] args)
        {
            double quantityOfTomato = double.Parse(Console.ReadLine());
            int countOfCasette = int.Parse(Console.ReadLine());
            int countOfJars = int.Parse(Console.ReadLine());

            double quantityOfKetchup = quantityOfTomato / 5;
            double jars = quantityOfKetchup / 0.535;
            double casette = jars / countOfJars;

            Console.WriteLine($"Total lutenica: {Math.Floor(quantityOfKetchup)} kilograms.");

            if (casette > countOfCasette)
            {
                casette -= countOfCasette;
                jars -= countOfJars * countOfCasette;
                Console.WriteLine($"{Math.Floor(casette)} boxes left.");
                Console.WriteLine($"{Math.Floor(jars)} jars left.");
            }
            else
            {
                double neededBoxes = countOfCasette - casette;
                double neededJars = (countOfJars * countOfCasette) - jars;
                Console.WriteLine($"{Math.Floor(neededBoxes)} more boxes needed.");
                Console.WriteLine($"{Math.Floor(neededJars)} more jars needed.");
            }
        }
    }
}
