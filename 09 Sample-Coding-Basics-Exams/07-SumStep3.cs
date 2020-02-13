using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_SumStep3
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sum1 = 0;
            var sum2 = 0;
            var sum3 = 0;

            var counter1 = 1;
            var counter2 = 2;
            var counter3 = 3;

            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
               
                if (i == counter1)
                {
                    sum1 = sum1 + num;
                    counter1 += 3;
                }
                if (i == counter2)
                {
                    sum2 = sum2 + num;
                    counter2 += 3;
                }
                if (i == counter3)
                {
                    sum3 = sum3 + num;
                    counter3 += 3;
                }
            }
            Console.WriteLine("sum1 = {0}", sum1);
            Console.WriteLine("sum2 = {0}", sum2);
            Console.WriteLine("sum3 = {0}", sum3);
        }
    }
}
