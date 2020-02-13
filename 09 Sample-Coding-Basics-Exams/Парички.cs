using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Парички
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoin = int.Parse(Console.ReadLine());
            var yuan = double.Parse(Console.ReadLine());
            var comissionValue = double.Parse(Console.ReadLine());

            var bitcoinToLeva = bitcoin * 1168;
            var yuanToLeva = (yuan * 0.15) * 1.76;
            var sumInEuro = (bitcoinToLeva + yuanToLeva) / 1.95;
            var comission = (comissionValue / 100) * sumInEuro;
            var result = sumInEuro - comission;
            Console.WriteLine(result);
        }
    }
}
