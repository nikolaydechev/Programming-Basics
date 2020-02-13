using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_LettersCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char letter3 = char.Parse(Console.ReadLine());

            var sum = 0;

            for (char i = letter1; i <= letter2; i++)
            {
                for (char j = letter1; j <= letter2; j++)
                {
                    for (char h = letter1; h <= letter2; h++)
                    {
                        if (i != letter3 && j != letter3 && h != letter3)
                        {
                            Console.Write("{0}{1}{2} ", i,j,h);
                            sum++;
                        }
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
