using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budjet = double.Parse(Console.ReadLine());
            var ticketType = Console.ReadLine();
            var numberOfPeople = double.Parse(Console.ReadLine());
           
            double VipTicket = 499.99;
            double NormalTicket = 249.99;
            double transportMoney = 0.0;
            double leftMoney = 0.0;
            double neededMoney = 0.0;

            if (numberOfPeople >= 1 && numberOfPeople <= 4)
            {
                transportMoney = 0.75 * budjet;
                if (ticketType == "VIP")
                {
                    leftMoney = ((budjet - transportMoney) - (numberOfPeople * VipTicket));
                    neededMoney = (numberOfPeople * VipTicket) - (budjet - transportMoney);
                }
                else if (ticketType == "Normal")
                {
                    leftMoney = ((budjet - transportMoney) - (numberOfPeople * NormalTicket));
                    neededMoney = ((numberOfPeople * NormalTicket) - (budjet - transportMoney));
                }
            }
            else if (numberOfPeople >= 5 && numberOfPeople <= 9)
            {
                transportMoney = 0.6 * budjet;
                if (ticketType == "VIP")
                {
                    leftMoney = ((budjet - transportMoney) - (numberOfPeople * VipTicket));
                    neededMoney = ((numberOfPeople * VipTicket) - (budjet - transportMoney));
                }
                else if (ticketType == "Normal")
                {
                    leftMoney = (budjet - transportMoney) - (numberOfPeople * NormalTicket);
                    neededMoney = (numberOfPeople * NormalTicket) - (budjet - transportMoney);
                }
            }
            else if (numberOfPeople >= 10 && numberOfPeople <= 24)
            {
                transportMoney = 0.5 * budjet;
                if (ticketType == "VIP")
                {
                    leftMoney = (budjet - transportMoney) - (numberOfPeople * VipTicket);
                    neededMoney = (numberOfPeople * VipTicket) - (budjet - transportMoney);
                }
                else if (ticketType == "Normal")
                {
                    leftMoney = (budjet - transportMoney) - (numberOfPeople * NormalTicket);
                    neededMoney = (numberOfPeople * NormalTicket) - (budjet - transportMoney);
                }
            }
            else if (numberOfPeople >= 25 && numberOfPeople <= 49)
            {
                transportMoney = 0.4 * budjet;
                if (ticketType == "VIP")
                {
                    leftMoney = (budjet - transportMoney) - (numberOfPeople * VipTicket);
                    neededMoney = (numberOfPeople * VipTicket) - (budjet - transportMoney);
                }
                else if (ticketType == "Normal")
                {
                    leftMoney = (budjet - transportMoney) - (numberOfPeople * NormalTicket);
                    neededMoney = (numberOfPeople * NormalTicket) - (budjet - transportMoney);
                }
            }
            else if (numberOfPeople >= 50)
            {
                transportMoney = 0.25 * budjet;
                if (ticketType == "VIP")
                {
                    leftMoney = (budjet - transportMoney) - (numberOfPeople * VipTicket);
                    neededMoney = (numberOfPeople * VipTicket) - (budjet - transportMoney);
                }
                else if (ticketType == "Normal")
                {
                    leftMoney = (budjet - transportMoney) - (numberOfPeople * NormalTicket);
                    neededMoney = (numberOfPeople * NormalTicket) - (budjet - transportMoney);
                }
            }

            if (leftMoney >= 0)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", leftMoney);
            }
            else 
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", neededMoney);
            }
        }
    }
}
