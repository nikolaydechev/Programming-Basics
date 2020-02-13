using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            var examHour = int.Parse(Console.ReadLine()) *60;
            var examMinute = int.Parse(Console.ReadLine());
            var arrivingHour = int.Parse(Console.ReadLine()) * 60;
            var arrivingMinute = int.Parse(Console.ReadLine());

            var examTime = examHour + examMinute;
            var arrivingTime = arrivingHour + arrivingMinute;
            var timeDifference = arrivingTime - examTime;

            var hour = Math.Abs(timeDifference / 60);
            var minute = Math.Abs(timeDifference % 60);
            
            if (timeDifference < -30 && timeDifference > -60)
            {
                Console.WriteLine("Early \n{0} minutes before the start", Math.Abs(timeDifference));
            }
            else if (timeDifference <= -60)
            {
                Console.WriteLine("Early \n{0}:{1:00} hours before the start", hour, minute);
            }
            else if (timeDifference >=-30 && timeDifference <=0)
            {
                Console.WriteLine("On time \n{0} minutes before the start", Math.Abs(timeDifference));
            }
            else if (timeDifference == 0)
            {
                Console.WriteLine("On time");
            }
            else if (timeDifference > 0 && timeDifference < 60)
            {
                Console.WriteLine("Late \n{0} minutes after the start", Math.Abs(timeDifference));
            }
            else if (timeDifference >= 60)
            {
                Console.WriteLine("Late \n{0}:{1:00} hours after the start", hour, minute);
            }
        }
    }
}
