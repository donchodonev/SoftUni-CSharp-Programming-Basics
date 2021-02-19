using System;

namespace Perfect_Diamond
{
    class Program
    {
        static void Main(string[] args)
         {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ',n-i));
                Console.Write("*");
                for (int k = 0; k < i-1; k++) // NOTE i - 1
                {
                    Console.Write("-*");
                }
                Console.Write(new string(' ', n - i));
                Console.WriteLine();
            }
            for (int i = n-1; i >= 1; i--)
            {
                Console.Write(new string(' ', n - i));
                Console.Write("*");
                for (int k = 0; k < i - 1; k++) // NOTE i - 1
                {
                    Console.Write("-*");
                }
                Console.Write(new string(' ', n - i));
                Console.WriteLine();
            }
        }
    }
}
