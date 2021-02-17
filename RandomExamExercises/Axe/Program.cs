using System;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 5 * n;
            int leftDashes = 3 * n;
            int middleDashes = 0;
            int rightDashes = width - leftDashes - middleDashes - 2;

            //top rows
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string ('-', leftDashes));
                Console.Write('*');
                Console.Write(new string('-', middleDashes));
                Console.Write('*');
                Console.Write(new string('-', rightDashes));
                Console.WriteLine();
                if (i != n)
                {
                    middleDashes++;
                    rightDashes--;
                }
            }

            //middle rows
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('*', leftDashes));
                Console.Write('*');
                Console.Write(new string('-', middleDashes));
                Console.Write('*');
                Console.Write(new string('-', rightDashes));
                Console.WriteLine();
            }
            //bottom part rows
            for (int i = 1; i <= (n / 2) - 1 ; i++)
            {
                Console.Write(new string('-', leftDashes));
                Console.Write('*');
                Console.Write(new string('-', middleDashes));
                Console.Write('*');
                Console.Write(new string('-', rightDashes));
                Console.WriteLine();
                if (i != n)
                {
                    middleDashes+=2;
                    rightDashes--;
                    leftDashes--;
                }
            }
            //final row
            Console.Write(new string('-', leftDashes));
            Console.Write('*');
            Console.Write(new string('*', middleDashes));
            Console.Write('*');
            Console.Write(new string('-', rightDashes));
        }
    }
}
