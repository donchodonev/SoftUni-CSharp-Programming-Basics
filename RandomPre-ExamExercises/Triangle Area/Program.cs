using System;

namespace Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());

            double triangleBase = x2 - x3;
            double triangleHeight = y2 - y1;
            double triangleArea = triangleBase * (triangleHeight / 2);

            Console.WriteLine(triangleArea);
        }
    }
}
