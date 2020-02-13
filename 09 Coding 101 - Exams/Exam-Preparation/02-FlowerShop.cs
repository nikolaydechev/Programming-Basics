using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var magnolia = int.Parse(Console.ReadLine());
            var hyacinth = int.Parse(Console.ReadLine());
            var rose = int.Parse(Console.ReadLine());
            var cactus = int.Parse(Console.ReadLine());
            var giftPrice = double.Parse(Console.ReadLine());

            var magnoliaPrice = magnolia * 3.25;
            var hyacinthPrice = hyacinth * 4;
            var rosePrice = rose * 3.50;
            var cactusPrice = cactus * 8;

            var Sum = magnoliaPrice + hyacinthPrice + rosePrice + cactusPrice;
            var taxes = Sum * 0.05;
            var totalSum = Sum - taxes;

            if (totalSum >= giftPrice)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(totalSum - giftPrice));
            }
            else if (totalSum < giftPrice)
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(giftPrice - totalSum));
            }
        }
    }
}
