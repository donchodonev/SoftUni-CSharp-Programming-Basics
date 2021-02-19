using System;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine()) * 100;
            var width = double.Parse(Console.ReadLine()) * 100;

            width = Math.Truncate((width - 100) / 70);
            length = Math.Truncate((length / 120));

            double seats = width * length - 3;
            Console.WriteLine(seats);
        }
    }
}
