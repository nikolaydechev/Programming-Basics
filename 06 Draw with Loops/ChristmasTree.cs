using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var rows = n + 1;
            var cols = 2 * n + 3;

            for (int i = 0; i <= n; i++)
            {
                Console.Write(new string(' ', n - i) + new string('*', i) + (" | "));
                Console.Write(new string('*', i) + new string(' ', n - i));
                Console.WriteLine();
            }
        }
    }
}
