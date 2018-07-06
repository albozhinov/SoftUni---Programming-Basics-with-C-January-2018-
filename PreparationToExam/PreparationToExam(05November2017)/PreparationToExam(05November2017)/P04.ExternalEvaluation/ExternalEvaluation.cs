using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.ExternalEvaluation
{
    class ExternalEvaluation
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double poorCounter = 0;
            double satisfactoryCounter = 0;
            double goodCounter = 0;
            double verygoodCounter = 0;
            double excellentCounter = 0;

            for (int i = 0; i < n; i++)
            {
                double points = double.Parse(Console.ReadLine());

                if (points < 22.5)
                {
                    poorCounter++;
                }
                else if (points >= 22.5 && points < 40.5)
                {
                    satisfactoryCounter++;
                }
                else if (points >= 40.5 && points < 58.5)
                {
                    goodCounter++;
                }
                else if (points >= 58.5 && points < 76.5)
                {
                    verygoodCounter++;
                }
                else if (points >= 76.5)
                {
                    excellentCounter++;
                }
            }
            poorCounter = (poorCounter / n) * 100;
            satisfactoryCounter = (satisfactoryCounter / n) * 100;
            goodCounter = (goodCounter / n) * 100;
            verygoodCounter = (verygoodCounter / n) * 100;
            excellentCounter = (excellentCounter / n) * 100;
            
            Console.WriteLine($@"{poorCounter:f2}% poor marks
{satisfactoryCounter:f2}% satisfactory marks
{goodCounter:f2}% good marks
{verygoodCounter:f2}% very good marks
{excellentCounter:f2}% excellent marks");
        }
    }
}
