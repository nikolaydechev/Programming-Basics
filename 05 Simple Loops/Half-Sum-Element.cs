using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var maxNumber = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > maxNumber)
                {
                    maxNumber = num;
                }
            }
            var diff = maxNumber - (sum - maxNumber);
            if (diff == 0)
            {
                Console.WriteLine("Yes Sum = {0}", maxNumber);
            }
            else
            {
                Console.WriteLine("No diff = {0}", Math.Abs(diff));
            }
            
            
        }
    }
}