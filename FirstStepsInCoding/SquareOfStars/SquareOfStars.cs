using System;

namespace SquareOfStars
{
    class SquareOfStars
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            
                Console.WriteLine(new string('*', N));

                for (int col = 0; col < N - 2; col++)
                {
                    Console.WriteLine("*" + new string(' ', N - 2) + "*");
                }
                Console.WriteLine(new string('*', N));            
        }
    }
}
