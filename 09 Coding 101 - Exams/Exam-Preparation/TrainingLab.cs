using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = double.Parse(Console.ReadLine()) * 100;
            var h = double.Parse(Console.ReadLine()) * 100;

            var hTables = Math.Floor((h-100) / 70);
            var wTables = Math.Floor(w / 120);

            var seats = (hTables * wTables) - 3;

            Console.WriteLine("{0}", seats);
        }
    }
}
