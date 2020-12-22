using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfProjection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double income = 0.0;

            switch (typeOfProjection)
            {
                case "Premiere":
                    income = 12.00 * (columns * rows);
                    Console.WriteLine($"{income:f2} leva");
                    break;
                case "Normal":
                    income = 7.50 * (columns * rows);
                    Console.WriteLine($"{income:f2} leva");
                    break;
                case "Discount":
                    income = 5.00 * (columns * rows);
                    Console.WriteLine($"{income:f2} leva");
                    break;
                default:
                    break;
            }
        }
    }
}
