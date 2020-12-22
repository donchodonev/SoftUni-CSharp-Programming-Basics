using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double avgScore = double.Parse(Console.ReadLine());
            double minWage = double.Parse(Console.ReadLine());

            if (income > minWage && avgScore < 5.5 || income < minWage && avgScore < 4.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

            if (avgScore >= 5.5 && income < minWage)
            {
                if (Math.Floor(minWage * 0.35) > Math.Floor(avgScore * 25))
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(minWage * 0.35)} BGN");
                }
                else if (Math.Floor(minWage * 0.35) == Math.Floor(avgScore * 25))
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(avgScore * 25)} BGN");
                }
                else if (Math.Floor(minWage * 0.35) < Math.Floor(avgScore * 25))
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(avgScore * 25)} BGN");
                }
            }

            if (income < minWage && avgScore > 4.5 && avgScore < 5.5)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(minWage * 0.35)} BGN");
            }

            if (avgScore >= 5.5 && income >= minWage)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(avgScore * 25)} BGN");
            }
        }
    }
}
