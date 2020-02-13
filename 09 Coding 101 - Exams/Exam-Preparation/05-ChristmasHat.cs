using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ChristmasHat
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var dots = 2 * n - 1;
            var dash = 0;

            Console.WriteLine(new string('.', 2 * n - 1) + "/" + "|" + "\\" + new string('.', 2 * n - 1));
            Console.WriteLine(new string('.', 2 * n - 1) + "\\" + "|" + "/" + new string('.', 2 * n - 1));

            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write(new string('.', dots) + "*" + new string('-', dash) + "*" + new string('-', dash) + "*" + new string('.', dots));
                Console.WriteLine();
                dots -= 1;
                dash += 1;

            }
            Console.WriteLine(new string('*', 4 * n + 1));

            for (int i = 0; i < 4 * n / 2; i++)
            {
                Console.Write(new string('*', 1));
                Console.Write(new string('.', 1));
            }
            Console.WriteLine("*");
            Console.WriteLine(new string('*', 4 * n + 1));



        }
    }
}
