using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var width = 2 * n - 1;
            var height = 2 * (n - 2) + 1;
            
            if ((n-2) % 2 != 0)
            {
                Console.WriteLine(new string('*', n - 2) + new string('\\', 1) + new string(' ', 1) + new string('/', 1) + new string('*', n - 2));

                for (int i = 1; i <= (n - 3) / 2; i++)
                {
                    Console.WriteLine(new string('-', n - 2) + new string('\\', 1) + new string(' ', 1) + new string('/', 1) + new string('-', n - 2));

                    Console.WriteLine(new string('*', n - 2) + new string('\\', 1) + new string(' ', 1) + new string('/', 1) + new string('*', n - 2));
                }
                Console.WriteLine(new string(' ', n - 1) + "@" + new string(' ', n - 1));
                Console.WriteLine(new string('*', n - 2) + new string('/', 1) + new string(' ', 1) + new string('\\', 1) + new string('*', n - 2));

                for (int i = 1; i <= (n - 3) / 2; i++)
                {
                    Console.WriteLine(new string('-', n - 2) + new string('/', 1) + new string(' ', 1) + new string('\\', 1) + new string('-', n - 2));

                    Console.WriteLine(new string('*', n - 2) + new string('/', 1) + new string(' ', 1) + new string('\\', 1) + new string('*', n - 2));
                }
            }
            else if ((n - 2) % 2 == 0)
            {
                for (int i = 1; i <= (n - 2) / 2; i++)
                {
                    Console.WriteLine(new string('*', n - 2) + new string('\\', 1) + new string(' ', 1) + new string('/', 1) + new string('*', n - 2));
                    Console.WriteLine(new string('-', n - 2) + new string('\\', 1) + new string(' ', 1) + new string('/', 1) + new string('-', n - 2));
                }

                Console.WriteLine(new string(' ', n - 1) + "@" + new string(' ', n - 1));

                for (int i = 1; i <= (n - 2) / 2; i++)
                {
                    Console.WriteLine(new string('*', n - 2) + new string('/', 1) + new string(' ', 1) + new string('\\', 1) + new string('*', n - 2));
                    Console.WriteLine(new string('-', n - 2) + new string('/', 1) + new string(' ', 1) + new string('\\', 1) + new string('-', n - 2));

                }
            }
        }
    }
}
