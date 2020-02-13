using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citadel
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var width = 2 * n;

           
            Console.WriteLine(new string('/', 1) + 
                new string('^', n / 2) + 
                new string('\\', 1) + 
                new string('_', 2*n-4-2*(n/2)) + 
                new string('/', 1) +
                new string('^', n / 2) + 
                new string('\\', 1));

            for (int i = 1; i < n-2; i++)
            {
                Console.Write(new string('|', 1));
                Console.Write(new string(' ', (2 * n) - 2));
                Console.Write(new string('|', 1));
                Console.WriteLine();
            }
            Console.WriteLine(new string('|', 1) + new string(' ', n/2+1) + new string('_', 2 * n - 4 - 2 * (n / 2)) + new string(' ', n/2+1) +
                new string('|', 1));

            Console.WriteLine(new string('\\', 1) + new string('_', n/2) + new string('/', 1) +new string(' ', 2 * n - 4 - 2 * (n / 2)) + 
                new string('\\',1) + new string('_', n/2) + new string('/', 1));
                
        }
    }
}
