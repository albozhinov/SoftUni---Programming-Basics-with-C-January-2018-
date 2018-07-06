using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04
{
    class Balls
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int countOfRed = 0;
            int countOfOrange = 0;
            int countOfYellow = 0;
            int countOfWhite = 0;
            int countOfBlack = 0;
            int countOfOther = 0;
            double totalPoints = 0;

            for (int i = 0; i < n; i++)
            {
                string balls = Console.ReadLine();

                if (balls == "red")
                {
                    countOfRed++;
                    totalPoints += 5;
                }
                else if (balls == "orange")
                {
                    countOfOrange++;
                    totalPoints += 10;
                }
                else if (balls == "yellow")
                {
                    countOfYellow++;
                    totalPoints += 15;
                }
                else if (balls == "white")
                {
                    countOfWhite++;
                    totalPoints += 20;
                }
                else if (balls == "black")
                {
                    countOfBlack++;
                    totalPoints /= 2;
                }
                else
                {
                    countOfOther++;
                }
            }
            Console.WriteLine($@"Total points: {Math.Floor(totalPoints)}
Points from red balls: {countOfRed}
Points from orange balls: {countOfOrange}
Points from yellow balls: {countOfYellow}
Points from white balls: {countOfWhite}
Other colors picked: {countOfOther}
Divides from black balls: {countOfBlack}");         

        }
    }
}
