using System;

namespace _05_ChristmasHat
{
    class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var points = 2 * n - 1;
            var dash = 0;

            Console.WriteLine(new string('.', 2 * n - 1) + "/" + "|" + "\\" + new string('.', 2 * n - 1));
            Console.WriteLine(new string('.', 2 * n - 1) + "\\" + "|" + "/" + new string('.', 2 * n - 1));

            for (int i = 1; i <= 2 * n; i++)
            {
                Console.Write(new string('.', points) + "*");
                Console.Write(new string('-', dash) + "*");
                Console.Write(new string('-', dash) + "*");
                Console.Write(new string('.', points));
                Console.WriteLine();
                points -= 1;
                dash += 1;

            }
            Console.WriteLine(new string('*', 4 * n + 1));

            for (int i = 0; i < (4 * n + 1) / 2; i++)
            {
                Console.Write(new string('*', 1));
                Console.Write(new string('.', 1));

            }
            Console.Write("*");
            Console.WriteLine();

            Console.WriteLine(new string('*', 4 * n + 1));

        }
    }
}
