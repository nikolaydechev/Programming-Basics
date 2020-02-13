using System;

namespace SumSeconds
{
    class SumSeconds
    {
        public static void Main(string[] args) 
        {
            var firstSec = int.Parse(Console.ReadLine());
            var secondSec = int.Parse(Console.ReadLine());
            var thirdSec = int.Parse(Console.ReadLine());

            var totalSec = firstSec + secondSec + thirdSec;

            var min = totalSec / 60 ;
            var sec = totalSec % 60;

            Console.WriteLine("{0}:{1:00}", min, sec);
        }
    }
}
