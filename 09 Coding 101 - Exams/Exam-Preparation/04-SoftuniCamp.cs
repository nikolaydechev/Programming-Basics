using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SoftuniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var CarTravellers = 0.0;
            var MicrobusTravellers = 0.0;
            var SmallbusTravellers = 0.0;
            var AutobusTravellers = 0.0;
            var TrainTravellers = 0.0;

            var sumPeople = 0.0;

            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sumPeople = sumPeople + num;
                if (num <= 5)
                {
                    CarTravellers = CarTravellers + num;
                }
                else if (num > 5 && num <= 12)
                {
                    MicrobusTravellers = MicrobusTravellers + num;
                }
                else if (num > 12 && num <= 25)
                {
                    SmallbusTravellers = SmallbusTravellers + num;
                }
                else if (num > 25 && num <= 40)
                {
                    AutobusTravellers = AutobusTravellers + num;
                }
                else if (num >= 41)
                {
                    TrainTravellers = TrainTravellers + num;
                }
            }

            var percentCar = CarTravellers / sumPeople * 100;
            var percentMicrobus = MicrobusTravellers / sumPeople * 100;
            var percentSmallbus = SmallbusTravellers / sumPeople * 100;
            var percentAutobus = AutobusTravellers / sumPeople * 100;
            var percentTrain = TrainTravellers / sumPeople * 100;
            
            Console.WriteLine("{0:f2}% \n{1:f2}% \n{2:f2}% \n{3:f2}% \n{4:f2}%",
                percentCar, percentMicrobus, percentSmallbus, percentAutobus, percentTrain);

        }
    }
}
