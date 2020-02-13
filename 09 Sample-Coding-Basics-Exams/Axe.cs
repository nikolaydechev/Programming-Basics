using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var width = 5 * n;
            var middleDash = 1;
            var rightDash = 2 * n - 3;

            var middleDash1 = n - 1;
            var rightDash1 = n - 1;
            var leftDash1 = 3 * n;

            Console.WriteLine(new string('-', n*3) + "**" + new string('-', 2*n-2));

            for (int i = 1; i <= n-1; i++)
            {
                Console.Write(new string('-', 3 * n) + "*");
                Console.Write(new string('-', middleDash) + "*");
                Console.Write(new string('-', rightDash));
                Console.WriteLine();
                middleDash += 1;
                rightDash -= 1;
            }
            for (int i = 1; i <= n/2; i++)
            {
                Console.Write(new string('*', 3 * n + 1));
                Console.Write(new string('-', n - 1) + "*");
                Console.Write(new string('-', n - 1));
                Console.WriteLine();
            }
            for (int i = 1; i <= (n-2)/2; i++)
            {
                Console.Write(new string('-', leftDash1) + "*");
                Console.Write(new string('-', middleDash1) + "*");
                Console.Write(new string('-', rightDash1));
                Console.WriteLine();
                leftDash1 -= 1;
                middleDash1 += 2;
                rightDash1 -= 1;
            }
            if (n%2 == 0)
            {
                Console.WriteLine(new string('-', (5 * n / 2) + 1) + new string('*', n * 2 - 1) + new string('-', n / 2));
            }
            else if (n%2 != 0)
            {
                Console.WriteLine(new string('-', (5*n+3)/2) + new string('*', n*2-2) + new string('-', (n+1)/2));
            }

        }
    }
}
