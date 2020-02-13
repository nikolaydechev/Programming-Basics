using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_PerfectDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var emptySpace = n - 2;
            var emptySpace1 = 1;

            if (n == 1)
            {
                Console.WriteLine("*");
            }
            if (n > 1)
            {
                Console.WriteLine(new string(' ', n - 1) + "*" + new string(' ', n - 1));

                for (int i = 1; i <= n - 1; i++)
                {
                    Console.Write(new string(' ', emptySpace) + "*" + "-" + "*");
                    if (i > 1)
                    {
                        for (int j = 2; j <= i; j++)
                        {
                            Console.Write("-");
                            Console.Write("*");
                        }
                    }
                    Console.WriteLine();
                    emptySpace -= 1;
                }

                for (int i = 1; i <= n - 2; i++)
                {
                    Console.Write(new string(' ', emptySpace1) + "*" + "-" + "*");
                    for (int j = n - 3; j >= i; j--)
                    {
                        Console.Write("-");
                        Console.Write("*");

                    }
                    Console.WriteLine();
                    emptySpace1 += 1;
                }
                Console.WriteLine(new string(' ', n - 1) + "*" + new string(' ', n - 1));
            }
            
        }
    }
}
