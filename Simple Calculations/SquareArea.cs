namespace ExampleTask
{
    using System;

    public class SquareArea
    {
        public static void Main()
        {
            var a = int.Parse(Console.ReadLine());

            var result = a * a;

            Console.WriteLine("Rezultata e {0}", result);
        }
    }
}
