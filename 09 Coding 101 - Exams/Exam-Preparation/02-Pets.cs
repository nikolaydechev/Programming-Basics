using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var food = double.Parse(Console.ReadLine());
            var dailyDogFood = double.Parse(Console.ReadLine());
            var dailyCatFood = double.Parse(Console.ReadLine());
            var dailyTurtleFood = double.Parse(Console.ReadLine()) / 1000;

            var dog = dailyDogFood * days;
            var cat = dailyCatFood * days;
            var turtle = dailyTurtleFood * days;
            var sum = dog + cat + turtle;

            if (food >= sum)
            {
            Console.WriteLine("{0} kilos of food left.", Math.Floor(food - sum));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(sum - food));
            }
        }
    }
}
