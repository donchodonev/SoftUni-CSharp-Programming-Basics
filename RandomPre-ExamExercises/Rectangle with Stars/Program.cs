using System;

namespace Rectangle_with_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int side = 0;
            if (n % 2 != 0)
            {
                side = n;
            }
            else
            {
                side = n - 1;
            }
            Console.Write(new string('%', n * 2));
            Console.WriteLine();
            for (int i = 1; i <= side; i++)
            {
                Console.Write("%");
                if (i == (side / 2) + 1)
                {
                    Console.Write(new string(' ', n - 2));
                    Console.Write("**");
                    Console.Write(new string(' ', n - 2));

                }
                else
                {
                    Console.Write(new string(' ', (n * 2) - 2));
                }
                Console.Write("%");
                Console.WriteLine();
            }
            Console.Write(new string('%', n * 2));
        }
    }
}
