using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_IncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var tempNum = 0;
            var counter = 0;
            var maxCount = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                
                if (num > tempNum)
                {
                    counter = counter + 1;
                }
                else
                {
                    counter = 1;
                }
                
                if (counter > maxCount)
                {
                    maxCount =counter ;
                }
                
                tempNum = num;
            }
            Console.WriteLine(maxCount);
        }
    }
}
