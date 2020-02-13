using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hack_method
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = magicString("a", 11);
            Console.WriteLine(text);
        }

        public static string magicString(String text, int repeatCount)
        {
            string outputText = "";

            for (int i = 0; i < repeatCount; i++)
            {
                outputText = outputText + text;
            }
            return outputText;
        }

    }
}
