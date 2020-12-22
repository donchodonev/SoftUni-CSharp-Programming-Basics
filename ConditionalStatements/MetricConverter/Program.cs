using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double realNum = double.Parse(Console.ReadLine());
            string inMetric = Console.ReadLine();
            string outMetric = Console.ReadLine();


            if (inMetric == "mm")
            {
                if (outMetric == "cm")
                {
                    realNum = realNum / 10;
                }
                else if (outMetric == "m")
                {
                    realNum = realNum / 1000;
                }
            }

            if (inMetric == "cm")
            {
                if (outMetric == "mm")
                {
                    realNum = realNum * 10;
                }
                else if (outMetric == "m")
                {
                    realNum = realNum / 100;
                }
            }

            if (inMetric == "m")
            {
                if (outMetric == "cm")
                {
                    realNum = realNum * 100;
                }
                else if (outMetric == "mm")
                {
                    realNum = realNum * 1000;
                }
            }

            Console.WriteLine($"{realNum:f3}");

        }
    }
}
