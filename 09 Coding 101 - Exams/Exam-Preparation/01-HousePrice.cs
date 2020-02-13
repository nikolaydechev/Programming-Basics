using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HousePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallestRoom = double.Parse(Console.ReadLine());
            var kitchen = double.Parse(Console.ReadLine());
            var priceSqM = double.Parse(Console.ReadLine());

            var bathroom = 0.5 * smallestRoom;
            var secondroom = smallestRoom + smallestRoom * 0.10;
            var thirdroom = secondroom + secondroom * 0.10;

            var totalarea = smallestRoom + kitchen + bathroom + secondroom + thirdroom;

            var price = (totalarea + totalarea * 0.05) * priceSqM;
            Console.WriteLine("{0:f2}", price);
        }
    }
}
