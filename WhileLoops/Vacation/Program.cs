using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneyAvailable = double.Parse(Console.ReadLine());
            int spendCounter = 0;
            int daysPassed = 0;

            while (spendCounter < 5)
            {
                daysPassed++;
                string action = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                if (action == "spend")
                {
                    spendCounter++;
                    if (sum >= moneyAvailable)
                    {
                        moneyAvailable = 0;
                    }
                    else
                    {
                        moneyAvailable -= sum;

                    }
                }
                else
                {
                    moneyAvailable += sum;
                    spendCounter = 0;
                }
                if (moneyAvailable >= moneyNeeded)
                {

                    break;
                }
            }

            if (moneyAvailable >= moneyNeeded && spendCounter < 5)
            {
                Console.WriteLine($"You saved the money for {daysPassed} days.");
            }
            if (spendCounter >= 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysPassed);
            }

        }
    }
}
