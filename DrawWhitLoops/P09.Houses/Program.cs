using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09.Houses
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int topStarOFHouse = size % 2 == 0 ? 2 : 1;
            int ceilingHOuse = (size + 1) / 2;
            int countOfDashes = (size - topStarOFHouse) / 2;

            for (int i = 0; i < ceilingHOuse; i++)
            {
                string stars = new string('*', topStarOFHouse);
                string dashes = new string('-', countOfDashes);
                Console.Write("{0}{1}{0}", dashes, stars);

                topStarOFHouse += 2;
                countOfDashes--;
                Console.WriteLine();
            }
            int bodyHouse = (size / 2) - 1;

            for (int i = 0; i <= bodyHouse; i++)
            {
                string bodyStars = new string('*', size - 2);

                Console.WriteLine("|{0}|", bodyStars);
            }
        }
    }
}
