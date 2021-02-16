using System;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double percentOfBudget = budget / 100;

            if (budget <= 100.00)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                switch (season)
                {
                    case "summer":
                        Console.WriteLine($"Camp - {30 * percentOfBudget:F2}");
                        break;
                    case "winter":
                        Console.WriteLine($"Hotel - {70 * percentOfBudget:F2}");
                        break;
                }
            }
            else if (budget <= 1000.00)
            {
                Console.WriteLine("Somewhere in Balkans");
                switch (season)
                {
                    case "summer":
                        Console.WriteLine($"Camp - {40 * percentOfBudget:F2}");
                        break;
                    case "winter":
                        Console.WriteLine($"Hotel - {80 * percentOfBudget:F2}");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {90 * percentOfBudget:F2}");
            }
        }
    }
}
