using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FishLand
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceSkumria = double.Parse(Console.ReadLine());
            var priceSprat = double.Parse(Console.ReadLine());
            var kgPalamud = double.Parse(Console.ReadLine());
            var kgSaphrid = double.Parse(Console.ReadLine());
            var kgClams = double.Parse(Console.ReadLine());

            var pricePalamud = (priceSkumria + (priceSkumria * 0.60)) * kgPalamud;
            var priceSaphrid = (priceSprat + (priceSprat * 0.80)) * kgSaphrid;
            var priceClams = kgClams * 7.50;
            var totalPrice = pricePalamud + priceSaphrid + priceClams;

            Console.WriteLine("{0:f2}", totalPrice);
        }
    }
}
