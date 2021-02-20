using System;

namespace Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            double averageSpeed = double.Parse(Console.ReadLine());
            double litersOfFuelPer100Km = double.Parse(Console.ReadLine());

            double distanceToMoonAndBack = 384400.00 * 2.00;

            double timeToTheMoon = (distanceToMoonAndBack / averageSpeed);
            double fuelUsed = (litersOfFuelPer100Km * distanceToMoonAndBack) / 100;

            Console.WriteLine($"{Math.Ceiling(timeToTheMoon + 3)}");
            Console.WriteLine($"{Math.Round(fuelUsed)}");
        }
    }
}
