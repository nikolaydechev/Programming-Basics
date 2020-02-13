using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('.', n) + new string('*', 3 * n) + new string('.', n));

            var upperPoints = n - 1;
            var middlePoints = 3 * n;
            var lowerPoints = 1;
            var middlePoints1 = 5 * n - 4;

            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write(new string('.', upperPoints) + "*");
                Console.Write(new string('.', middlePoints) + "*");
                Console.Write(new string('.', upperPoints));
                upperPoints -= 1;
                middlePoints += 2;
                Console.WriteLine();
            }

            Console.WriteLine(new string('*', 5 * n));

            for (int i = 1; i <= 2 * n; i++)
            {
                Console.Write(new string('.', lowerPoints) + "*");
                Console.Write(new string('.', middlePoints1) + "*");
                Console.Write(new string('.', lowerPoints));
                lowerPoints += 1;
                middlePoints1 -= 2;
                Console.WriteLine();
            }
            Console.WriteLine(new string('.', 2 * n + 1) + new string('*', n - 2) + new string('.', 2 * n + 1));
        }
    }
}
