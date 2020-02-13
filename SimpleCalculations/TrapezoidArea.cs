﻿namespace Trapezoid_Area
{
    using System;

    public class TrapezoidArea
    {
        public static void Main()
        {
            var b1 = double.Parse(Console.ReadLine());
            var b2 = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var area = ((b1 + b2) * h) / 2;

            Console.WriteLine("Trapezoid Area = {0}", area);
        }
    }
}
