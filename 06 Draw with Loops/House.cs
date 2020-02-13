using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var stars = 1;
            var starsEvenNumber = 2;

            for (int row = 1; row <= (n + 1) / 2; row++)
            {
                if (n % 2 != 0)
                {
                    Console.Write(new string('-', (n - stars) / 2));
                    Console.Write(new string('*', stars));
                    Console.Write(new string('-', (n - stars) / 2));
                }

                if (n % 2 == 0)
                {
                    Console.Write(new string('-', (n - starsEvenNumber) / 2));
                    Console.Write(new string('*', starsEvenNumber));
                    Console.Write(new string('-', (n - starsEvenNumber) / 2));

                }
                stars += 2;
                starsEvenNumber += 2;
                Console.WriteLine();
            }

            for (int i = 0; i <= n / 2 - 1; i++)
            {
                Console.Write(new string('|', 1) + new string('*', n - 2) + new string('|', 1));
                Console.WriteLine();
            }


        }
    }
}
