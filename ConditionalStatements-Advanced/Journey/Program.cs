using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string accomodation = "";
            double moneySpent = 0.0;


            if (budget <= 100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        moneySpent = (budget / 100) * 30;
                        accomodation = "Camp";
                        break;
                    case "winter":
                        moneySpent = (budget / 100) * 70;
                        accomodation = "Hotel";
                        break;
                }
            }
            else if (budget <= 1000 && budget > 99)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        moneySpent = (budget / 100) * 40;
                        accomodation = "Camp";
                        break;
                    case "winter":
                        moneySpent = (budget / 100) * 80;
                        accomodation = "Hotel";
                        break;
                }
            }
            else
            {
                destination = "Europe";
                accomodation = "Hotel";
                moneySpent = (budget / 100) * 90;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{accomodation} - {moneySpent:F2}");
        }
    }
}
