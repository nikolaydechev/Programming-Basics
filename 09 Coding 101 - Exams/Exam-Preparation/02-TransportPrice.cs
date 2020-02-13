using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var DayOrNight = Console.ReadLine().ToLower();

            var price = 0.0;
            

            if (DayOrNight == "day" && n < 20)
            {
                price = 0.70 + n * 0.79;
            }
            else if (DayOrNight == "night" && n < 20)
            {
                price = 0.70 + n * 0.90;
            }
            else if (n >= 20 && n < 100)
            {
                price = n * 0.09;
            }
            else if (n>=100)
            {
                price = n * 0.06;
            }
            Console.WriteLine(price);
        }
    }
}
