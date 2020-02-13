using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceScumria = double.Parse(Console.ReadLine());
            var priceTsatsa = double.Parse(Console.ReadLine());
            var kgPalamud = double.Parse(Console.ReadLine());
            var kgSafrid = double.Parse(Console.ReadLine());
            var kgClams = double.Parse(Console.ReadLine());

            var pricePalamud = priceScumria + priceScumria * 0.60;
            var sumPalamud = pricePalamud * kgPalamud;

            var priceSafrid = priceTsatsa + priceTsatsa * 0.80;
            var sumSafrid = priceSafrid * kgSafrid;

            var sumClams = 7.50 * kgClams;

            Console.WriteLine("{0:f2}", sumPalamud + sumSafrid + sumClams);

        }
    }
}
