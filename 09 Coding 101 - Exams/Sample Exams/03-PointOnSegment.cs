using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PointOnSegment
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());
            
            var diff1 = Math.Abs(first - point);
            var diff2 = Math.Abs(second - point);

            if (point >= first && point <= second || point >= second && point <= first)
            {
                Console.WriteLine("in");
                if (diff1 >= diff2)
                {
                    Console.WriteLine("{0}", diff2);
                }
                else if (diff1 < diff2)
                {
                    Console.WriteLine("{0}", diff1);
                }
            }
            else if (point <= first && point <= second || point >= second && point >= first)
            {
                Console.WriteLine("out");
                if (diff1 >= diff2)
                {
                    Console.WriteLine("{0}", diff2);
                }
                else if (diff1 < diff2)
                {
                    Console.WriteLine("{0}", diff1);
                }
            }
        }
    }
}
