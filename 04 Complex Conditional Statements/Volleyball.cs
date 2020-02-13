using System;

namespace Volleyball
{
    class Program
    {
        public static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var p = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());
            var weekendsSofia = 48 - h;
            var gamesSofia = (48 - h) * (3.0 / 4);
            var gamesTown = h;
            var gamesHoliday = p * (2.0 / 3);
            var gamesTotal = gamesSofia + gamesTown + gamesHoliday;

            if (year == "leap")
            {
                gamesTotal = gamesTotal + (gamesTotal * 0.15);
            }
            else if (year == "normal")
            {
                gamesTotal = gamesSofia + gamesTown + gamesHoliday;
            }
            Console.WriteLine("{0}", Math.Truncate(gamesTotal));
        }
    }
}
