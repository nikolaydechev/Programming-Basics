using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var OddSum = 0;
            var EvenSum = 0;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (i%2 ==0)
                {
                    EvenSum += number;
                }
                else
                {
                    OddSum += number;
                }
            }
            if (EvenSum == OddSum)
            {
                Console.WriteLine("Yes Sum = {0}", EvenSum);
            }
            else
            {
                Console.WriteLine("No Diff = {0}", Math.Abs(EvenSum - OddSum));
            }
        }
    }
}
