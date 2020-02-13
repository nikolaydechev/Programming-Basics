using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Sign_Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('.', n + 1) + new string('_', 2 * n + 1) + new string('.', n + 1));

            var numberPoints = n;
            var underscore = n * 2 - 1;

            var numberPoints1 = 0;
            var underscore1 = 4 * n - 1;

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('.', numberPoints) + "//");
                Console.Write(new string('_', underscore) + "\\\\");
                Console.Write(new string('.', numberPoints));
                numberPoints = numberPoints - 1;
                underscore = underscore + 2;
                Console.WriteLine();
            }
            Console.WriteLine("//" + new string('_', (4 * n - 6) / 2) + "STOP!" + new string('_', (4 * n - 6) / 2) + "\\\\");

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('.', numberPoints1) + "\\\\" + new string('_', underscore1) + "//" + new string('.', numberPoints1));
                numberPoints1 = numberPoints1 + 1;
                underscore1 = underscore1 - 2;
                Console.WriteLine();
            }
        }
    }
}
