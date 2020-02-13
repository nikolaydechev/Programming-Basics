using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DailyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            var workingDays = int.Parse(Console.ReadLine());
            var dailyProfit = double.Parse(Console.ReadLine());
            var currency = double.Parse(Console.ReadLine());

            var monthlySalary = workingDays * dailyProfit;
            var annualProfit = monthlySalary * 12 + monthlySalary * 2.5;
            var nettoDailyProfit = ((annualProfit - annualProfit * 0.25) * currency)/365;

            Console.WriteLine("{0:f2}",nettoDailyProfit);

            

        }
    }
}
