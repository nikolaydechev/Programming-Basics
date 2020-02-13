using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sumNum = 0.0;
            var microbus = 0;
            var truck = 0;
            var train = 0;

            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sumNum = sumNum + num;
                if (num <= 3)
                {
                    microbus = microbus + num;
                }
                else if (num > 3 && num < 12)
                {
                    truck = truck + num;
                }
                else if (num >= 12)
                {
                    train = train + num;
                }
            }
            Console.WriteLine("{0:f2}", (microbus * 200 + truck * 175 + train * 120) / sumNum);
            Console.WriteLine("{0:f2}%", microbus / sumNum * 100);
            Console.WriteLine("{0:f2}%", truck / sumNum * 100);
            Console.WriteLine("{0:f2}%", train / sumNum * 100);
        }
    }
}
