using System;

namespace _03_Flowers
{
    class Program
    {
        public static void Main(string[] args)
        {
            var numberchrysanthemum = int.Parse(Console.ReadLine());
            var numberRose = int.Parse(Console.ReadLine());
            var numberTulip = int.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            var HolidayOrNot = Console.ReadLine();

            var priceChrysanthemum = 0.0;
            var priceRose = 0.0;
            var priceTulip = 0.0;
            var numberFlowers = numberchrysanthemum + numberRose + numberTulip;
           
            
            if (season == "spring" || season == "summer")
            {
                priceChrysanthemum = 2 * numberchrysanthemum;
                priceRose = 4.10 * numberRose;
                priceTulip = 2.50 * numberTulip;
            }
            else if (season == "winter" || season == "autumn")
            {
                
                priceChrysanthemum = 3.75 * numberchrysanthemum;
                priceRose = 4.50 * numberRose;
                priceTulip = 4.15 * numberTulip;
            }

            var totalPrice = priceChrysanthemum + priceRose + priceTulip; ;

            if (HolidayOrNot == "Y")
            {
                totalPrice = totalPrice + totalPrice * 0.15;
            }
            if (season == "winter" && numberRose >= 10)
            {
                totalPrice = totalPrice - totalPrice * 0.10;
            }
            else if (season == "spring" && numberTulip > 7)
            {
                totalPrice = totalPrice - totalPrice * 0.05;
            }
            if (numberFlowers > 20)
            {
                totalPrice = totalPrice - totalPrice * 0.20;
            }

            Console.WriteLine("{0:f2}", totalPrice + 2);
        }
    }
}
