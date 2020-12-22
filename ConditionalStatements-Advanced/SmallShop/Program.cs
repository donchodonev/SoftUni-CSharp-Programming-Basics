using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            if (town == "Sofia")
            {
                double coffeePrice = 0.50;
                double waterPrice = 0.80;
                double beerPrice = 1.20;
                double sweetsPrice = 1.45;
                double peanutsPrice = 1.60;

                switch (product)
                {
                    case "coffee":
                        Console.WriteLine($"{quantity * coffeePrice}");
                        break;
                    case "water":
                        Console.WriteLine($"{quantity * waterPrice}");
                        break;
                    case "beer":
                        Console.WriteLine($"{quantity * beerPrice}");
                        break;
                    case "sweets":
                        Console.WriteLine($"{quantity * sweetsPrice}");
                        break;
                    case "peanuts":
                        Console.WriteLine($"{quantity * peanutsPrice}");
                        break;
                    default:
                        break;
                }
            }
            else if (town == "Plovdiv")
            {
                double coffeePrice = 0.40;
                double waterPrice = 0.70;
                double beerPrice = 1.15;
                double sweetsPrice = 1.30;
                double peanutsPrice = 1.50;

                switch (product)
                {
                    case "coffee":
                        Console.WriteLine($"{quantity * coffeePrice}");
                        break;
                    case "water":
                        Console.WriteLine($"{quantity * waterPrice}");
                        break;
                    case "beer":
                        Console.WriteLine($"{quantity * beerPrice}");
                        break;
                    case "sweets":
                        Console.WriteLine($"{quantity * sweetsPrice}");
                        break;
                    case "peanuts":
                        Console.WriteLine($"{quantity * peanutsPrice}");
                        break;
                    default:
                        break;
                }
            }
            else if (town == "Varna")
            {
                double coffeePrice = 0.45;
                double waterPrice = 0.70;
                double beerPrice = 1.10;
                double sweetsPrice = 1.35;
                double peanutsPrice = 1.55;

                switch (product)
                {
                    case "coffee":
                        Console.WriteLine($"{quantity * coffeePrice}");
                        break;
                    case "water":
                        Console.WriteLine($"{quantity * waterPrice}");
                        break;
                    case "beer":
                        Console.WriteLine($"{quantity * beerPrice}");
                        break;
                    case "sweets":
                        Console.WriteLine($"{quantity * sweetsPrice}");
                        break;
                    case "peanuts":
                        Console.WriteLine($"{quantity * peanutsPrice}");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
