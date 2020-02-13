using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var OddSum = 0.0;
            var EvenSum = 0.0;
            var OddMin = double.MaxValue;
            var OddMax = double.MinValue;
            var EvenMin = double.MaxValue;
            var EvenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                var number = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    EvenSum += number;
                    if (number > EvenMax)
                    {
                        EvenMax = number;
                    }
                    if (number < EvenMin)
                    {
                        EvenMin = number;
                    }
                }
                else
                {
                    OddSum += number;
                    if (number > OddMax)
                    {
                        OddMax = number;
                    }
                    if (number < OddMin)
                    {
                        OddMin = number;
                    }
                }
            }
            if (n == 0)
            {
                Console.WriteLine("OddSum=0,\nOddMin=No,\nOddMax=No\nEvenSum=0,\nEvenMin=No,\nEvenMax=No");
            }
            if (n == 1)
            {
                Console.WriteLine("OddSum={0},\nOddMin={1},\nOddMax={2}\nEvenSum=0,\nEvenMin=no,\nEvenMax=no"
                , OddSum, OddMin, OddMax);
            }
            else
            {
                Console.WriteLine("OddSum={0},\nOddMin={1}, \nOddMax={2}", OddSum, OddMin, OddMax);
                Console.WriteLine("EvenSum={0}, \nEvenMin={1}, \nEvenMax={2}", EvenSum, EvenMin, EvenMax);
            }



        }
    }
}
