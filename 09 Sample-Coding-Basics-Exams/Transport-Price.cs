using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceVegPerKilo = double.Parse(Console.ReadLine()) / 1.94;
            var priceFruitsPerKilo = double.Parse(Console.ReadLine()) / 1.94;
            var VegetablesQuantity = int.Parse(Console.ReadLine());
            var FruitsQuantity = int.Parse(Console.ReadLine());

            var VegPrice = priceVegPerKilo * VegetablesQuantity;
            var FruitsPrice = priceFruitsPerKilo * FruitsQuantity;
            var totalPrice = VegPrice + FruitsPrice;
            Console.WriteLine("{0}" , totalPrice);

        }
    }
}
