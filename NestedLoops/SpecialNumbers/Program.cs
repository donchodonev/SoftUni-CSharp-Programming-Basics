using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int trueCounter = 0;

            for (int i = 1111; i < 9999; i++)
            {
                string numToString = Convert.ToString(i);
                for (int k = 0; k < numToString.Length; k++)
                {
                    int stringToDigit = int.Parse(numToString[k].ToString());
                    if (stringToDigit == 0)
                    {
                        continue;
                    }
                    if (number % stringToDigit == 0)
                    {
                        trueCounter++;
                    }
                }
                if (trueCounter == 4)
                {
                    Console.Write(i + " ");
                }
                trueCounter = 0;
            }
        }
    }
}
