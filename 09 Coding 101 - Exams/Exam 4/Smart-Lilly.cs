using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Lilly
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var WashingMachine = double.Parse(Console.ReadLine());
            var toyPrice = int.Parse(Console.ReadLine());

            var savedMoney = 0.0;
            var countEvenDay = 0.0;
            var toyNumber = 0.0;
            var totalMoney = 0.0;
            var extraMoney = 10;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney = savedMoney + extraMoney;
                    countEvenDay++;
                    extraMoney = extraMoney + 10;
                    
                }
                if (i % 2 != 0)
                {
                    toyNumber++;
                }
            }
            totalMoney = savedMoney + (toyNumber*toyPrice) - countEvenDay;
            if (totalMoney>=WashingMachine)
            {
                Console.WriteLine("Yes! {0:f2}", totalMoney -WashingMachine);
            }
            else if (totalMoney < WashingMachine)
            {
                Console.WriteLine("No! {0:f2}", WashingMachine - totalMoney);
            }

        }
    }
}
