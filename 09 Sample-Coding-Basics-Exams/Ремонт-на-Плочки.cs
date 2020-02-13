using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ремонт_на_Плочки
{
    class Program
    {
        static void Main(string[] args)
        {
            var groundLength = double.Parse(Console.ReadLine());
            var tileWidth = double.Parse(Console.ReadLine());
            var tileLength = double.Parse(Console.ReadLine());
            var benchWidth = double.Parse(Console.ReadLine());
            var benchLength = double.Parse(Console.ReadLine());

            var totalArea = groundLength * groundLength;
            var benchArea = benchLength * benchWidth;
            var coverArea = totalArea - benchArea;
            var tileArea = tileWidth * tileLength;
            var tileNumber = coverArea / tileArea;
            var time = tileNumber * 0.2;
            Console.WriteLine("{0}", tileNumber);
            Console.WriteLine("{0}", time);

        }
    }
}
