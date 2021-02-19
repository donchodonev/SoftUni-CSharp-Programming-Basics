using System;

namespace Daily_Earnings
{
    class Program
    {
        static void Main(string[] args)
        {
            int workingDaysPerMonth = int.Parse(Console.ReadLine());
            double payPerDay = double.Parse(Console.ReadLine());
            double dollarToLevRatio = double.Parse(Console.ReadLine());
            double monthlySalary = workingDaysPerMonth * payPerDay;
            double payPerYear = (monthlySalary * 12) + (monthlySalary * 2.5);
            double totalPayPerYearAfterTax = payPerYear * 0.75;

            Console.WriteLine($"{(totalPayPerYearAfterTax / 365) * dollarToLevRatio:F2}");
        }
    }
}
