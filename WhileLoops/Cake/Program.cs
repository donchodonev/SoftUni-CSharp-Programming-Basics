using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeSize = int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine());
            int piecesTaken = 0;
            while (cakeSize > piecesTaken)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    Console.WriteLine($"{cakeSize - piecesTaken} pieces are left.");
                    break;
                }
                piecesTaken += int.Parse(input);
                if (piecesTaken > cakeSize)
                {
                    Console.WriteLine($"No more cake left! You need {piecesTaken - cakeSize} pieces more.");
                    break;
                }
            }
        }
    }
}
