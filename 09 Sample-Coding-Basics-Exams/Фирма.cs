using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фирма
{
    class Program
    {
        static void Main(string[] args)
        {
            var projectHours = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var workersOverTimeNumber = int.Parse(Console.ReadLine());

            var Hours = ((days - (days * 0.1)) * 8);
            var overTimeHours = workersOverTimeNumber * (2 * days);
            var totalHours = Math.Floor(Hours + overTimeHours);


            if (totalHours >= projectHours)
            {
                Console.WriteLine("Yes!{0} hours left.", totalHours - projectHours);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", projectHours - totalHours);
            }

        }
    }
}
