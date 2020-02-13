using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var kgFoodAvailable = int.Parse(Console.ReadLine());
            var kgFoodDogDaily = double.Parse(Console.ReadLine());
            var kgFoodCatDaily = double.Parse(Console.ReadLine());
            var gramFoodTurtle = double.Parse(Console.ReadLine()) / 1000;

            var DogFood = days * kgFoodDogDaily;
            var CatFood = days * kgFoodCatDaily;
            var TurtleFood = days * gramFoodTurtle;

            var sumFood = DogFood + CatFood + TurtleFood;
            var neededFood = kgFoodAvailable - sumFood;
            var notEnoughFood = sumFood - kgFoodAvailable;

            if (kgFoodAvailable >= sumFood)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(neededFood));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(notEnoughFood));    
            }    
            
        }
    }
}
