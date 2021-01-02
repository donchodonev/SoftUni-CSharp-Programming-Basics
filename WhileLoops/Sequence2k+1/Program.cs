using System;

namespace Sequence2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int one = 1;
            while (input >= one)
            {
                Console.WriteLine(one);
                one = one * 2 + 1;
            }
        }
    }
}
