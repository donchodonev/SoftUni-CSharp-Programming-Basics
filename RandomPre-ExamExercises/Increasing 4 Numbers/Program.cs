using System;

namespace Increasing_4_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNum = int.Parse(Console.ReadLine());
            int maxNum = int.Parse(Console.ReadLine());

            if (maxNum - minNum < 3)
            {
                Console.WriteLine("no");
            }
            else
            {
                for (int firstNum = minNum; firstNum <= maxNum - 3; firstNum++)
                {
                    for (int secondNum = firstNum + 1; secondNum <= maxNum - 2; secondNum++)
                    {
                        for (int thirdNum = secondNum + 1; thirdNum <= maxNum - 1; thirdNum++)
                        {
                            for (int fourthNum = thirdNum + 1; fourthNum <= maxNum; fourthNum++)
                            {
                                Console.WriteLine($"{firstNum} {secondNum} {thirdNum} {fourthNum}");
                            }
                        }
                    }
                }
            }
        }
    }
}
