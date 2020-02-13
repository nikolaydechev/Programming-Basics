using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Учебна_Зала
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = double.Parse(Console.ReadLine()) * 100;
            var h = double.Parse(Console.ReadLine()) * 100;
            var rows = Math.Truncate(w /120);
            var tables = Math.Truncate((h - 100) / 70);
            var seats = (rows * tables) - 3;
            Console.WriteLine(seats);
        }
    }
}
