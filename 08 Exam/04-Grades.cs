using System;

namespace _04_Grades
{
    class Program
    {
        public static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());

            var group1 = 0;
            var group2 = 0;
            var group3 = 0;
            var group4 = 0;
            var sumScores = 0.0;

            for (int i = 0; i < n; i++)
            {
                var score = double.Parse(Console.ReadLine());
                sumScores = sumScores + score;
                if (score >= 2.00 && score <= 2.99)
                {
                    ++group1;
                }
                if (score >= 3.00 && score <= 3.99)
                {
                    ++group2;
                }
                if (score >= 4.00 && score <= 4.99)
                {
                    ++group3;
                }
                if (score >= 5.00)
                {
                    ++group4;
                }
            }
            Console.WriteLine("Top students: {0:f2}%", group4 / n * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", group3 / n * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", group2 / n * 100);
            Console.WriteLine("Fail: {0:f2}%", group1 / n * 100);
            Console.WriteLine("Average: {0:f2}", sumScores / n);
        }
    }
}
