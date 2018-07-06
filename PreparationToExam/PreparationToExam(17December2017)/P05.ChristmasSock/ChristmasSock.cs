using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.ChristmasSock
{
    class ChristmasSock
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int topMiddleChar = 2 * n;
            string border = "|";
            string middleDashes = string.Format("{0}{1}{0}", border, new string('-', topMiddleChar));            
            string middleStars = string.Format("{0}{1}{0}", border, new string('*', topMiddleChar));

            Console.WriteLine(middleDashes);
            Console.WriteLine(middleStars);
            Console.WriteLine(middleDashes);

            int topPart = 2 * n - 3;
            int tilde = 0;

            for (int rowsCounter = 0; rowsCounter <= topPart / 2; rowsCounter++)
            {
                tilde += 2;
                int countdashes = (topMiddleChar - tilde) / 2;
                string tildes = new string('~', tilde);
                string dashes = new string('-', countdashes);
                string row = string.Format("{0}{1}{2}{1}{0}", border, dashes, tildes);
                Console.WriteLine(row);
            }

            for (int secRowsCounter = 0; secRowsCounter < topPart / 2; secRowsCounter++)
            {
                tilde -= 2;
                int countdashes = (topMiddleChar - tilde) / 2;
                string tildes = new string('~', tilde);
                string dashes = new string('-', countdashes);
                string row = string.Format("{0}{1}{2}{1}{0}", border, dashes, tildes);
                Console.WriteLine(row);
            }
            int bottomPartSize = n + 3;
            int middleChars = 2 * n + 1;
            string bottomBorder = "\\";
            int xmasRow = (bottomPartSize + 1) / 2;
            int merryRow = xmasRow - 2;           

            for (int bottomRowCount = 0; bottomRowCount < bottomPartSize; bottomRowCount++)
            {
                int dashesCounter = bottomRowCount;
                string bottomDashes = new string('-', dashesCounter);
                string bottomRow = "";
                int dotsCount = (middleChars - 5) / 2;

                if (bottomRowCount == merryRow)
                {                   
                    string dots = new string('.', dotsCount);
                    bottomRow = string.Format("{0}{1}{2}MERRY{2}{1}", bottomDashes, bottomBorder, dots);
                    Console.WriteLine(bottomRow);
                }
                else if (bottomRowCount == xmasRow)
                {                    
                    
                    string dots = new string('.', dotsCount);
                    bottomRow = string.Format("{0}{1}{2}X-MAS{2}{1}", bottomDashes, bottomBorder, dots);
                    Console.WriteLine(bottomRow);
                }
                else if (bottomPartSize - 1  == bottomRowCount)
                {
                    string lowerDashs = new string('_', middleChars);
                    
                    bottomRow = string.Format("{0}{1}{2})", bottomDashes, bottomBorder, lowerDashs);
                    Console.WriteLine(bottomRow); 
                }
                else
                {                     
                    string dots = new string('.', middleChars);
                    bottomRow = string.Format("{0}{1}{2}{1}", bottomDashes, bottomBorder, dots);
                    Console.WriteLine(bottomRow);
                }                
            }
        }
    }
}
