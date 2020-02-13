using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budjet = double.Parse(Console.ReadLine());
            var category = Console.ReadLine().ToLower();
            var people = int.Parse(Console.ReadLine());

            var transportMoney = 0.0;

            if (people >=1 && people <=4)
            {
                transportMoney = budjet - budjet * 0.75;
            }
            else if (people >=5 && people <=9)
            {
                transportMoney = budjet - budjet * 0.60;
            }
            else if (people >=10 && people <=24)
            {
                transportMoney = budjet - budjet * 0.50;
            }
            else if (people >=25 && people<=49)
            {
                transportMoney = budjet - budjet * 0.40;
            }
            else if (people > 49)
            {
                transportMoney = budjet - budjet * 0.25;
            }

            var priceVIP = people * 499.99;
            var priceNormal = people * 249.99;

            if (category == "vip")
            {
                if (transportMoney >= priceVIP)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", transportMoney - priceVIP);
                }
                else if (transportMoney < priceVIP)
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(priceVIP - transportMoney));
                }
            }
            else if (category == "normal")
            {
                if (transportMoney >= priceNormal)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", transportMoney - priceNormal);
                }
                else if (transportMoney < priceNormal)
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(priceNormal - transportMoney));
                }
            }



        }
    }
}
