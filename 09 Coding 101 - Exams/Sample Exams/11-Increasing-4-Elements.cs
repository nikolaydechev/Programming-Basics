using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Increasing_4_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    for (int g = a; g <= b; g++)
                    {
                        for (int h = a; h <= b; h++)
                        {
                            if (a <= i && i < j && j < g && g < h && h <= b)
                            {
                                Console.WriteLine("{0} {1} {2} {3}", i, j , g, h);
                            }
                        }
                    }
                }
            }
            if (a - b < 3)
            {
                Console.WriteLine("No");
            }
        }
    }
}
