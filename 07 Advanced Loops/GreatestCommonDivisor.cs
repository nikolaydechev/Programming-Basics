using System;

namespace GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var oldbNumber = 0;

            while (b != 0)
            {
                oldbNumber = b;
                b = a % b;
                a = oldbNumber;
            }
            Console.WriteLine(a);
        }
    }
}
