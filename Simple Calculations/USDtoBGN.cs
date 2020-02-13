namespace USD_to_BGN
{
    using System;

    public class USDtoBGN
    {
        public static void Main()
        {
            Console.Write("USD =");
            var usd = double.Parse(Console.ReadLine());
            var bgn = usd * 1.79549;

            Console.WriteLine("BGN = {0}", Math.Round(bgn, 2));
        }
    }
}
