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
            var n = int.Parse(Console.ReadLine());

            var p1count = 0.0;
            var p2count = 0.0;
            var p3count = 0.0;
            var p4count = 0.0;
            var p5count = 0.0;


            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1count++;
                }
                else if (num >= 200 && num < 400)
                {
                    p2count++;
                }
                else if (num >= 400 && num < 600)
                {
                    p3count++;
                }
                else if (num >= 600 && num < 800)
                {
                    p4count++;
                }
                else if (num >= 800)
                {
                    p5count++;
                }
            }

            var p1 = p1count / n * 100;
            var p2 = p2count / n * 100;
            var p3 = p3count / n * 100;
            var p4 = p4count / n * 100;
            var p5 = p5count / n * 100;


            Console.WriteLine("{0:f2}%\n{1:f2}%\n{2:f2}%\n{3:f2}%\n{4:f2}%", p1, p2, p3, p4, p5);
        }
    }
}
