using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SleepingCatTom
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var MinutesAnnually = 30000;
            var MinutesForPlay = (365 - n) * 63 + (n * 127);
            var diffMinutes = Math.Abs(MinutesAnnually - MinutesForPlay);

            var hours = diffMinutes / 60;
            var minutes = diffMinutes % 60;

            if (MinutesAnnually > MinutesForPlay)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }
            else if (MinutesAnnually < MinutesForPlay)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
        }
    }
}
