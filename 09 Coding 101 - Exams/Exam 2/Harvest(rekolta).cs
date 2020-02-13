using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_rekolta_
{
    class Program
    {
        static void Main(string[] args)
        {
            var X = int.Parse(Console.ReadLine());
            var Y = double.Parse(Console.ReadLine());
            var Z = int.Parse(Console.ReadLine());
            var workersNumber = int.Parse(Console.ReadLine());

            var totalGrapes = X * Y;
            var totalWine = (0.4 * totalGrapes) / 2.5;
            if (totalWine >= Z)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.",
                    Math.Floor(totalWine));
                Console.WriteLine("{0} liters left -> {1} liters per person.",
                    Math.Ceiling(totalWine - Z),
                    Math.Ceiling((totalWine - Z) / workersNumber));
            }
            else if (totalWine < Z)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(Z - totalWine));
            }
        }
    }
}
