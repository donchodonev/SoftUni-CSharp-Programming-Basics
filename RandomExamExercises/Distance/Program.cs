using System;

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal kmPerHour = decimal.Parse(Console.ReadLine());
            decimal firstTimeInMin = decimal.Parse(Console.ReadLine());
            decimal secondTimeInMin = decimal.Parse(Console.ReadLine());
            decimal thirdTimeInMin = decimal.Parse(Console.ReadLine());

            decimal kmPerHourAfterFirstChangeInSpeed = kmPerHour * 1.10M;
            decimal kmPerHourAfterSecondChangeInSpeed = kmPerHourAfterFirstChangeInSpeed * 0.95M;

            decimal firstTimeCalc = kmPerHour * (firstTimeInMin / 60.00M);
            decimal secondTimeCalc = kmPerHourAfterFirstChangeInSpeed * (secondTimeInMin / 60.00M);
            decimal thirdTimeCalc = kmPerHourAfterSecondChangeInSpeed * (thirdTimeInMin / 60.00M);

            decimal totalKmTravelled = (firstTimeCalc + secondTimeCalc + thirdTimeCalc);

            Console.WriteLine($"{totalKmTravelled:F2}");

        }
    }
}
