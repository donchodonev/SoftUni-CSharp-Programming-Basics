using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int maxNum = int.MaxValue;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Stop")
                {
                    Console.WriteLine(maxNum);
                    break;
                }
                if (maxNum > int.Parse(input))
                {
                    maxNum = int.Parse(input);
                }
            }
        }
    }
}
