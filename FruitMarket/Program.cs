using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //prices
            double strawberry_price_per_kilo = double.Parse(Console.ReadLine());
            double raspberrie_price_per_kilo = strawberry_price_per_kilo / 2;
            double orange_price_per_kilo = raspberrie_price_per_kilo * 0.60;
            double bananas_price_per_kilo = raspberrie_price_per_kilo * 0.20;

            //quantities in kg
            double bananas = double.Parse(Console.ReadLine());
            double oranges = double.Parse(Console.ReadLine());
            double raspberries = double.Parse(Console.ReadLine());
            double strawberries = double.Parse(Console.ReadLine());

            double total_expenses = (

                (bananas * bananas_price_per_kilo)
                +
                (oranges * orange_price_per_kilo)
                +
                (raspberries * raspberrie_price_per_kilo)
                +
                (strawberries * strawberry_price_per_kilo)

                );

            Console.WriteLine($"{total_expenses:F2}");
        }
    }
}
