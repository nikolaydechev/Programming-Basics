using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ChangeTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var collectedMoney = double.Parse(Console.ReadLine());
            var widthFloor = double.Parse(Console.ReadLine());
            var lengthFloor = double.Parse(Console.ReadLine());
            var sideTriangle = double.Parse(Console.ReadLine());
            var heightTriangle = double.Parse(Console.ReadLine());
            var priceTile = double.Parse(Console.ReadLine());
            var sumMaster = double.Parse(Console.ReadLine());

            var areaFloor = widthFloor * lengthFloor;
            var areaTile = sideTriangle * heightTriangle / 2;
            var neededTiles = (Math.Ceiling( areaFloor / areaTile)) + 5;
            var totalSum = neededTiles * priceTile + sumMaster;

            if (totalSum <= collectedMoney)
            {
                Console.WriteLine("{0:f2} lv left.", collectedMoney - totalSum);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.", totalSum - collectedMoney);
            }
        }
    }
}
