using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('.', n) + new string('*', n*3) + new string('.', n));
            var dots1 = n - 1;
            var dotsInMiddle1 = 3 * n;
            var dots2 = 1;
            var dotsInMiddle2 = (5 * n) - 4;

            for (int i = 1; i <= n-1; i++)
            {
                Console.Write(new string('.', dots1) + "*");
                Console.Write(new string('.', dotsInMiddle1) + "*");
                Console.Write(new string('.', dots1));
                Console.WriteLine();
                dots1 -= 1;
                dotsInMiddle1 += 2;
            }
            Console.WriteLine(new string('*', 5*n));
            for (int i = 1; i <= n*2; i++)
            {
                Console.Write(new string('.', dots2) + "*");
                Console.Write(new string('.', dotsInMiddle2) + "*");
                Console.Write(new string('.', dots2));
                Console.WriteLine();
                dots2 += 1;
                dotsInMiddle2 -= 2;
            }
            Console.WriteLine(new string('.', (4 * n + 2) / 2) + new string('*', n-2) + new string('.', (4*n + 2) / 2));
        }
    }
}
