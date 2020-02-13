using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialSpeed = int.Parse(Console.ReadLine());
            var firstTime = int.Parse(Console.ReadLine()) / 60.00;
            var secondTime = int.Parse(Console.ReadLine()) / 60.00;
            var thirdTime = int.Parse(Console.ReadLine()) / 60.00;

            var firstIncreasement = initialSpeed * firstTime;
            var Decreasement = (initialSpeed + initialSpeed * 0.10) * secondTime;
            var AfterDecreasement = ((initialSpeed + initialSpeed * 0.10)- (initialSpeed + initialSpeed * 0.10)*0.05) * thirdTime;
            
            Console.WriteLine("{0:f2}", firstIncreasement + Decreasement + AfterDecreasement);
        }
    }
}
