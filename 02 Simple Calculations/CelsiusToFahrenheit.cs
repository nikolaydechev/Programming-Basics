namespace Celsius_to_Fahrenheit
{
    using System;

    public class CelsiusToFahrenheit
    {
        public static void Main()
        {
            Console.Write("Enter Celsius:");
            var C = double.Parse(Console.ReadLine());
            
            var Fahrenheit = C * 1.8 + 32;

            Console.WriteLine("Fahrenheit = {0}", Fahrenheit);
        }
    }
}
