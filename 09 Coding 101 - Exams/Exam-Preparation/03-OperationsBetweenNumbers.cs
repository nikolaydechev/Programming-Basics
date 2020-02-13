using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var N1 = double.Parse(Console.ReadLine());
            var N2 = double.Parse(Console.ReadLine());
            
            string sign = Console.ReadLine();
            var result = 0.0;
            var EvenOdd = "";

            if (N2 == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", N1);
            }
            if (sign == "+")
            {
                result = N1 + N2;
                if (result % 2 == 0)
                {
                    EvenOdd = "even";
                }
                else
                {
                    EvenOdd = "odd";
                }
                Console.WriteLine("{0} {1} {2} = {3} - {4}",N1, sign, N2, result, EvenOdd );
            }
            else if (sign == "-")
            {
                result = N1 - N2;
                if (result % 2 == 0)
                {
                    EvenOdd = "even";
                }
                else
                {
                    EvenOdd = "odd";
                }
                Console.WriteLine("{0} {1} {2} = {3} - {4}", N1, sign, N2, result, EvenOdd);
            }
            else if (sign == "*")
            {
                result = N1 * N2;
                if (result % 2 == 0)
                {
                    EvenOdd = "even";
                }
                else
                {
                    EvenOdd = "odd";
                }
                Console.WriteLine("{0} {1} {2} = {3} - {4}", N1, sign, N2, result, EvenOdd);
            }
            else if (sign == "/" && N2 != 0)
            {
                result = N1 / N2;
                Console.WriteLine("{0} {1} {2} = {3:f2}", N1, sign, N2, result);
            }
            else if (sign == "%" && N2 )
            {
                result = N1 % N2;
                Console.WriteLine("{0} {1} {2} = {3}", N1, sign, N2, result);
            } 
        }
    }
}
