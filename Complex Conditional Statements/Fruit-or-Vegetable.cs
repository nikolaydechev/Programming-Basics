﻿using System;

namespace Fruit_or_Vegetable
{
    class Program
    {
        public static void Main(string[] args)
        {
            var productName = Console.ReadLine();

            if (productName == "banana" || productName == "apple" || productName == "kiwi" || productName == "cherry" || productName == "lemon" || productName == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (productName == "tomato" || productName == "cucumber" || productName == "pepper" || productName == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }

        }
    }
}
