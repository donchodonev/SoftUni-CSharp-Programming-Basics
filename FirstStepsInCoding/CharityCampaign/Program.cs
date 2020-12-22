using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            double cake_price = 45.00;
            double waffle_price = 5.80;
            double pancake_price = 3.20;

            int campaign_days = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int cake_count = int.Parse(Console.ReadLine());
            int waffle_count = int.Parse(Console.ReadLine());
            int pancake_count = int.Parse(Console.ReadLine());

            double total_money_made = ((cake_count * cake_price) + (waffle_count * waffle_price) + (pancake_count * pancake_price)) * campaign_days * bakers;

            double donations = (total_money_made / 8) * 7;

            Console.WriteLine($"{donations:F2}");
        }
    }
}
