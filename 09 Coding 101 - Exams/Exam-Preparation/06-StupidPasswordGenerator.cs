using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_StupidPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var L = int.Parse(Console.ReadLine());

            for (int a = 1; a <= n; a++)
            {
                for (int b = 1; b <= n; b++)
                {
                    for (char c = 'a'; c < 'a' + L; c++)
                    {
                        for (char d = 'a'; d < 'a' + L; d++)
                        {
                            for (int e = Math.Max(a, b) +1; e <= n; e++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", a, b, c, d, e);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}



