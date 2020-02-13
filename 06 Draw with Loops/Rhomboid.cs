using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhomboid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            // upper part
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            // lower part
            for (int i = n - 1; i > 0; i--)
            {
                Console.Write(new string(' ', n - i));
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            //Vtori variant za lower part
            //
            //for (int i = 0; i < n-1; i++)
            //{
            //    Console.Write(new string(' ',i + 1)+"*");
            //    for (int j = n-(2+i); j > 0 ; j--)
            //    {
            //        Console.Write(" ");
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}



            //Treti variant za lower part
            //
            //for (int i = 1; i < n; i++)
            //{
            //    Console.Write(new string(' ',i )+"*");
            //    for (int j = n-(1+i); j > 0 ; j--)
            //    {
            //        Console.Write(" ");
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            // 4-ti variant za lower part
            //
            //for (int i = 1; i < n; i++)
            //{
            //    Console.Write(new string(' ',i);
            //    for (int j = n-i); j > 0 ; j--)
            //    {
           //         Console.Write("*");
            //        Console.Write(" ");
            //        
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
