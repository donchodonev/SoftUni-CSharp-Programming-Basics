using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNum = int.MinValue;
            for (int i = 0; i < numbers; i++)
            {
                int numRead = int.Parse(Console.ReadLine());
                sum += numRead;
                if (numRead > maxNum)
                {
                    maxNum = numRead;
                }
            }
            if (sum - maxNum == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNum - (sum - maxNum))}");
            }
        }
    }
}
