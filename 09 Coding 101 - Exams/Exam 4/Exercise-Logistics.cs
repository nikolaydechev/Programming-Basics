using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var goodsPrice = 0.0;
            var goodsPriceSum = 0.0;
            var sumGoods = 0.0;
            var sumGoods1 = 0.0;
            var sumGoods2 = 0.0;
            var sumGoods3 = 0.0;

            for (int i = 1; i <= number; i++)
            {
                var tonnageGoods = int.Parse(Console.ReadLine());
                sumGoods = sumGoods + tonnageGoods;

                if (tonnageGoods <= 3)
                {
                    goodsPrice = 200 * tonnageGoods;
                    sumGoods1 = sumGoods1 + tonnageGoods;
                }
                else if (tonnageGoods >= 4 && tonnageGoods <= 11)
                {
                    goodsPrice = 175 * tonnageGoods;
                    sumGoods2 = sumGoods2 + tonnageGoods;
                }
                else if (tonnageGoods >= 12)
                {
                    goodsPrice = 120 * tonnageGoods;
                    sumGoods3 = sumGoods3 + tonnageGoods;
                }
                goodsPriceSum = goodsPriceSum + goodsPrice;
            }
            var averageTonnage = 0.0;
            var percentBus = 0.0;
            var percentTruck = 0.0;
            var percentTrain = 0.0;

            averageTonnage = goodsPriceSum / sumGoods;

            percentBus = sumGoods1 / sumGoods * 100;
            percentTruck = sumGoods2 / sumGoods * 100;
            percentTrain = sumGoods3 / sumGoods * 100;

            Console.WriteLine("{0:f2} \n{1:f2}% \n{2:f2}% \n{3:f2}%", averageTonnage, percentBus, percentTruck, percentTrain);

        }
    }
}
