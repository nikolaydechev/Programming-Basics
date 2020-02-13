using System;

namespace BonusScore
{
    class BonusScore
    {
        public static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());

            var bonusPoints = 0.0;

            if (num <= 100)
            {
                bonusPoints = 5;
            }
            else if (num > 1000)
            {
                bonusPoints = 0.1 * num;
            }
            else if (num > 100)
            {
                bonusPoints = 0.2 * num;
            }
            if (num % 2 == 0)
            {
                bonusPoints = bonusPoints + 1;
            }
            else if (num % 10 == 5)
            {
                bonusPoints = bonusPoints + 2;
            }

            Console.WriteLine(bonusPoints);
            Console.WriteLine(bonusPoints);
        }
    }
}
