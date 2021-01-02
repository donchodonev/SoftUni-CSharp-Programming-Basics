using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;
            int steps = 0;
            while (steps < goal)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    steps += int.Parse(Console.ReadLine());
                    break;
                }
                else
                {
                    steps += int.Parse(input);
                }
            }
            if (steps >= goal)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{steps - goal} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{goal - steps} more steps to reach goal.");
            }
        }
    }
}
