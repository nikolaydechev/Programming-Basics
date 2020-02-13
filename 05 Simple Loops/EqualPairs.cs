using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var currentSum = 0;
            var diff = 0;
            var maxdiff = 0;
            var previousSum = 0;
            for (int i = 1; i <= n; i++)
            {
                previousSum = currentSum;
                var number1 = int.Parse(Console.ReadLine());
                var number2 = int.Parse(Console.ReadLine());
                currentSum = number1 + number2;
                if (i > 1)
                {
                    diff = Math.Abs(currentSum - previousSum);
                    if (diff > maxdiff)
                    {
                        maxdiff = diff;
                    }
                }
            }
            if (maxdiff == 0)
            {
                Console.WriteLine("Yes, value={0}", currentSum);
            }
            else if (maxdiff != 0)
            {
                Console.WriteLine("No, maxdiff={0}", maxdiff);
            }
        }
    }
}

