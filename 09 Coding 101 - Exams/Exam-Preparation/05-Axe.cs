using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var upperDash = 1;
            var upperDash1 = 2 * n - 3;
            var lowerDash = n - 1;
            var lowerDash1 = n - 1;
            var leftDash = 3 * n;
            
            Console.WriteLine(new string('-', 3 * n) + "**" + new string('-', 2 * n - 2));

            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write(new string('-', 3 * n) + "*");
                Console.Write(new string('-', upperDash) + "*");
                Console.Write(new string('-', upperDash1));
                upperDash += 1;
                upperDash1 -= 1;
                Console.WriteLine();
            }

            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write(new string('*', 3 * n + 1));
                Console.Write(new string('-', n - 1) + "*");
                Console.Write(new string('-', n - 1));
                Console.WriteLine();
            }

            for (int i = 1; i < n / 2; i++)
            {
                Console.Write(new string('-', leftDash) + "*");
                Console.Write(new string('-', lowerDash) + "*");
                Console.Write(new string('-', lowerDash1));

                lowerDash1 -= 1;
                lowerDash += 2;
                leftDash -= 1;

                Console.WriteLine();
            }
            if (n % 2 == 0)
            {
                Console.WriteLine(new string('-', (5 * n + 2) / 2) + new string('*', n * 2 - 1) + new string('-', n / 2));
            }
            else if (n % 2 != 0)
            {
                Console.WriteLine(new string('-', (5*n+3)/2) + new string('*', 2*n-2) + new string('-', (n+1)/2));
            }
        }
    }
}
