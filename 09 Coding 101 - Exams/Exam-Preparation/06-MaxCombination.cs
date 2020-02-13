using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_MaxCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());

            var counter = 0;

            for (int i = n1; i <= n2; i++)
            {
                for (int j = n1; j <= n2; j++)
                {
                    if (counter == max)
                    {
                        break;
                    }
                    Console.Write("<{0}-{1}>", i, j);
                    counter++;
                }
               
            }
            Console.WriteLine();
        }
    }
}
