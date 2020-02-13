using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            var budjet = double.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();

            string destination = "";
            string place = "";
            var price = 0.0;

            if (budjet <= 100 && season == "summer")
            {
                price = budjet * 0.30;
                destination = "Bulgaria";
                place = "Camp";
            }
            else if (budjet <= 100 && season == "winter")
            {
                price = budjet * 0.70;
                destination = "Bulgaria";
                place = "Hotel";
            }
            else if (budjet > 100 && budjet <= 1000)
            {
                if (season == "summer")
                {
                    price = budjet * 0.40;
                    destination = "Balkans";
                    place = "Camp";
                }
                else if (season == "winter")
                {
                    price = budjet * 0.80;
                    destination = "Balkans";
                    place = "Hotel";
                }
            }
            else if (budjet > 1000)
            {
                price = budjet * 0.90;
                destination = "Europe";
                place = "Hotel";
            }
            Console.WriteLine("Somewhere in {0}", destination);
            Console.WriteLine("{0} - {1:f2}", place, price);
        }
    }
}
