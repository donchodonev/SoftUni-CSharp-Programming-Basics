using System;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string('*',n*2));
            Console.Write(new string(' ',n));
            Console.Write(new string('*', n * 2));
            Console.WriteLine();

            for (int i = 1; i <= n-2; i++)
            {
                Console.Write("*");
                Console.Write(new string('/', (n * 2) - 2));
                Console.Write("*");
                if (i == n / 2 && n % 2 != 0)
                {
                    Console.Write(new string('|',n));
                }
                else if (i == (n / 2) - 1 && n % 2 == 0)
                {
                    Console.Write(new string('|', n));
                }
                else
                {
                    Console.Write(new string(' ', n));
                }
                Console.Write("*");
                Console.Write(new string('/', (n * 2) - 2));
                Console.Write("*");
                Console.WriteLine();
            }
            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.Write(new string('*', n * 2));
        }
    }
}
