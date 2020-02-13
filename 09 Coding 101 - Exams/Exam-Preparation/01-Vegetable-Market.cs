using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            var kgPriceVegetables = double.Parse(Console.ReadLine());
            var kgPriceFruits = double.Parse(Console.ReadLine());
            var kgVegetables = double.Parse(Console.ReadLine());
            var kgFruits = double.Parse(Console.ReadLine());

            var Vegetables = kgPriceVegetables * kgVegetables;
            var Fruits = kgPriceFruits * kgFruits;
            var totalIncome = (Vegetables + Fruits) / 1.94;

            Console.WriteLine(totalIncome);
        }
    }
}
