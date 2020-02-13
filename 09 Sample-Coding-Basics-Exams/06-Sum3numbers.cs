using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Sum3numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var n3 = int.Parse(Console.ReadLine());

            if (n1 + n2 == n3 && n1 <= n2)
            {
                Console.WriteLine("{0} + {1} = {2}", n1, n2, n3);
            }
            else if (n1 + n2 == n3 && n1 > n2)
            {
                Console.WriteLine("{0} + {1} = {2}", n2, n1, n3);
            }
            else if (n1 + n3 == n2 && n1 <= n3)
            {
                Console.WriteLine("{0} + {1} = {2}", n1, n3, n2);
            }
            else if (n1 + n3 == n2 && n1 > n3)
            {
                Console.WriteLine("{0} + {1} = {2}", n3, n1, n2);
            }
            else if (n2 + n3 == n1 && n2 <= n3)
            {
                Console.WriteLine("{0} + {1} = {2}", n2, n3, n1);
            }
            else if (n2 + n3 == n1 && n2 > n3)
            {
                Console.WriteLine("{0} + {1} = {2}", n3, n2, n1);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
