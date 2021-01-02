using System;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            //numbers seed
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            //interate between two numbers
            for (int i = num1; i <= num2; i++)
            {
                //get a string for each number
                string num1String = i.ToString();
                int evenSum = 0;
                int oddSum = 0;
                //go through each number's digits
                for (int J = 0; J < num1String.Length; J++)
                {
                    //get digit's value
                    int currentNumber = int.Parse(num1String[J].ToString());
                    //check if digit's value is in an even or odd number position in num1
                    if (J % 2 == 0)
                    {
                        evenSum += currentNumber;
                    }
                    else
                    {
                        oddSum += currentNumber;
                    }
                }
                //print num1 if the value of it's even and odd positions' numbers value is even
                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
