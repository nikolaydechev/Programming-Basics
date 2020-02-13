using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallestRoomArea = double.Parse(Console.ReadLine());
            var kitchenArea = double.Parse(Console.ReadLine());
            var priceSquareMeter = double.Parse(Console.ReadLine());

            var bathRoom = 0.5 * smallestRoomArea;
            var secondRoom = smallestRoomArea + smallestRoomArea * 0.10;
            var thirdRoom = secondRoom + secondRoom * 0.10;

            var totalArea = smallestRoomArea + kitchenArea + secondRoom + thirdRoom + bathRoom;
            var HousePrice = (totalArea + 0.05* totalArea) * priceSquareMeter;
            Console.WriteLine("{0:f2}", HousePrice);

        }
    }
}
