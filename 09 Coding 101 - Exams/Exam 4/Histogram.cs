using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;
            double p4 = 0.0;
            double p5 = 0.0;
           

            for (int i = 0; i < number; i++)
            {
                var n = int.Parse(Console.ReadLine());
               
                if (n >= 1 && n < 200)
                {
                    ++p1;
                }
                else if (n>=200 && n<400)
                {
                    ++p2;
                }
                else if (n >= 400 && n < 600)
                {
                    ++p3;
                }
                else if (n >= 600 && n < 800)
                {
                    ++p4;
                }
                else if (n>=800)
                {
                    ++p5;
                }
            }
            Console.WriteLine("{0:f2}%", p1/number*100);
            Console.WriteLine("{0:f2}%", p2 / number * 100);
            Console.WriteLine("{0:f2}%", p3 / number * 100);
            Console.WriteLine("{0:f2}%", p4 / number * 100);
            Console.WriteLine("{0:f2}%", p5 / number * 100);

        }
    }
}
