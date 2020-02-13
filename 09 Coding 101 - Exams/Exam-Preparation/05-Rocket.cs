using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var UpperPoints = (3 * n - 2) / 2;
            var UpperSpace = 0;
            var LowerPoints = n / 2;
            var LowerStars = 2 * n - 2;

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('.', UpperPoints) + "/" + new string(' ', UpperSpace) + "\\" + new string('.', UpperPoints));
                Console.WriteLine();
                UpperPoints -= 1;
                UpperSpace += 2;
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
                Console.Write(new string('.', LowerPoints) + "/");
                Console.Write(new string('*', LowerStars) + "\\");
                Console.Write(new string('.', LowerPoints));
                Console.WriteLine();
                LowerPoints -= 1;
                LowerStars += 2;
            }
        }
    }
}
