using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var f0 = 1;
            var f1 = 1;

            for (int i = 1; i < n; i++)
            {
                var fNext = f0 + f1;
                f0 = f1;
                f1 = fNext;
            }
            Console.WriteLine(f1);
        }
    }
}
