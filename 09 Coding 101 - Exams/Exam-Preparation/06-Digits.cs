using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var thirdDigit = n % 10;
            var secondDigit = (n / 10) % 10;
            var firstDigit = (n / 10) / 10;

            var row = firstDigit + secondDigit;
            var col = firstDigit + thirdDigit;

            var num = n;
            
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                { 
                    if (num % 5 == 0)
                    {
                        num = num - firstDigit;
                        Console.Write("{0} ", num);
                    }
                    else if (num % 3 == 0)
                    {
                        num = num - secondDigit;
                        Console.Write("{0} ", num);
                    }
                    else 
                    {
                        num = num + thirdDigit;
                        Console.Write("{0} ", num);
                    } 
                }
                Console.WriteLine();
            }
        }
    }
}
