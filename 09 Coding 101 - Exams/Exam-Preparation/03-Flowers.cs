using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberChrysantemum = int.Parse(Console.ReadLine());
            var numberRoses = int.Parse(Console.ReadLine());
            var numberTulips = int.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            var HolidayOrNot = Console.ReadLine();

            var numberFlowers = numberChrysantemum + numberRoses + numberTulips;
            var priceChrysantemum = 0.0;
            var priceRoses = 0.0;
            var priceTulips = 0.0;
            var totalPrice = 0.0;

            if (season == "spring" || season == "summer")
            {
                priceChrysantemum = numberChrysantemum * 2;
                priceRoses = numberRoses * 4.10;
                priceTulips = numberTulips * 2.5;
            }
            else if (season == "winter" || season == "autumn")
            {
                priceChrysantemum = numberChrysantemum * 3.75;
                priceRoses = numberRoses * 4.5;
                priceTulips = numberTulips * 4.15;
            }

            totalPrice = priceChrysantemum + priceRoses + priceTulips;
            if (HolidayOrNot == "Y")
            {
                totalPrice = totalPrice + totalPrice * 0.15;
            }
            if (numberTulips > 7 && season == "spring")
            {
                totalPrice = totalPrice - totalPrice * 0.05;
            }
            if (numberRoses >=10 && season == "winter")
            {
                totalPrice = totalPrice - totalPrice * 0.10;
            }
            if (numberFlowers > 20)
            {
                totalPrice = totalPrice - totalPrice * 0.20;
            }

            Console.WriteLine("{0:f2}", totalPrice + 2);
        }
    }
}
