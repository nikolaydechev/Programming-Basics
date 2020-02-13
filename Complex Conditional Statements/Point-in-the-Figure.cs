using System;

namespace Point_in_the_Figure
{
    class Program
    {
        public static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            bool inside = ((x > 0) && (x < 3 * h)) && (y > 0 && y < h) || ((x > h) && (x < 2 * h)) && ((y > 0) && (y < 4 * h));

            var border = (x >= 0) && (x <= h) && (y >= 0) && (y <= h) || (x == h) && (y <= h) && (y >= 0) ||
                (y >= h) && (y <= 4 * h) && (x == h) || (y == 4 * h) && (x >= h) && (x <= 2 * h) ||
                (x == 2 * h) && (y >= h) && (y <= 4 * h) || (x >= 2 * h) && (x <= 3 * h) && (y == h) || (x == 3 * h) && (y >= 0) && (y <= h) ||
                (y == 0) && (x >= 0) && (x <= 3 * h);

            var outside = (x < 0) || (y < 0) || (y > 4 * h) || (y > h) && (x < h) || (y > h) && (x > 2 * h) || (x > 3 * h);


            if (inside)
            {
                Console.WriteLine("inside");
            }
            else if (border)
            {
                Console.WriteLine("border");
            }
            else if (outside)
            {
                Console.WriteLine("outside");
            }
        }
    }
}
