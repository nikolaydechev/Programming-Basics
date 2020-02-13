using System;

namespace _3_Equal_Numbers
{
    class ThreeEqualNumbers
    {
        public static void Main(string[] args)
        {
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            var num3 = double.Parse(Console.ReadLine());
          

            if (num1 == num2 && num3 == num2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
