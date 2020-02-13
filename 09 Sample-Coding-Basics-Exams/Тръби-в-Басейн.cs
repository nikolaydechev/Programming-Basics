using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тръби_в_Басейн
{
    class Program
    {
        static void Main(string[] args)
        {
            var V = int.Parse(Console.ReadLine());
            var P1 = int.Parse(Console.ReadLine());
            var P2 = int.Parse(Console.ReadLine());
            var H = double.Parse(Console.ReadLine());

            var firstPipeVolume = P1 * H;
            var secondPipeVolume = P2 * H;
            var totalPipeVolume = firstPipeVolume + secondPipeVolume;
            var overflowVolume = totalPipeVolume - V;
            if (V >= totalPipeVolume)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                    Math.Truncate((100 * totalPipeVolume) / V),
                    Math.Truncate((100 * firstPipeVolume) / totalPipeVolume),
                    Math.Truncate((100 * secondPipeVolume) / totalPipeVolume));
            }
            else if (V < totalPipeVolume)
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", H, overflowVolume);
            }
        }
    }
}
