using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sumGroups = 0.0;
            var sumGroups1 = 0.0;
            var sumGroups2 = 0.0;
            var sumGroups3 = 0.0;
            var sumGroups4 = 0.0;
            var sumGroups5 = 0.0;

            for (int i = 1; i <= n; i++)
            {
                var groups = int.Parse(Console.ReadLine());
                sumGroups += groups;
                if (groups<= 5)
                {
                    sumGroups1 = sumGroups1 + groups;
                }
                else if (groups >=6 && groups <=12)
                {
                    sumGroups2 = sumGroups2 + groups;
                }
                else if (groups >= 13 && groups <=25)
                {
                    sumGroups3 = sumGroups3 + groups;
                }
                else if (groups >=26 && groups <=40)
                {
                    sumGroups4 = sumGroups4 + groups;
                }
                else if (groups >=41)
                {
                    sumGroups5 = sumGroups5 + groups;
                }
            }
            var percentCar = sumGroups1 / sumGroups * 100;
            var percentMicroBus = sumGroups2 / sumGroups * 100;
            var percentSmallBus = sumGroups3 / sumGroups * 100;
            var percentBigBus = sumGroups4 / sumGroups * 100;
            var percentTrain = sumGroups5 / sumGroups * 100;

            Console.WriteLine("{0:f2}% \n{1:f2}% \n{2:f2}% \n{3:f2}% \n{4:f2}%", percentCar, percentMicroBus, percentSmallBus, percentBigBus, percentTrain);

        }
    }
}
