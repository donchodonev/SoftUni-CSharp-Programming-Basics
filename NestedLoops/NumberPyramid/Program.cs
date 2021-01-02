using System;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNum = int.Parse(Console.ReadLine());
            int counter = 1;
            for (int row = 1; row <= endNum; row++)
            {
                for (int col = 1; col <= row && counter <= endNum; col++)
                {
                    Console.Write(counter + " ");
                    counter++;
                }
                Console.WriteLine();
            }
        }
    }
}
