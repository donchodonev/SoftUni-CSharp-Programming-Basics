using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            int budgetNeeded = 0;
            int budgetAvailable = 0;
            string destination = "";
            bool noEnd = true;
            string input = "";

            while (noEnd)
            {
                destination = Console.ReadLine();
                if (destination == "End")
                {
                    noEnd = false;
                    break;
                }
                else
                {
                    budgetNeeded = int.Parse(Console.ReadLine());
                    while (budgetAvailable < budgetNeeded)
                    {
                        input = Console.ReadLine();
                        if (input == "End")
                        {
                            noEnd = false;
                            break;
                        }
                        budgetAvailable += int.Parse(input);
                    }
                    if (input != "End")
                    {
                        Console.WriteLine($"Going to {destination}!");
                        budgetAvailable = 0;
                    }
                }
            }
        }
    }
}
