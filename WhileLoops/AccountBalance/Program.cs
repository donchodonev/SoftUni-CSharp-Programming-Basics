using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0.0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "NoMoreMoney")
                {
                    Console.WriteLine($"Total: {total:F2}");
                    break;
                }
                else if (double.Parse(input) < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {total:F2}");
                    break;
                }
                else
                {
                    double increase = double.Parse(input);
                    Console.WriteLine($"Increase: {increase:F2}");
                    total += increase;
                }
            }
        }
    }
}
