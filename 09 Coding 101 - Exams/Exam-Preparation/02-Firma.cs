using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Firma
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var extratimeWorkers = int.Parse(Console.ReadLine());

            var workingHours = (days - 0.10 * days) * 8;
            var extratimeHours = extratimeWorkers * (2 * days);
            var totalHours = Math.Floor(workingHours + extratimeHours);
            
            if (totalHours >= hours)
            {
                Console.WriteLine("Yes!{0} hours left.", totalHours - hours);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.",hours - totalHours);
            }
        }
    }
}
