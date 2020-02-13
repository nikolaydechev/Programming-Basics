using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PointInFugure
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var inside = (x >= 4 && x <= 10 && y <= 3 && y >= -5) || (x >= 2 && x <= 12 && y <= 1 && y >= -3);

            var outside = x < 2 || x < 4 && y < -3 || x < 4 && y > 1 || x > 12 || x > 10 && y < -3 || x > 10 && y > 1;

            if (inside)
            {
                Console.WriteLine("in");
            }
            else if (outside)
            {
                Console.WriteLine("out");
            }
            else
            {
                Console.WriteLine("out");
            }
        }
    }
}
