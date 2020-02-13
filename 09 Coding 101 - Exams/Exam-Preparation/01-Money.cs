using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitCoin = int.Parse(Console.ReadLine());
            var yuan = double.Parse(Console.ReadLine());
            var commission = double.Parse(Console.ReadLine()) /100;

            var totalEuro = (((bitCoin * 1168) + (yuan * 0.15) * 1.76)) / 1.95;
            var result = totalEuro - (totalEuro * commission);

            Console.WriteLine(result);
        }
    }
}
