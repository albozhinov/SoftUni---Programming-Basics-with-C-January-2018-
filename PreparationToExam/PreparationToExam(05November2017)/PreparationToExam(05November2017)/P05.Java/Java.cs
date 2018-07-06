using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.Java
{
    class Java
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int width = size * 3 + 6;
            string equaly = new string('=', width - 1);


            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("{0}~ ~ ~", new string(' ', size));
            }
            Console.WriteLine(equaly);
            char tilde = '~';
            char whiteSpaces = ' ';
            int sizeOfTilde = 2 * size + 4;
            string tildeRows = new string(tilde, sizeOfTilde);
            string spacesRows = new string(whiteSpaces, size - 1);
            string row = "|{0}|{1}|";
            for (int i = 1; i <= size - 2; i++)
            {
                if (i == ((size - 2) / 2) + 1)
                {
                    Console.WriteLine("|{0}JAVA{0}|{1}|", new string(tilde, (sizeOfTilde - 4) / 2), spacesRows);
                    continue;
                }
                Console.WriteLine(row, tildeRows, spacesRows);
            }
            Console.WriteLine(equaly);
            char at = '@';
            int countAt = 2 * size + 4;
            int countWhiteSpaces = 0;
            string bottomROws = "{0}\\{1}/{0}";

            for (int k = 0; k < size; k++)
            {
                string atRows = new string(at, countAt);
                string spaces = new string(whiteSpaces, countWhiteSpaces);
                Console.WriteLine(bottomROws, spaces, atRows);
                countAt -= 2;
                countWhiteSpaces++;
            }

            Console.WriteLine(new string('=', 2 * size + 6));

            
        }
    }
}
