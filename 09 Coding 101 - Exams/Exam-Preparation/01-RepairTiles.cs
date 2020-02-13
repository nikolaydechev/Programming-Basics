using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_RepairTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var W = double.Parse(Console.ReadLine());
            var L = double.Parse(Console.ReadLine());
            var M = double.Parse(Console.ReadLine());
            var O = double.Parse(Console.ReadLine());


            var totalArea = N * N - (M * O);
            var tileArea = W * L;
            var tiles = totalArea / tileArea;
            var time = tiles * 0.2;

            Console.WriteLine("{0} \n{1} ", tiles, time);
        }
    }
}
