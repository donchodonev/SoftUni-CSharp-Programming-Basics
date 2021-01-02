using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int combCount = 0;
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int i = 0;
            int j = 0;
            int n1 = 0;
            int n2 = 0;
            bool isMagicNumFound = false;

            for (i = startNum; i <= endNum; i++)
            {
                for (j = startNum; j <= endNum; j++)
                {
                    combCount++;
                    if (i + j == magicNum)
                    {
                        n1 = i;
                        n2 = j;
                        isMagicNumFound = true;
                        break;
                    }
                }
                if (isMagicNumFound)
                {
                    break;
                }
            }
            if (isMagicNumFound)
            {
                Console.WriteLine($"Combination N:{combCount} ({i} + {j} = {magicNum})");
            }
            else
            {
                Console.WriteLine($"{combCount} combinations - neither equals {magicNum}");
            }
        }
    }
}
