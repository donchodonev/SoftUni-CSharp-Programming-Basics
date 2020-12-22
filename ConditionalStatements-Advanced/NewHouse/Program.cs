using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double rosePrice = 5.00;
            double DahliasPrice = 3.80;
            double TulipsPrice = 2.80;
            double NarcissusPrice = 3.00;
            double GladiolusPrice = 2.50;

            double total = 0.0;


            if (flower == "Roses" && count > 80)
            {
                total = count * rosePrice * 0.90;
            }
            else if (flower == "Roses" && count <= 80)
            {
                total = count * rosePrice;
            }

            if (flower == "Dahlias" && count > 90)
            {
                total = count * DahliasPrice * 0.85;
            }
            else if (flower == "Dahlias" && count <= 90)
            {
                total = count * DahliasPrice;
            }

            if (flower == "Tulips" && count > 80)
            {
                total = count * TulipsPrice * 0.85;
            }
            else if (flower == "Tulips" && count <= 80)
            {
                total = count * TulipsPrice;
            }

            if (flower == "Narcissus" && count < 120)
            {
                total = count * NarcissusPrice * 1.15;
            }
            else if (flower == "Narcissus" && count >= 120)
            {
                total = count * NarcissusPrice;
            }

            if (flower == "Gladiolus" && count < 80)
            {
                total = count * GladiolusPrice * 1.20;
            }
            else if (flower == "Gladiolus" && count >= 80)
            {
                total = count * GladiolusPrice;
            }


            if (total > budget)
            {
                Console.WriteLine($"Not enough money, you need {total - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {flower} and {budget - total:f2} leva left.");
            }
        }
    }
}
