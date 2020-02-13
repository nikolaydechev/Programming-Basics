using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberAdults = int.Parse(Console.ReadLine());
            var numberStudents = int.Parse(Console.ReadLine());
            var numberNights = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine();

            var totalPeople = numberStudents + numberAdults;
            var priceHotel = numberNights * 82.99;
            var priceAdults = 0.0;
            var priceStudents = 0.0;

            if (transport == "train" && totalPeople < 50)
            {
                priceAdults = numberAdults * 24.99;
                priceStudents = numberStudents * 14.99;
            }
            else if (transport == "train" && totalPeople >= 50)
            {
                priceAdults = (numberAdults * 24.99) * 0.5;
                priceStudents = (numberStudents * 14.99) * 0.5;
            }
            else if (transport == "bus")
            {
                priceAdults = numberAdults * 32.50;
                priceStudents = numberStudents * 28.50;
            }
            else if (transport == "boat")
            {
                priceAdults = numberAdults * 42.99;
                priceStudents = numberStudents * 39.99;
            }
            else if (transport == "airplane")
            {
                priceAdults = numberAdults * 70.00;
                priceStudents = numberStudents * 50.00;
            }
            var totalPrice = (priceAdults + priceStudents) * 2 + priceHotel;
            Console.WriteLine("{0:f2}", totalPrice + totalPrice * 0.10);
        }
    }
}
