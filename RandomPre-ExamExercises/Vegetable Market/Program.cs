using System;

namespace Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());

            int kgOfVegetables = int.Parse(Console.ReadLine());
            int kgOfFruits = int.Parse(Console.ReadLine());

            double priceRateOfOneEur = 1.94;

            double revenue = (kgOfFruits * fruitPrice) + (kgOfVegetables * vegetablePrice);

            Console.WriteLine(revenue / 1.94);

        }
    }
}
