using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorPasswords
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var L = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (char L1 = 'a'; L1 < 'a' + L; L1++)
                    {
                        for (char L2 = 'a'; L2 < 'a' + L; L2++)
                        {
                            for (int h = Math.Max(i, j) + 1; h <= n; h++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", i, j, L1, L2, h);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
