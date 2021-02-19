using System;

namespace Arrow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bottomRowDotCount = ((n - 2) * 2) - 1;
            //top row
            Console.Write(new string('.', n / 2));
            Console.Write(new string('#', n));
            Console.Write(new string('.', n / 2));
            Console.WriteLine();
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(new string('.', n / 2));
                Console.Write('#');
                Console.Write(new string('.', n - 2));
                Console.Write('#');
                Console.Write(new string('.', n / 2));
                Console.WriteLine();
            }
            //draw middle row
            Console.Write(new string('#', (n + 1) / 2));
            Console.Write(new string('.', n - 2));
            Console.Write(new string('#', (n + 1) / 2));
            Console.WriteLine();
            //bottom row
            for (int i = 1; i < n; i++)
            {
                Console.Write(new string('.', i));
                Console.Write('#');
                //dumb solution for a dumb problem
                if (bottomRowDotCount > 0)
                {
                    Console.Write(new string('.', bottomRowDotCount));
                    Console.Write('#');
                }
                //dumb solution for a dumb problem
                Console.Write(new string('.', i));
                Console.WriteLine();
                bottomRowDotCount -= 2;
            }
        }
    }
}
