using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNum = int.MinValue;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Stop")
                {
                    Console.WriteLine(maxNum);
                    break;
                }
                if (maxNum < int.Parse(input))
                {
                    maxNum = int.Parse(input);
                }
            }
        }
    }
}
