using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int digit = n / 10;
            
            int digit3 = n % 10;
            int digit2 = digit % 10;
            int digit1 = digit / 10;
            
            for (int row = 0; row < digit1 + digit2; row++)
            {
                for (int col = 0; col < digit1 + digit3; col++)
                {
                    if (n % 5 == 0)
                    {
                        n -= digit1;
                        Console.Write("{0} ", n);
                    }
                    else if (n % 3 == 0)
                    {
                        n -= digit2;
                        Console.Write("{0} ", n);
                    }
                    else
                    {
                        n += digit3;
                        Console.Write("{0} ", n);
                    } 
                }
                Console.WriteLine();

            }
        }
    }
}
