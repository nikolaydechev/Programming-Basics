using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Навреме_за_Изпит
{
    class Program
    {
        static void Main(string[] args)
        {
            var examHour = int.Parse(Console.ReadLine());
            var examMinutes = int.Parse(Console.ReadLine());
            var arrivingHour = int.Parse(Console.ReadLine());
            var arrivingMinutes = int.Parse(Console.ReadLine());


            var examTime = (examHour * 60) + examMinutes;
            var studentTime = (arrivingHour * 60) + arrivingMinutes;
            var timeDifference = studentTime - examTime;

            if (timeDifference < -30 && timeDifference < 0)
            {
                Console.WriteLine("Early");
            }
            else if (timeDifference <= 0 && timeDifference >= -30 )
            {
                Console.WriteLine("On time");
            }
            else if (timeDifference > 0)
            {
                Console.WriteLine("Late");
            }

            if (timeDifference != 0)
            {
                var hours = Math.Abs(timeDifference / 60);
                var minutes = Math.Abs(timeDifference % 60);
                if (timeDifference <= -60 && timeDifference < 0)
                {
                    Console.WriteLine("{0}:{1:00} hours before the start", hours, minutes);
                }
                else if (timeDifference >= -59 && timeDifference < 0)
                {
                    Console.WriteLine("{0} minutes before the start", minutes);
                }
                else if (timeDifference <= 59 && timeDifference > 0)
                {
                    Console.WriteLine("{0} minutes after the start", minutes);
                }
                else if (timeDifference >= 60)
                {
                    Console.WriteLine("{0}:{1:00} hours after the start", hours, minutes);
                }
            }
            
        }
    }
}
