using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Цена_за_Транспорт
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var DayOrNight = Console.ReadLine().ToLower();

            var taxiPriceDay = 0.70 + n * 0.79;
            var taxiPriceNight = 0.70 + n * 0.90;
            var busPrice = 0.09 * n;
            var trainPrice = 0.06 * n;
            if (n < 20)
            {
                if (DayOrNight == "day")
                {
                    Console.WriteLine(taxiPriceDay);
                }
                else if (DayOrNight == "night")
                {
                    Console.WriteLine(taxiPriceNight);
                }

            }
            else if (n < 100)
            {
                Console.WriteLine(busPrice);
            }
            else if (n >= 100)
            {
                Console.WriteLine(trainPrice);
            }
        }
    }
}
