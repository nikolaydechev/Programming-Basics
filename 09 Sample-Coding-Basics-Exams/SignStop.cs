using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignStop
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('.', n + 1) + new string('_', (n*2)+1) + new string('.', n + 1));
            var NumberOfPoints = n;
            var LowDash = (n * 2) - 1;

            var NumberOfPoints1 = 1;
            var LowDash1 = (n * 4) - 3;

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('.', NumberOfPoints) + "//" + new string('_', LowDash) + "\\\\" + new string('.', NumberOfPoints));
                Console.WriteLine();

                NumberOfPoints = NumberOfPoints - 1;
                LowDash = LowDash + 2;
            }
            Console.WriteLine("//" + new string('_', (4*n-6)/2) + "STOP!" + new string('_', (4 * n - 6) / 2) + "\\\\");
            Console.WriteLine("\\\\" + new string('_', (n * 4) - 1) + "//");

            for (int i = 1; i <= n-1; i++)
            {
                Console.Write(new string('.', NumberOfPoints1) + "\\\\" + new string('_', LowDash1) + "//" + new string('.', NumberOfPoints1));
                Console.WriteLine();

                NumberOfPoints1 += 1;
                LowDash1 -= 2;

            }
        }
    }
}
