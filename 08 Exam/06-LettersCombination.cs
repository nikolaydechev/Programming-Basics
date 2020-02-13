using System;

namespace _06_LettersCombination
{
    class Program
    {
        public static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());

            var sum = 0;
            
            for (char i = letter; i <= letter1; i++)
            {
                for (char j = letter; j <= letter1; j++)
                {
                    for (char h = letter; h <= letter1; h++)
                    {
                        if (i != letter2 && j != letter2 && h != letter2)
                        {
                            Console.Write("{0}{1}{2} ",i,j,h);
                            sum++;
                        }
                        
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
