using System;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(new string(' ', n + 1));
            Console.Write(("|"));
            Console.Write(new string(' ', n));
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', n - i -1));
                Console.Write(new string('*',i + 1));
                Console.Write(" | ");
                Console.Write(new string('*', i + 1));
                Console.Write(new string(' ', n - i - 1));
                Console.WriteLine();
            }
        }
    }
}
