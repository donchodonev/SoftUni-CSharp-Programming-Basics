using System;

namespace Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string ticketCategory = Console.ReadLine();
            decimal amountOfPeople = decimal.Parse(Console.ReadLine());

            decimal vipTicketPrice = 499.99m;
            decimal normalTicketPrice = 249.99m;

            decimal budgetPercent = budget / 100m;

            decimal transportCost = 0m;
            decimal totalTicketCost = 0m;

            //check transport costs
            if (amountOfPeople <= 4)
            {
                transportCost = 75m * budgetPercent;
            }
            else if (amountOfPeople <= 9 && amountOfPeople >= 5)
            {
                transportCost = 60m * budgetPercent;
            }
            else if (amountOfPeople <= 24 && amountOfPeople >= 10)
            {
                transportCost = 50m * budgetPercent;
            }
            else if (amountOfPeople <= 49 && amountOfPeople >= 25)
            {
                transportCost = 40m * budgetPercent;
            }
            else if (amountOfPeople >= 50)
            {
                transportCost = 25m * budgetPercent;
            }

            //check ticket cost

            if (ticketCategory == "VIP")
            {
                totalTicketCost = amountOfPeople * vipTicketPrice;
            }
            else
            {
                totalTicketCost = amountOfPeople * normalTicketPrice;
            }

            //check total expense cost compared to budget
            //print

            decimal balance = budget - transportCost;

            if (balance - totalTicketCost >= 0)
            {
                Console.WriteLine($"Yes! You have {balance - totalTicketCost} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(balance - totalTicketCost)} leva.");
            }
        }
    }
}
