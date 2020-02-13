using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var treated = 0;
            var untreated = 0;
            var doctors = 7;
            
            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (untreated > treated && i % 3 == 0)
                {
                    doctors++;
                }
                if (num <= 7)
                {
                    treated = treated + num;
                }
                if (num >= 8)
                {
                    treated = treated + doctors;
                    untreated = untreated + (num - doctors);
                }
            }
            Console.WriteLine("Treated patients: {0}.", treated);
            Console.WriteLine("Untreated patients: {0}.", untreated);
        }
    }
}
