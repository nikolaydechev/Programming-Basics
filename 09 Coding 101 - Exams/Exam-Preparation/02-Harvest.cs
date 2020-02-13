using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var vineyardArea = int.Parse(Console.ReadLine());
            var grapesSqm = double.Parse(Console.ReadLine());
            var littersWineNeed = double.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var totalGrapes = vineyardArea * grapesSqm;
            var totalWine = (totalGrapes * 0.40) / 2.5;
            var leftWine = 0.0;
            var littersPerPerson = 0.0;
            var lackingWine = 0.0;

            if (totalWine >= littersWineNeed)
            {
                leftWine = totalWine - littersWineNeed;
                littersPerPerson = leftWine / workers;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(totalWine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(leftWine), Math.Ceiling(littersPerPerson));
            }
            else if (totalWine < littersWineNeed)
            {
                lackingWine = littersWineNeed - totalWine;
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(lackingWine));
            }
        }
    }
}
