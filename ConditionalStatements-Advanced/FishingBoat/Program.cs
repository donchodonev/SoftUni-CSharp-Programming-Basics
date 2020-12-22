using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double price = 0.0;
            double discount = 0.0;

            switch (season)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                    break;
            }

            if (fishermen <= 6)
            {
                discount += 0.90;
            }
            else if (fishermen <= 11 && fishermen > 6)
            {
                discount += 0.85;
            }
            else
            {
                discount += 0.75;
            }

            double totalPrice = price * discount;


            if (fishermen % 2 == 0 && season != "Autumn")
            {
                totalPrice = totalPrice * 0.95;
            }



            if (budget >= totalPrice)
            {
                Console.WriteLine($"Yes! You have {budget - totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:f2} leva.");
            }
        }
    }
}
