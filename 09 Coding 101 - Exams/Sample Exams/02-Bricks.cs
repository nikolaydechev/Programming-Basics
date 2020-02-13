using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());

            var OneRun = w * m;
            double goal = Math.Ceiling(x / OneRun);
            
            Console.WriteLine("{0}", goal);
        }
    }
}
