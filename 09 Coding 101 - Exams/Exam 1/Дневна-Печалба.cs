using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дневна_Печалба
{
    class Program
    {
        static void Main(string[] args)
        {
            var workingDayMonthly = int.Parse(Console.ReadLine());
            var earnedMoneyPerDay = double.Parse(Console.ReadLine());
            var DollarToLev = double.Parse(Console.ReadLine());

            var monthlySalary = workingDayMonthly * earnedMoneyPerDay;
            var yearRevenue = (monthlySalary * 12) + (monthlySalary * 2.5);
            var taxes = yearRevenue * 0.25;
            var yearRevenueNetto = (yearRevenue - taxes) * DollarToLev;
            var EarningsPerDay = yearRevenueNetto / 365;
            Console.WriteLine("{0:f2}",EarningsPerDay);
        }
    }
}
