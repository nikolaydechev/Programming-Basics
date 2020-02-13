using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            var studioPrice = 0.0;
            var appartPrice = 0.0;

            if (month == "May" || month == "October")
            {
                if (nights > 7 && nights <= 14)
                {
                    studioPrice = 50 - (50 * 0.05);
                    appartPrice = 65;
                }
                else if (nights > 14)
                {
                    studioPrice = 50 - (50 * 0.30);
                    appartPrice = 65 - (65 * 0.10);
                }
                else 
                {
                    studioPrice = 50;
                    appartPrice = 65;
                }
            }
            else if (month == "June" || month == "September")
            {
                if (nights > 14)
                {
                    studioPrice = 75.20 - (75.20 * 0.20);
                    appartPrice = 68.70 - (68.70 * 0.10);
                }
                else 
                {
                    appartPrice = 68.70;
                    studioPrice = 75.20;
                }
            }
            else if (month == "July" || month == "August")
            {
                if (nights > 14)
                {
                    studioPrice = 76;
                    appartPrice = 77 - (77 * 0.10);
                }
                else 
                {
                    studioPrice = 76;
                    appartPrice = 77;
                }
            }
            Console.WriteLine("Apartment: {0:f2} lv.", appartPrice * nights);
            Console.WriteLine("Studio: {0:f2} lv.", studioPrice * nights);
        }
    }
}
