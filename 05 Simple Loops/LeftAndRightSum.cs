using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            
            var leftSum = 0;
            var rightSum = 0;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                leftSum += number;
            }

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                rightSum += number;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}", leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(leftSum - rightSum));
            }

            //var n = int.Parse(Console.ReadLine());
            //var repeatCount = 2 * n;
            //var leftSum1 = 0;
            //var rightSum1 = 0;

            //for (int i = 0; i < repeatCount; i++)
            //{
            //    var number = int.Parse(Console.ReadLine());

            //    if (i < n)
            //    {
            //        leftSum1 = leftSum1 + number;
            //    }
            //    else
            //    {
            //        rightSum1 = rightSum1 + number;
            //    }

            //}
            //if (leftSum1 == rightSum1)
            //{
            //    Console.WriteLine("Yes, sum = {0}", leftSum1);
            //}
            //else
            //{
            //    Console.WriteLine("No, diff = {0}", Math.Abs(leftSum1 - rightSum1));
            //}
        }
    }
}
