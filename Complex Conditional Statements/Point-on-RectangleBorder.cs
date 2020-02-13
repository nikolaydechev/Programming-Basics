using System;

namespace Point_on_RectangleBorder
{
    class Program
    {
        public static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            if (x==x1)
            {
                if (y>=y1 && y<=y2)
                {
                    Console.WriteLine("Border");
                }
                else
                {
                    Console.WriteLine("Inside / Outside");
                }
            }
            else if (x==x2)
            {
                if (y >= y1 && y <= y2)
                {
                    Console.WriteLine("Border");
                }
                else
                {
                    Console.WriteLine("Inside / Outside");
                }
            }
            else if (y==y1)
            {
                if (x>=x1 && x<=x2)
                {
                    Console.WriteLine("Border");
                }
                else
                {
                    Console.WriteLine("Inside / Outside");
                }
            }
            else if (y==y2)
            {
                if (x>=x1 && x<=x2)
                {
                    Console.WriteLine("Border");
                }
                else
                {
                    Console.WriteLine("Inside / Outside");
                }
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }

        }
    }
}
