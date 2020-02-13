using System;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var num = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num);
                    Console.Write(" ");
                    num++;
                    if (num > n)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (num > n)
                {
                    break;
                }
            }
            
        }
    }
}
