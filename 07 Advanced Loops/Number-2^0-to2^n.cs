using System;

namespace Number_2_0_to2_n
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var num = 1;

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(num);
                num = num * 2;
            }
        }
    }
}
