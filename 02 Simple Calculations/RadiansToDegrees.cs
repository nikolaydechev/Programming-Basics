namespace Radians_to_Degrees
{
    using System;

    public class RadiansToDegrees
    {
        public static void Main()
        {
            Console.Write("Radians= ");
            var radians = double.Parse(Console.ReadLine());

            var degrees = (radians * 180) / Math.PI;

            Console.WriteLine("Degrees = {0}", Math.Round(degrees));

        }
    }
}
