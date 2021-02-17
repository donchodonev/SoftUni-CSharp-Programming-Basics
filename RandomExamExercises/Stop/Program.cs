using System;

namespace Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int lowerDashCount = (n * 2) - 1;

            //top row
            Console.Write(new string('.', n + 1));
            Console.Write(new string('_', (n * 2) + 1));
            Console.Write(new string('.', n + 1));
            Console.WriteLine();
            //upper row
            for (int i = n; i > 0; i--)
            {
                Console.Write(new string('.', i));
                Console.Write("//");
                Console.Write(new string('_', lowerDashCount));
                Console.Write("\\\\");
                Console.Write(new string('.', i));
                Console.WriteLine();
                lowerDashCount += 2;
            }
            //mid row
            Console.Write("//");
            Console.Write(new string('_', (n * 2) - 3));
            Console.Write("STOP!");
            Console.Write(new string('_', (n * 2) - 3));
            Console.Write("\\\\");
            Console.WriteLine();
            //bottom row

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', i));
                Console.Write("\\\\");
                Console.Write(new string('_', lowerDashCount));
                Console.Write("//");
                Console.Write(new string('.', i));
                Console.WriteLine();
                lowerDashCount -= 2;
            }
        }
    }
}
