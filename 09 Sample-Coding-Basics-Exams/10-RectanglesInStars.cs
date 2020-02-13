using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_RectanglesInStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());


            if (n % 2 != 0)
            {
                Console.WriteLine(new string('%', 2 * n));
                for (int i = 1; i <= n / 2; i++)
                {
                    Console.Write("%" + new string(' ', 2 * n - 2) + "%");
                    Console.WriteLine();
                }
                Console.WriteLine("%" + new string(' ', n - 2) + "**" + new string(' ', n - 2) + "%");
                for (int i = 1; i <= n / 2; i++)
                {
                    Console.Write("%" + new string(' ', 2 * n - 2) + "%");
                    Console.WriteLine();
                }
                Console.WriteLine(new string('%', 2 * n));
            }

            if (n % 2 == 0)
            {
                Console.WriteLine(new string('%', 2 * n));

                for (int i = 1; i <= (n - 1) / 2; i++)
                {
                    Console.Write("%" + new string(' ', 2 * n - 2) + "%");
                    Console.WriteLine();
                }
                Console.WriteLine("%" + new string(' ', n - 2) + "**" + new string(' ', n - 2) + "%");

                for (int i = 1; i <= (n - 1) / 2; i++)
                {
                    Console.Write("%" + new string(' ', 2 * n - 2) + "%");
                    Console.WriteLine();
                }
                Console.WriteLine(new string('%', 2 * n));

            }
        }
    }
}
