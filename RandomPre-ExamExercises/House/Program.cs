using System;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0) // when n is divisable by 2
            {
                int dashCounter = (n - 2) / 2;
                //upper part
                for (int i = 2; i <= n; i+=2)
                {
                    Console.Write(new string('-', dashCounter));
                    Console.Write(new string('*', i));
                    Console.Write(new string('-', dashCounter));
                    Console.WriteLine();
                    dashCounter--;
                }
                //bottom part
                for (int i = 1; i <= n/2; i++)
                {
                    Console.Write(new string('|', 1));
                    Console.Write(new string('*', ((n/2) - 1) * 2));
                    Console.Write(new string('|', 1));
                    Console.WriteLine();
                }
            }
            else // when n is not divisable by 2
            {
                int dashCounter = (n - 1) / 2;
                //upper part
                for (int i = 1; i <= n; i += 2)
                {
                    Console.Write(new string('-', dashCounter));
                    Console.Write(new string('*', i));
                    Console.Write(new string('-', dashCounter));
                    Console.WriteLine();
                    dashCounter--;
                }
                //bottom part
                for (int i = 1; i <= n / 2; i++)
                {
                    Console.Write(new string('|', 1));
                    Console.Write(new string('*', (n - 2)));
                    Console.Write(new string('|', 1));
                    Console.WriteLine();
                }
            }
        }
    }
}
