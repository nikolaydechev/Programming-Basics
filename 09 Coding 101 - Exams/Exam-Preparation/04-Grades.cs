using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());

            var count1 = 0;
            var count2 = 0;
            var count3 = 0;
            var count4 = 0;
            var sumGrades = 0.0;

            for (int i = 0; i < n; i++)
            {
                var grade = double.Parse(Console.ReadLine());
                sumGrades = sumGrades + grade;
                if (grade >= 5.00)
                {
                    ++count1;
                }
                if (grade >= 4.00 && grade <= 4.99)
                {
                    ++count2;
                }
                if (grade >= 3.00 && grade <= 3.99)
                {
                    ++count3;
                }
                if (grade < 3.00)
                {
                    ++count4;
                }
            }
            Console.WriteLine("Top students: {0:f2}%", count1 / n * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", count2 / n * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", count3 / n * 100);
            Console.WriteLine("Fail: {0:f2}%", count4 / n * 100);
            Console.WriteLine("Average: {0:f2}", sumGrades / n);
        }
    }
}

