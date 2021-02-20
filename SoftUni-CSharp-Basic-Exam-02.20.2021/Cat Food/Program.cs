using System;

namespace Cat_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int catCount = int.Parse(Console.ReadLine());

            int group1Cats = 0;
            int group2Cats = 0;
            int group3Cats = 0;
            double totalFoodInGr = 0.0;
            for (int i = 0; i < catCount; i++)
            {
                double gramsOfFood = double.Parse(Console.ReadLine());

                if (gramsOfFood >= 100.0 && gramsOfFood < 200.0)
                {
                    group1Cats++;
                    totalFoodInGr += gramsOfFood;
                }
                else if (gramsOfFood >= 200.0 && gramsOfFood < 300.0)
                {
                    group2Cats++;
                    totalFoodInGr += gramsOfFood;
                }
                else
                {
                    group3Cats++;
                    totalFoodInGr += gramsOfFood;
                }
            }

            double totalFoodInKg = totalFoodInGr / 1000;
            double priceForFoodPerDay = totalFoodInKg * 12.45;

            Console.WriteLine($"Group 1: {group1Cats} cats.");
            Console.WriteLine($"Group 2: {group2Cats} cats.");
            Console.WriteLine($"Group 3: {group3Cats} cats.");
            Console.WriteLine($"Price for food per day: {priceForFoodPerDay:F2} lv.");
        }
    }
}
