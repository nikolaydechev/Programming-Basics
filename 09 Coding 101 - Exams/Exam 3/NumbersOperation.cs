using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            var N1 = double.Parse(Console.ReadLine());
            var N2 = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            double result = 0;
            var EvenOdd = "";

            if (operation == "+")
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
                Console.WriteLine("{0} + {1} = {2} - {3}", N1, N2, result, EvenOdd);
            }
            else if (operation == "-")
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
                Console.WriteLine("{0} - {1} = {2} - {3}", N1, N2, result, EvenOdd);
            }
            else if (operation == "*")
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
                Console.WriteLine("{0} * {1} = {2} - {3}", N1, N2, result, EvenOdd);
            }
            else if (operation == "/")
            {
                if (N2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", N1);
                }
                else
                {
                    result = N1 / N2;
                    Console.WriteLine("{0} / {1} = {2:F2}", N1, N2, result);
                }
            }
            else if (operation == "%")
            {
                if (N2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", N1);
                }
                else
                {
                    result = N1 % N2;
                    Console.WriteLine("{0} % {1} = {2}", N1, N2, result);
                }
            }
        }
    }
}
