using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Pool_Pipes
{
    class Program
    {
        static void Main(string[] args)
        {
            var volumePool = int.Parse(Console.ReadLine());
            var P1 = int.Parse(Console.ReadLine());
            var P2 = int.Parse(Console.ReadLine());
            var H = double.Parse(Console.ReadLine());

            var firstPipeCapacity = P1 * H;
            var secondPipeCapacity = P2 * H;
            var totalCapacity = firstPipeCapacity + secondPipeCapacity;

            if (totalCapacity <= volumePool)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                    Math.Truncate((totalCapacity / volumePool) * 100), Math.Truncate((firstPipeCapacity / totalCapacity) * 100), Math.Truncate((secondPipeCapacity / totalCapacity) * 100));
            }
            else if (totalCapacity > volumePool)
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", H, (totalCapacity - volumePool));
            }

        }
    }
}
