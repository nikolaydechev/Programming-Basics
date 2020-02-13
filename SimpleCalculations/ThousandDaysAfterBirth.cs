namespace _1000days_after_birth
{
    using System;

    public class ThousandDaysAfterBirth
    {
        public static void Main()
        {
            var birthDateString = Console.ReadLine();
            var format = "dd-MM-yyyy";
            var date = DateTime.ParseExact(birthDateString, format, null);
            date = date.AddDays(999);
            Console.WriteLine(date.ToString(format));
        }
    }
}
