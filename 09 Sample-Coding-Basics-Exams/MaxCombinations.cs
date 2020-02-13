using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var maxCount = int.Parse(Console.ReadLine());

            var counter = 0;

            for (int i = n1; i <= n2; i++)
            {
                for (int j = n1; j <= n2; j++)
                {
                    counter++;
                    if (counter > maxCount)
                    {
                        break;
                    }
                    Console.Write("<{0}-{1}>", i, j);
                }
            }
            Console.WriteLine();
        }
    }
}
