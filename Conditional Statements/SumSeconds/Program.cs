using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int totalTime = firstTime + secondTime + thirdTime;
            int totalMinutes = totalTime / 60;
            int leftSeconds = totalTime % 60;


            if (leftSeconds < 10)
            {
                Console.WriteLine($"{totalMinutes}:0{ leftSeconds}");
            }
            else
            {
                Console.WriteLine($"{totalMinutes}:{ leftSeconds}");
            }
        }
    }
}
