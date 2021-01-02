using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());

            int coins = 0;
            while (money > 0.00)
            {
                money = Math.Round(money, 2);

                if (money - 2 >= 0.00)
                {
                    coins++;
                    money -= 2.00;
                    continue;
                }
                else if (money - 1 >= 0.00)
                {
                    coins++;
                    money -= 1.00;
                    continue;
                }
                else if (money - 0.50 >= 0.00)
                {
                    coins++;
                    money -= 0.50;
                    continue;
                }
                else if (money - 0.20 >= 0.00)
                {
                    coins++;
                    money -= 0.20;
                    continue;
                }
                else if (money - 0.10 >= 0.00)
                {
                    coins++;
                    money -= 0.10;
                    continue;
                }
                else if (money - 0.05 >= 0.00)
                {
                    coins++;
                    money -= 0.05;
                    continue;
                }
                else if (money - 0.02 >= 0.00)
                {
                    coins++;
                    money -= 0.02;
                    continue;
                }
                else if (money - 0.01 == 0.00)
                {
                    coins++;
                    money -= 0.01;
                    continue;
                }
            }
            Console.WriteLine(coins);
        }
    }
}
