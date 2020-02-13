using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            var juniors = int.Parse(Console.ReadLine());
            var seniors = int.Parse(Console.ReadLine());
            var trace = Console.ReadLine().ToString();

            var totalPeople = juniors + seniors;
            var juniorsTax = 0.0;
            var seniorsTax = 0.0;

            if (trace == "trail")
            {
                juniorsTax = juniors * 5.50;
                seniorsTax = seniors * 7;
            }
            else if (trace == "cross-country" && totalPeople >= 50)
            {
                juniorsTax = juniors * 8 - (juniors * 8 * 0.25);
                seniorsTax = seniors * 9.50 - (seniors * 9.50 * 0.25);
            }
            else if (trace == "cross-country" && totalPeople < 50)
            {
                juniorsTax = juniors * 8;
                seniorsTax = seniors * 9.50;
            }
            else if (trace == "downhill")
            {
                juniorsTax = juniors * 12.25;
                seniorsTax = seniors * 13.75;
            }
            else if (trace == "road")
            {
                juniorsTax = juniors * 20;
                seniorsTax = seniors * 21.50;
            }

            var totalPrice = (juniorsTax + seniorsTax) - ((juniorsTax+seniorsTax)*0.05);
            Console.WriteLine("{0:f2}", totalPrice);
        }
    }
}
