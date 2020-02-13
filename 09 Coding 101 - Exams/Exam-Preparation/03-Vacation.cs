using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var adults = int.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine();

            var totalPeople = adults + students;
            var priceAdults = 0.0;
            var priceStudents = 0.0;
            var totalPriceHotel = nights * 82.99;

            if (totalPeople >= 50 && transport == "train")
            {
                priceAdults = adults * 24.99 * 0.50;
                priceStudents = students * 14.99 * 0.50;
            }
            else if (totalPeople < 50 && transport == "train")
            {
                priceAdults = adults * 24.99;
                priceStudents = students * 14.99;
            }
            else if (transport == "bus")
            {
                priceAdults = adults * 32.50;
                priceStudents = students * 28.50;
            }
            else if (transport == "boat")
            {
                priceAdults = adults * 42.99;
                priceStudents = students * 39.99;
            }
            else if (transport == "airplane")
            {
                priceAdults = adults * 70.00;
                priceStudents = students * 50.00;
            }
            var totalPriceTransport = (priceAdults + priceStudents) * 2;
            var commision = (totalPriceTransport + totalPriceHotel)* 0.10;
            var totalPrice = totalPriceTransport + totalPriceHotel + commision;

            Console.WriteLine("{0:f2}", totalPrice);
        }
    }
}
