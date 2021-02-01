using System;

namespace Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int rowConst = (4 * input) + 2;
            //first row logic
            for (int i = 1; i < rowConst; i++)
            {
                if (i == (rowConst / 2))
                {
                    Console.Write(@"/|\");
                }
                else if (i < (rowConst / 2) - 1)
                {
                    Console.Write(".");
                }
                else if (i > (rowConst / 2) + 1)
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
            //second row logic
            for (int k = 1; k < rowConst; k++)
            {
                if (k == (rowConst / 2))
                {
                    Console.Write(@"\|/");
                }
                else if (k < (rowConst / 2) - 1)
                {
                    Console.Write(".");
                }
                else if (k > (rowConst / 2) + 1)
                {
                    Console.Write(".");
                }
            }
            //third row logic

            for (int z = 0; z < input * 2; z++)
            {
                Console.WriteLine();
                Console.Write(new string('.', ((2 * input) - (1 + z))));
                Console.Write("*");
                Console.Write(new string('-', z));
                Console.Write("*");
                Console.Write(new string('-', z));
                Console.Write("*");
                Console.Write(new string('.', ((2 * input) - (1 + z))));
            }
            Console.WriteLine();
            Console.WriteLine(new string('*', (4 * input) + 1));
            for (int i = 0; i <= 4 * input; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
            Console.WriteLine(new string('*', (4 * input) + 1));
        }
    }
}
