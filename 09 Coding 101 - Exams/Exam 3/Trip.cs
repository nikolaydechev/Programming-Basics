using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            var budjet = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            string holidayType = "";
            string destination = "";
            var spentMoney = 0.0;

            if (budjet <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    spentMoney = 0.3 * budjet;
                    holidayType = "Camp";
                }
                else if (season == "winter")
                {
                    spentMoney = 0.7 * budjet;
                    holidayType = "Hotel";
                }
            }
            else if (budjet <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    spentMoney = 0.4 * budjet;
                    holidayType = "Camp";
                }
                else if (season == "winter")
                {
                    spentMoney = 0.8 * budjet;
                    holidayType = "Hotel";
                }
            }
            else if (budjet > 1000)
            {
                destination = "Europe";
                spentMoney = 0.9 * budjet;
                holidayType = "Hotel";
            }
            Console.WriteLine("Somewhere in {0}", destination);
            Console.WriteLine("{0} - {1:0.00}", holidayType, spentMoney);
        }
    }
}


