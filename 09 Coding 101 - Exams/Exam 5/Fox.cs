using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var middleDash1 = n * 2 - 1;
            var stars = 2 * n - 1;

            var leftStars = (n - 1 )/ 2;
            var middleStars = n;

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('*', i) + "\\");
                Console.Write(new string('-', middleDash1) + "/");
                Console.Write(new string('*', i));
                Console.WriteLine();
                middleDash1 -= 2;
            }
            for (int i = 1; i <= n / 3; i++)
            {
                Console.Write("|" + new string('*', leftStars) + "\\");
                Console.Write(new string('*', middleStars) + "/");
                Console.Write(new string('*', leftStars) + "|");
                Console.WriteLine();
                leftStars += 1;
                middleStars -= 2;
            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('-', i) + "\\");
                Console.Write(new string('*', stars) + "/");
                Console.Write(new string('-', i));
                Console.WriteLine();
                stars -= 2;
            }
        }
    }
}
