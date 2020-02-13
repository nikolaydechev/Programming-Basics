using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Поспаливата_Котка_Том
{
    class Program
    {
        static void Main(string[] args)
        {
            var holiDays = int.Parse(Console.ReadLine());
            var holidayGameMinutes = holiDays * 127;
            var workingDaysGameMinutes = (365 - holiDays) * 63;
            var totalGameMinutes = holidayGameMinutes + workingDaysGameMinutes;

            if (totalGameMinutes < 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play",
                    Math.Abs((30000 - totalGameMinutes) / 60),
                    Math.Abs((30000 - totalGameMinutes) % 60));
            }
            else if (totalGameMinutes > 30000)
            {

                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play",
                    Math.Abs((totalGameMinutes - 30000) / 60),
                    Math.Abs((totalGameMinutes - 30000) % 60));
            }
        }
    }
}
