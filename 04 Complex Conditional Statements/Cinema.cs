using System;

namespace Cinema
{
    class Program
    {
        public static void Main(string[] args)
        {
            var projection = Console.ReadLine().ToLower();
            var r = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var result = 0.0;
            if (projection == "premiere")
            {
                result = r * c * 12;
            }
            else if (projection == "normal")
            {
                result = r * c * 7.5;
            }
            else if (projection == "discount")
            {
                result = r * c * 5;
            }
            Console.WriteLine("{0:f2}", result);
            
        }
    }
}
