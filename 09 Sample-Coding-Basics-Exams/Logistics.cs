using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sumGoods = 0.0;
            var sumGoods1 = 0.0;
            var sumGoods2 = 0.0;
            var sumGoods3 = 0.0;
            var goodsPrice = 0.0;
            var goodsPriceSum = 0.0;

            for (int i = 1; i <= n; i++)
            {
                var goods = int.Parse(Console.ReadLine());
                sumGoods = sumGoods + goods;
                if (goods <= 3)
                {
                    goodsPrice = goods * 200;
                    sumGoods1 = sumGoods1 + goods;
                }
                else if (goods >= 4 && goods < 12)
                {
                    goodsPrice = goods * 175;
                    sumGoods2 = sumGoods2 + goods;
                }
                else if (goods >= 12)
                {
                    goodsPrice = goods * 120;
                    sumGoods3 = sumGoods3 + goods;
                }
                goodsPriceSum = goodsPriceSum + goodsPrice;
            }
            var averageTonnage = goodsPriceSum / sumGoods;
            var percentBus = sumGoods1 / sumGoods * 100;
            var percentTruck = sumGoods2 / sumGoods * 100;
            var percentTrain = sumGoods3 / sumGoods * 100;

            Console.WriteLine("{0:f2}", averageTonnage);
            Console.WriteLine("{0:f2}% \n{1:f2}% \n{2:f2}%", percentBus, percentTruck, percentTrain);
        }
    }
}
