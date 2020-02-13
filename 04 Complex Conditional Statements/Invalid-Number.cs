using System;

namespace Invalid_Number
{
    class Program
    {
        public static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            if ((number >= 100) && (number <=200))
            {
                Console.WriteLine("");
            }
            else if (number == 0)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("invalid");
            }
           
        }
    }
}

