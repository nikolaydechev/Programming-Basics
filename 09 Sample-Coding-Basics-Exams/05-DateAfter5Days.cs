using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DateAfter5Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = 2015;

            DateTime firstDate = new DateTime(year, month, day);
            DateTime secondDate = firstDate.AddDays(5);

            Console.WriteLine(secondDate.ToString("d.MM"));

        }
    }
}
