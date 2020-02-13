using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_DivisionWithoutResidue
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var p1Count = 0.0;
            var p2Count = 0.0;
            var p3Count = 0.0;

            for (int i = 1; i <= n; i++)
            {
                var num = double.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    p1Count++;
                }
                if (num % 3 == 0)
                {
                    p2Count++;
                }
                if (num % 4 == 0)
                {
                    p3Count++;
                }
            }
            Console.WriteLine("{0:f2}%", (p1Count / n * 100));
            Console.WriteLine("{0:f2}%", (p2Count / n * 100));
            Console.WriteLine("{0:f2}%", (p3Count / n * 100));
        }
    }
}
