﻿using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double bonus = 0.0;
            if (number <= 100)
            {
                bonus = 5.0;
            }
            else if (number < 1000)
            {
                bonus = number * 0.20;
            }
            else if (number > 1000)
            {
                bonus = number * 0.10;
            }

            if (number % 2 == 0)
            {
                bonus++;
            }
            else if (number % 5 == 0)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(number + bonus);
        }
    }
}
