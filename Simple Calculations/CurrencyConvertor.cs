namespace CurrencyConvertor
{
    using System;

    public class CurrencyConvertor
    {
        public static void Main()
        {
            var value = double.Parse(Console.ReadLine());
            string EntranceCurrency = Console.ReadLine();
            string OutputCurrency = Console.ReadLine();

            if (EntranceCurrency == "USD")
            {
                if (OutputCurrency == "USD")
                {
                    Console.WriteLine(value);
                }
                else if (OutputCurrency == "BGN")
                {
                    Console.WriteLine(value * 1.79549);
                }
                else if (OutputCurrency == "GBP")
                {
                    Console.WriteLine((value * 1.79549) / 2.53405);
                }
                else if (OutputCurrency == "EUR")
                {
                    Console.WriteLine((value * 1.79549) / 1.95583);
                }
            }

            if (EntranceCurrency == "BGN")
            {
                if (OutputCurrency == "BGN")
                {
                    Console.WriteLine(value);
                }
                else if (OutputCurrency == "USD")
                {
                    Console.WriteLine(value / 1.79549);
                }
                else if (OutputCurrency == "GBP")
                {
                    Console.WriteLine(value / 2.53405);
                }
                else if (OutputCurrency == "EUR")
                {
                    Console.WriteLine(value / 1.95583);
                }
            }

            if (EntranceCurrency == "GBP")
            {
                if (OutputCurrency == "GBP")
                {
                    Console.WriteLine(value);
                }
                else if (OutputCurrency == "BGN")
                {
                    Console.WriteLine(value * 2.53405);
                }
                else if (OutputCurrency == "USD")
                {
                    Console.WriteLine((value * 2.53405) / 1.79549);
                }
                else if (OutputCurrency == "EUR")
                {
                    Console.WriteLine((value * 2.53405) / 1.95583);
                }
            }

            if (EntranceCurrency == "EUR")
            {
                if (OutputCurrency == "EUR")
                {
                    Console.WriteLine(value);
                }
                else if (OutputCurrency == "BGN")
                {
                    Console.WriteLine(value * 1.95583);
                }
                else if (OutputCurrency == "GBP")
                {
                    Console.WriteLine((value * 1.95583) / 2.53405);
                }
                else if (OutputCurrency == "USD")
                {
                    Console.WriteLine((value * 1.95583) / 1.79549);
                }
            }
        }
    }
}
