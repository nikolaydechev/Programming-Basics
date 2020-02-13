using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДелениеБезОстатък
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;

            for (int i = 0; i < number; i++)
            {
                var n = int.Parse(Console.ReadLine());
                
                if (n%2 ==0)
                {
                    p1++;
                }
                if (n%3==0)
                {
                    p2++;
                }
                if (n%4==0)
                {
                    p3++;
                }
            }
            Console.WriteLine("{0:f2}%", p1/number *100);
            Console.WriteLine("{0:f2}%", p2/number *100);
            Console.WriteLine("{0:f2}%", p3/number *100);
        }
    }
}
