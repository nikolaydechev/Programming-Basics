using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var leftRight = (n - 3) / 2;
            var dashMid1 = 1;
            var leftRightDown = 1;

            var EvenleftRight = (n - 4) / 2;
            var EvenDashMid1 = 2;
            var EvenleftRightDown = 1;

            if (n == 1)
            {
                Console.WriteLine("*");
            }
            if (n == 2)
            {
                Console.WriteLine("**");
            }

            if (n % 2 != 0 && n != 1)
            {

                Console.WriteLine(new string('-', (n - 1) / 2) + new string('*', 1) + new string('-', (n - 1) / 2));
                for (int i = 1; i <= (n - 1) / 2; i++)
                {
                    Console.Write(new string('-', leftRight));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('-', dashMid1));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('-', leftRight));
                    leftRight = leftRight - 1;
                    dashMid1 = dashMid1 + 2;
                    Console.WriteLine();
                }
                var dashMid2 = dashMid1 - 2;
                for (int i = 1; i <= (n - 3) / 2; i++)
                {
                    dashMid2 = dashMid2 - 2;
                    Console.Write(new string('-', leftRightDown));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('-', dashMid2));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('-', leftRightDown));

                    leftRightDown = leftRightDown + 1;
                    Console.WriteLine();
                }
                Console.WriteLine(new string('-', (n - 1) / 2) + new string('*', 1) + new string('-', (n - 1) / 2));
            }
            if (n % 2 == 0 && n!= 2)
            {

                Console.WriteLine(new string('-', (n - 2) / 2) + new string('*', 2) + new string('-', (n - 2) / 2));
                for (int i = 1; i <= (n - 2) / 2; i++)
                {
                    Console.Write(new string('-', EvenleftRight));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('-', EvenDashMid1));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('-', EvenleftRight));

                    EvenleftRight -= 1;
                    EvenDashMid1 = EvenDashMid1 + 2;
                    Console.WriteLine();
                }
                var EvenDashMid2 = EvenDashMid1 - 2;
                for (int i = 1; i <= (n - 4) / 2; i++)
                {
                    EvenDashMid2 = EvenDashMid2 - 2;
                    Console.Write(new string('-', EvenleftRightDown));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('-', EvenDashMid2));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('-', EvenleftRightDown));

                    EvenleftRightDown += 1;
                    Console.WriteLine();
                }

                Console.WriteLine(new string('-', (n - 2) / 2) + new string('*', 2) + new string('-', (n - 2) / 2));

            }

        }
    }
}
