namespace Circle_Area_Perimeter
{
    using System;

    public class CircleAreaPerimeter
    {
        public static void Main()
        {
            Console.Write("Enter circle radius. r = ");
            var r = double.Parse(Console.ReadLine());
            var area = Math.PI * Math.Pow(r, 2);
            var perimeter = 2 * Math.PI * r;

            Console.WriteLine("Area = {0}", area);
            Console.WriteLine("Perimeter = {0}", perimeter);
        }
    }
}
}
