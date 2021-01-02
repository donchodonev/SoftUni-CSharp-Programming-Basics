using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine()) * 2;
            int leftSideSum = 0;
            int rightSideSum = 0;

            for (int i = 0; i < numberCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i * 2 >= numberCount)
                {
                    rightSideSum += number;
                }
                else
                {
                    leftSideSum += number;
                }
            }

            if (leftSideSum == rightSideSum)
            {
                Console.WriteLine($"Yes, sum = {leftSideSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSideSum - rightSideSum)}");
            }
        }
    }
}
