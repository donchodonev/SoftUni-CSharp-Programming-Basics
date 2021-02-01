using System;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftRight = (n - 1) / 2;
            for (int i = 1; i <= (n - 1) / 2; i++)
            {
                // Draw the top part
                Console.Write(new string('-', leftRight));
                Console.Write("*");
                int mid = n - 2 * leftRight - 2;
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.WriteLine(new string('-', leftRight));
                leftRight--;
            }


            for (int i = 0; i <= (n - 1) / 2; i++)
            {
                //Draw the bottom part
                Console.Write(new string('-', leftRight));
                Console.Write("*");
                int mid = n - 2 * leftRight - 2;
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.WriteLine(new string('-', leftRight));
                leftRight++;
            }
        }
    }
}
