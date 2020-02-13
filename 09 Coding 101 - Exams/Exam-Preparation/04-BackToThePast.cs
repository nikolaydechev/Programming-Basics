using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            var moneyHeritage = double.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());

            var yearsCounter = 18;
            var leftMoney = 0.0;

            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    moneyHeritage = moneyHeritage - 12000;
                }
                else if (i % 2 != 0)
                {
                    moneyHeritage = moneyHeritage - (12000 + yearsCounter*50);
                }
                yearsCounter++;
                leftMoney = moneyHeritage;
            }
            if (leftMoney >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", leftMoney);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(leftMoney));
            }
        }
    }
}
