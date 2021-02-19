using System;

namespace Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int midPartSize = (2 * n) - (2 * (n / 2)) - 4;
            //top part
            Console.Write("/");
            Console.Write(new string('^', n / 2));
            Console.Write("\\");
            Console.Write(new string('_', midPartSize));
            Console.Write("/");
            Console.Write(new string('^', n / 2));
            Console.Write("\\");
            Console.WriteLine();
            //mid part
            for (int i = 0; i <= n - 4; i++)
            {
                Console.Write('|');
                Console.Write(new string(' ', (n * 2) - 2));
                Console.Write('|');
                Console.WriteLine();
            }
            //2nd to past part
            Console.Write('|');
            Console.Write(new string(' ', (n / 2 + 1)));
            Console.Write(new string('_', midPartSize));
            Console.Write(new string(' ', (n / 2 + 1)));
            Console.Write('|');
            Console.WriteLine();
            //bottom part
            Console.Write("\\");
            Console.Write(new string('_', n / 2));
            Console.Write("/");
            Console.Write(new string(' ', midPartSize));
            Console.Write("\\");
            Console.Write(new string('_', n / 2));
            Console.Write("/");
        }
    }
}
