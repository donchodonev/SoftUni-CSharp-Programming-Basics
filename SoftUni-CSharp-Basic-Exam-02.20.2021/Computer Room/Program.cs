using System;

namespace Computer_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int hours = int.Parse(Console.ReadLine());
            int peopleInGroup = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            double pricePerHour = 0;

            if ((month == "march" || month == "april" || month == "may") && timeOfDay == "day")
            {
                pricePerHour += 10.50;
            }
            else if ((month == "march" || month == "april" || month == "may") && timeOfDay == "night")
            {
                pricePerHour += 8.40;
            }
            else if ((month == "june" || month == "july" || month == "august") && timeOfDay == "day")
            {
                pricePerHour += 12.60;
            }
            else if ((month == "june" || month == "july" || month == "august") && timeOfDay == "night")
            {
                pricePerHour += 10.20;
            }

            if (peopleInGroup >= 4)
            {
                pricePerHour *= 0.90;
            }
            if (hours >= 5)
            {
                pricePerHour *= 0.50;
            }

            double totalPrice = (pricePerHour * peopleInGroup) * hours;

            Console.WriteLine($"Price per person for one hour: {pricePerHour:F2}");
            Console.WriteLine($"Total cost of the visit: {totalPrice:F2}");


        }
    }
}
