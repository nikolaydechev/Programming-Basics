using System;

namespace Even_or_Odd
{
    class EvenOrOdd
    {
        public static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
