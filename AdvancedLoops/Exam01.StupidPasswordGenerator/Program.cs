using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam01.StupidPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int firstSymbol = 1; firstSymbol < n; firstSymbol++)
            {
               
                for (int secSymbol = 1; secSymbol < n; secSymbol++)
                {
                    
                    for (int thirdSymbol = 'a'; thirdSymbol < 'a' + l ; thirdSymbol++)
                    {
                        
                        for (int fourthSymbol = 'a' ; fourthSymbol < 'a' + l; fourthSymbol++)
                        {
                            
                            for (int fifthSymbol = 1; fifthSymbol <= n; fifthSymbol++)
                            {
                                if (firstSymbol < fifthSymbol && secSymbol < fifthSymbol)
                                {
                                    Console.Write("{0}{1}{2}{3}{4} ", firstSymbol, secSymbol, (char)thirdSymbol, (char)fourthSymbol, fifthSymbol);
                                }
                                
                            }                            
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
