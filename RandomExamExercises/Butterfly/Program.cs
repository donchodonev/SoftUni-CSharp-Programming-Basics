using System;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //top part
            for (int i = 1; i < n-1; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(new string('*', n - 2));
                    Console.Write('\\');
                    Console.Write(' ');
                    Console.Write('/');
                    Console.Write(new string('*', n - 2));
                }
                else
                {
                    Console.Write(new string('-', n - 2));
                    Console.Write('\\');
                    Console.Write(' ');
                    Console.Write('/');
                    Console.Write(new string('-', n - 2));
                }
                Console.WriteLine();
            }
            //mid part

            Console.Write(new string(' ', n-1));
            Console.Write('@');
            Console.Write(new string(' ', n - 1));
            Console.WriteLine();
            //bottom part

            for (int i = 1; i < n - 1; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(new string('*', n - 2));
                    Console.Write('/');
                    Console.Write(' ');
                    Console.Write('\\');
                    Console.Write(new string('*', n - 2));
                }
                else
                {
                    Console.Write(new string('-', n - 2));
                    Console.Write('/');
                    Console.Write(' ');
                    Console.Write('\\');
                    Console.Write(new string('-', n - 2));
                }
                Console.WriteLine();
            }
        }
    }
}
