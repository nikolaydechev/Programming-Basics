using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var dots1 = (3 * n - 2) / 2;
            var spaces = 0;

            var dots2 = n / 2;
            var stars = 2 * n - 2;

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', dots1) + "/");
                Console.Write(new string(' ', spaces) + "\\");
                Console.Write(new string('.', dots1));
                Console.WriteLine();
                spaces += 2;
                dots1 -= 1;
            }
            Console.WriteLine(new string('.', n / 2) + new string('*', n * 2) + new string('.', n / 2));

            for (int i = 1; i <= n * 2; i++)
            {
                Console.Write(new string('.', n / 2) + "|");
                Console.Write(new string('\\', 2 * n - 2) + "|");
                Console.Write(new string('.', n / 2));
                Console.WriteLine();
            }
            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write(new string('.', dots2) + "/");
                Console.Write(new string('*', stars) + "\\");
                Console.Write(new string('.', dots2));
                Console.WriteLine();
                dots2 -= 1;
                stars += 2;
            }
        }
    }
}
