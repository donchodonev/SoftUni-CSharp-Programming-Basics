using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int readCount = int.Parse(Console.ReadLine());
            double under2h = 0.0;
            double b2hu400 = 0.0;
            double b4hu600 = 0.0;
            double b6hu800 = 0.0;
            double above800 = 0.0;

            for (int i = 0; i < readCount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    under2h++;
                }
                else if (number >= 200 && number < 400)
                {
                    b2hu400++;
                }
                else if (number >= 400 && number < 600)
                {
                    b4hu600++;
                }
                else if (number >= 600 && number < 800)
                {
                    b6hu800++;
                }
                else
                {
                    above800++;
                }
            }

            Console.WriteLine($"{(under2h / readCount) * 100:F2}%");
            Console.WriteLine($"{(b2hu400 / readCount) * 100:F2}%");
            Console.WriteLine($"{(b4hu600 / readCount) * 100:F2}%");
            Console.WriteLine($"{(b6hu800 / readCount) * 100:F2}%");
            Console.WriteLine($"{(above800 / readCount) * 100:F2}%");
        }
    }
}
