using System;

namespace _02_Change_Tiles
{
    class Program
    {
        public static void Main(string[] args)
        {
            var collectedMoney = double.Parse(Console.ReadLine());
            var widthFloor = double.Parse(Console.ReadLine());
            var lengthFloor = double.Parse(Console.ReadLine());
            var sideTriangle = double.Parse(Console.ReadLine());
            var heigthTriangle = double.Parse(Console.ReadLine());
            var priceTile = double.Parse(Console.ReadLine());
            var sumMaster = double.Parse(Console.ReadLine());

            var floorArea = widthFloor * lengthFloor;
            var tileArea = sideTriangle * heigthTriangle / 2;
            var tilesNeeded = Math.Ceiling(floorArea / tileArea) + 5;
            var totalSum = tilesNeeded * priceTile + sumMaster;

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
