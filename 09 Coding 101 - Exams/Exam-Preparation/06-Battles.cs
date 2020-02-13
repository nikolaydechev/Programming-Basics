using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var battles = int.Parse(Console.ReadLine());

            var counter = 0;

            for (int i = 1; i <= n1; i++)
            {
                for (int j = 1; j <= n2; j++)
                {
                    counter++;
                    if ( counter > battles)
                    {
                        break;
                    }
                    Console.Write("({0} <-> {1}) ", i, j);
                }
            }
            Console.WriteLine();
        }
    }
}
