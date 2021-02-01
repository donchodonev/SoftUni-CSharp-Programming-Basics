using System;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                if (row == 1)
                {
                    Console.Write("+");
                }
                else if (row == n)
                {
                    Console.Write("+");
                }
                else
                {
                    Console.Write("|");
                }
                //loop for dashes

                for (int dashes = 1; dashes <= n - 2; dashes++)
                {

                    Console.Write(" -");
                }

                if (row == n)
                {
                    Console.Write(" +");
                }
                else if (row == 1)
                {
                    Console.Write(" +");
                }
                else
                {
                    Console.Write(" |");
                }
                Console.WriteLine();
            }
        }
    }
}
