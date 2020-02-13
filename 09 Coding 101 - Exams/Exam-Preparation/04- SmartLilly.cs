using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04__SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var priceWashingMachine = double.Parse(Console.ReadLine());
            var priceToy = int.Parse(Console.ReadLine());

            var moneyGift = 0.0;
            var OddAgeCount = 0;
            var EvenAgeCount = 0;
            var sumMoneyGift = 0.0;


            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneyGift = moneyGift + 10;
                    EvenAgeCount++;
                    sumMoneyGift = sumMoneyGift + moneyGift;
                }
                else if (i % 2 != 0)
                {
                    OddAgeCount++;
                }
            }
            
            
            var totalMoney = (sumMoneyGift-EvenAgeCount) + (OddAgeCount * priceToy);

            if (totalMoney >= priceWashingMachine)
            {
                Console.WriteLine("Yes! {0:f2}", totalMoney - priceWashingMachine);
            }
            if (totalMoney < priceWashingMachine)
            {
                Console.WriteLine("No! {0:f2}", priceWashingMachine - totalMoney);
            }
        }
    }
}
