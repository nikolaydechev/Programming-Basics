using System;

namespace GreaterNumber
{
    class GreaterNumber
    {
        public static void Main(string[] args)
        {
            var firstNum = double.Parse(Console.ReadLine());
            var secondNum = double.Parse(Console.ReadLine());

            if (firstNum > secondNum)
            {
                Console.WriteLine("Greater Number: " + firstNum);
            }
            else
            {
                Console.WriteLine("Greater Number: " + secondNum);
            }
        }
    }
}
