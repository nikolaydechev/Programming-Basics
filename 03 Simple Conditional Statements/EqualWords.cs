﻿using System;

namespace EqualWords
{
    class EqualWords
    {
        public static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();
            firstWord = firstWord.ToLower();
            secondWord = secondWord.ToLower();

            if (firstWord == secondWord)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
