using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int maxNumber = -2147483648;
            int minNumber = 2147483647;

            for (int i = 0; i < numberCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                maxNumber = Math.Max(maxNumber, number);
                minNumber = Math.Min(minNumber, number);
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
