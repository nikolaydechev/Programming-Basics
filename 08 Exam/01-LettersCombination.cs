using System;

namespace _01_LettersCombination
{
    class Program
    {
        public static void Main(string[] args)
        {
            var InitialSpeed = int.Parse(Console.ReadLine());
            var firstTime = int.Parse(Console.ReadLine());
            var secondTime = int.Parse(Console.ReadLine());
            var thirdTime = int.Parse(Console.ReadLine());

            double firstTimeInHour = firstTime / 60.00;
            double secondTimeInHour = secondTime / 60.00;
            double thirdTimeInHour = thirdTime / 60.00;

            var DistanceInitialSpeed = InitialSpeed * firstTimeInHour;
            var AfterIncreasment = InitialSpeed + InitialSpeed * 0.10;
            var AfterDecreasment = AfterIncreasment - AfterIncreasment * 0.05;

            var secondDistance = AfterIncreasment * secondTimeInHour;
            var thirdDistance = AfterDecreasment * thirdTimeInHour;

            var totalKm = DistanceInitialSpeed + secondDistance + thirdDistance;
            Console.WriteLine("{0:f2}", totalKm);
            
        }
    }
}
