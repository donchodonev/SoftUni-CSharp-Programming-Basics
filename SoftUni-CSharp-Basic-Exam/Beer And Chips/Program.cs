using System;

namespace Beer_And_Chips
{
    class Program
    {
        static void Main(string[] args)
        {
            string fanName = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int bottlesOfBeer = int.Parse(Console.ReadLine());
            int packetsOfChips = int.Parse(Console.ReadLine());

            double beerPrice = 1.20;

            double totalBeerPrice = beerPrice * bottlesOfBeer;
            double priceOfPacketOfChips = totalBeerPrice * 0.45;
            double totalPacketOfChipsPrice = Math.Ceiling(priceOfPacketOfChips * packetsOfChips);

            double totalSum = totalBeerPrice + totalPacketOfChipsPrice;

            if (totalSum <= budget)
            {
                Console.WriteLine($"{fanName} bought a snack and has {budget - totalSum:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"{fanName} needs {totalSum - budget:F2} more leva!");
            }
        }
    }
}
