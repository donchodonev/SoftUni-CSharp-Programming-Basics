using System;

namespace Odd_EvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterator = int.Parse(Console.ReadLine());
            double oddSum = 0.00;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0.00;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;


            for (int i = 1; i <= iterator; i++)
            {
                double number = double.Parse(Console.ReadLine());
                //even
                if (i % 2 == 0)
                {
                    evenSum += number;
                    if (number > evenMax)
                    {
                        evenMax = number;
                    }
                    if (number < evenMin)
                    {
                        evenMin = number;
                    }
                }
                //odd
                if (i % 2.0 != 0.0)
                {
                    oddSum += number;
                    if (number > oddMax)
                    {
                        oddMax = number;
                    }
                    if (number < oddMin)
                    {
                        oddMin = number;
                    }
                }
            }

            if (iterator < 1)
            {
                Console.WriteLine("OddSum=0.00,");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine("EvenSum=0.00,");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }

            if (iterator == 1)
            {
                Console.WriteLine($"OddSum={oddSum:F2},");
                Console.WriteLine($"OddMin={oddMin:F2},");
                Console.WriteLine($"OddMax={oddMax:F2},");
                Console.WriteLine("EvenSum=0.00,");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            if (iterator > 1)
            {
                Console.WriteLine($"OddSum={oddSum:F2},");
                Console.WriteLine($"OddMin={oddMin:F2},");
                Console.WriteLine($"OddMax={oddMax:F2},");
                Console.WriteLine($"EvenSum={evenSum:F2},");
                Console.WriteLine($"EvenMin={evenMin:F2},");
                Console.WriteLine($"EvenMax={evenMax:F2}");
            }
        }
    }
}
