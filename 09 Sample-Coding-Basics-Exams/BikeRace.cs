using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberJuniors = int.Parse(Console.ReadLine());
            var numberSeniors = int.Parse(Console.ReadLine());
            var road = Console.ReadLine();

            var totalPeople = numberJuniors + numberSeniors;
            var priceJuniors = 0.0;
            var priceSeniors = 0.0;

            if (road == "trail")
            {
                priceJuniors = numberJuniors * 5.50;
                priceSeniors = numberSeniors * 7;
            }
            else if (road == "cross-country" && totalPeople < 50)
            {
                priceJuniors = numberJuniors * 8;
                priceSeniors = numberSeniors * 9.50;
            }
            else if (road == "cross-country" && totalPeople >= 50)
            {
                priceJuniors = (numberJuniors * 8) - (numberJuniors * 8* 0.25);
                priceSeniors = (numberSeniors * 9.50) - (numberSeniors * 9.50 * 0.25);
            }
            else if (road == "downhill")
            {
                priceJuniors = numberJuniors * 12.25;
                priceSeniors = numberSeniors * 13.75;
            }
            else if (road == "road")
            {
                priceJuniors = numberJuniors * 20;
                priceSeniors = numberSeniors * 21.50;
            }
            var totalSum = priceJuniors + priceSeniors;
            Console.WriteLine("{0:f2}", totalSum - totalSum*0.05);

        }
    }
}
