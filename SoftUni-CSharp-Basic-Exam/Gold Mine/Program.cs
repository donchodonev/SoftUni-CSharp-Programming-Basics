using System;

namespace Gold_Mine
{
    class Program
    {
        static void Main(string[] args)
        {
            int locations = int.Parse(Console.ReadLine());

            for (int i = 0; i < locations; i++)
            {
                double expectedAvg = double.Parse(Console.ReadLine());
                int daysDigging = int.Parse(Console.ReadLine());

                double diggingOutput = 0;

                for (int k = 0; k < daysDigging; k++)
                {
                    diggingOutput += double.Parse(Console.ReadLine());
                }

                double avgOutput = diggingOutput / daysDigging;

                if (avgOutput >= expectedAvg)
                {
                    Console.WriteLine($"Good job! Average gold per day: {avgOutput:F2}.");
                }
                else
                {
                    Console.WriteLine($"You need {expectedAvg - avgOutput:F2} gold.");
                }
            }
        }
    }
}
