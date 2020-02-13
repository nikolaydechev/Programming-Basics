using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_to_the_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            var heritage = double.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());

            var years = 18;

            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    heritage -= 12000;
                }
                if (i % 2 != 0)
                {
                    heritage -= 12000 + (50 * years);
                }
                years++;
            }

            if (heritage >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", heritage);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(heritage));
            }

        }
    }
}
