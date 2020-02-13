using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberMagnolia = int.Parse(Console.ReadLine());
            var numberZumbul = int.Parse(Console.ReadLine());
            var numberRose = int.Parse(Console.ReadLine());
            var numberCactus = int.Parse(Console.ReadLine());
            var priceGift = double.Parse(Console.ReadLine());

            var sumMagnolia = numberMagnolia * 3.25;
            var sumZumbul = numberZumbul * 4;
            var sumRose = numberRose * 3.50;
            var sumCactus = numberCactus * 8;

            var totalSum = sumMagnolia + sumZumbul + sumRose + sumCactus;
            var totalSumAfterTaxes = totalSum - totalSum * 0.05;
            

            if (totalSumAfterTaxes >= priceGift)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(totalSumAfterTaxes - priceGift));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(priceGift - totalSumAfterTaxes));
            }


        }
    }
}
