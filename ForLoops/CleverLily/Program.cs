using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double wmPrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());
            int toysCount = 0;
            double lilyMoney = 0.00;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                {
                    toysCount++;
                }
                else
                {
                    lilyMoney += (i / 2) * 10.00;
                }
            }

            lilyMoney += (toysCount * toysPrice) - (age / 2);

            if (wmPrice <= lilyMoney)
            {
                Console.WriteLine($"Yes! {lilyMoney - wmPrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {wmPrice - lilyMoney:f2}");

            }
        }
    }
}
