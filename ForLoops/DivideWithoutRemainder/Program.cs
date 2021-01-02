using System;

namespace DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int readCount = int.Parse(Console.ReadLine());
            double two = 0.0;
            double three = 0.0;
            double four = 0.0;

            for (int i = 0; i < readCount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    two++;
                }
                if (number % 3 == 0)
                {
                    three++;
                }
                if (number % 4 == 0)
                {
                    four++;
                }

            }

            Console.WriteLine($"{(two / readCount) * 100:F2}%");
            Console.WriteLine($"{(three / readCount) * 100:F2}%");
            Console.WriteLine($"{(four / readCount) * 100:F2}%");
        }
    }
}
