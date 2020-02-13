namespace SquareOfStars
{
    using System;

    public class SquareOfStars
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*', n));

            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine(new string('*', 1) + new string(' ', n - 2) + new string('*', 1));
                Console.WriteLine(new string('*', n));
            }
        }
    }
}
