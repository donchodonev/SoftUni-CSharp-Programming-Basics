using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int leftSideSum = 0;
            int rightSideSum = 0;

            for (int i = 1; i <= numberCount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    leftSideSum += number;
                }
                else
                {
                    rightSideSum += number;
                }
            }

            if (leftSideSum == rightSideSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {leftSideSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(rightSideSum - leftSideSum)}");
            }
        }
    }
}
