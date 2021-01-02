using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeSum = 0;
            int nonPrimeSum = 0;

            while (true)
            {
                string input = (Console.ReadLine());
                if (input == "stop")
                {
                    break;
                }
                //
                int numInput = int.Parse(input);
                if (numInput < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                else if (numInput == 2)
                {
                    primeSum += numInput;
                    continue;
                }
                else if (numInput == 1 || numInput % 2 == 0)
                {
                    nonPrimeSum += numInput;
                    continue;
                }
                for (int i = 3; i <= numInput; i += 2)
                {
                    if (numInput % i == 0 && i != numInput)
                    {
                        nonPrimeSum += numInput;
                        break;
                    }
                    else if (numInput % i == 0 && i == numInput)
                    {
                        primeSum += numInput;
                    }
                }
                continue;
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
