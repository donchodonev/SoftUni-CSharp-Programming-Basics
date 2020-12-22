using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double pricePerNightInStudio = 0.0;
            double pricePerNightInApartment = 0.0;

            if (month == "May" || month == "October")
            {
                pricePerNightInStudio = 50.00;

                if (days > 7 && days <= 14)
                {
                    pricePerNightInStudio = (pricePerNightInStudio / 100) * 95;
                }
                else if (days > 14)
                {
                    pricePerNightInStudio = (pricePerNightInStudio / 100) * 70;
                }
            }
            else if (month == "June" || month == "September")
            {
                pricePerNightInStudio = 75.20;
                if (days > 14)
                {
                    pricePerNightInStudio = (pricePerNightInStudio / 100) * 80;
                }
            }
            else
            {
                pricePerNightInStudio = 76.00;
            }
            if (month == "May" || month == "October")
            {
                pricePerNightInApartment = 65.00;
            }
            else if (month == "June" || month == "September")
            {
                pricePerNightInApartment = 68.70;
            }
            else
            {
                pricePerNightInApartment = 77.00;
            }
            if (days > 14)
            {
                pricePerNightInApartment = (pricePerNightInApartment / 100) * 90;
            }
            Console.WriteLine($"Apartment: {days * pricePerNightInApartment:f2} lv.");
            Console.WriteLine($"Studio: {days * pricePerNightInStudio:f2} lv.");
        }
    }
}
