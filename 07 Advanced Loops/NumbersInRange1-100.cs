using System;

namespace NumbersInRange1_100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Еnter a number in the range [1...100]: ");
            var n = int.Parse(Console.ReadLine());

            while (true)
            {
                if (n < 1 || n > 100)
                {
                    Console.WriteLine("Invalid number!");
                    Console.Write("Еnter a number in the range [1...100]: ");
                    n = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("The number is:{0}", n);
                    break;
                }
            }

            //var n = int.Parse(Console.ReadLine());

            //var number = 0;

            //for (int i = 0; ; i++)
            //{
            //    number = number * 2 + 1;
            //    if (number <=n)
            //    {
            //        Console.WriteLine(number);
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
        }
    }
}
