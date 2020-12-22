using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double clutter_percent = double.Parse(Console.ReadLine());

            int max_volume = length * width * height;

            double real_volume = (max_volume / 1000.00) - ((max_volume / 1000.00) / 100) * clutter_percent;

            Console.WriteLine("{0:F3}", real_volume);
        }
    }
}
