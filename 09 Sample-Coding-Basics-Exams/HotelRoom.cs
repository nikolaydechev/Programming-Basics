using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            var apartment = 0.0;
            var studio = 0.0;

            if (month == "May" || month == "October")
            {
                if (nights > 7 && nights <= 14)
                {
                    studio = 50 - (0.05 * 50);
                    apartment = 65;
                }
                else if (nights > 14)
                {
                    studio = 50 - (0.3 * 50);
                    apartment = 65 - (65 * 0.1);
                }
                else if(nights >=1 && nights<=7)
                {
                    studio = 50;
                    apartment = 65;
                }
            }
            else if (month == "June" || month == "September")
            {
                if (nights > 14)
                {
                    studio = 75.20 - (0.2 * 75.20);
                    apartment = 68.70 - (68.70 * 0.1);
                }
                else if (nights >=1 && nights <=14)
                {
                    studio = 75.20;
                    apartment = 68.70;
                }
            }
            else if (month == "July" || month == "August")
            {
                if (nights > 14)
                {
                    studio = 76;
                    apartment = 77 - (77 * 0.1);
                }
                else if(nights >=1 && nights <=14)
                {
                    studio = 76;
                    apartment = 77;
                }
            }
            Console.WriteLine("Apartment: {0:f2} lv.", nights * apartment);
            Console.WriteLine("Studio: {0:f2} lv.", nights * studio);
        }
    }
}
