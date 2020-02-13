using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var upperstars = 1;
            var upperdash = 2 * n - 1;
            var middleLeftRightStars = n / 2;
            var middleStars = n;
            var lowerdash = 1;
            var lowerstars = 2 * n - 1;

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('*', upperstars) + "\\");
                Console.Write(new string('-', upperdash) + "/");
                Console.Write(new string('*', upperstars));
                Console.WriteLine();
                upperstars += 1;
                upperdash -= 2;
            }

            for (int i = 1; i <= n/3; i++)
            {
                Console.Write("|" + new string('*', middleLeftRightStars) + "\\");
                Console.Write(new string('*', middleStars) + "/");
                Console.Write(new string('*', middleLeftRightStars) + "|");
                Console.WriteLine();
                middleStars -= 2;
                middleLeftRightStars += 1;
            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('-', lowerdash) + "\\");
                Console.Write(new string('*', lowerstars) + "/");
                Console.Write(new string('-', lowerdash));
                Console.WriteLine();
                lowerdash += 1;
                lowerstars -= 2;
            }
        }
    }
}
