using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var row = "+";
            var innerLine = "|";

            for (int i = 1; i <= n - 2; i++)
            {
                row += " -";
            }
            row = row + " +";
            Console.WriteLine(row);


            for (int i= 1; i <= n-2; i++)
            {
                innerLine = innerLine + " -";
            }
            innerLine = innerLine + " |";

            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine(innerLine);
            }
            
            Console.WriteLine(row);
        }
    }
}


