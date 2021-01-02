using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int totalSpace = width * length * height;

            while (totalSpace > 0)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    Console.WriteLine($"{totalSpace} Cubic meters left.");
                    break;
                }
                else
                {
                    totalSpace -= int.Parse(input);
                    continue;
                }
            }
            if (totalSpace < 0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(totalSpace)} Cubic meters more.");
            }
        }
    }
}
