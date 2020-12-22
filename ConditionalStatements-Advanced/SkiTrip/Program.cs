using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine()) - 1;
            string typeOfRoom = Console.ReadLine();
            string rating = Console.ReadLine();
            double price = 0.0;
            double priceWithDiscount = 0.0;

            switch (typeOfRoom)
            {
                case "apartment":
                    price = 25.00;
                    break;
                case "president apartment":
                    price = 35.00;
                    break;
                case "room for one person":
                    price = 18.00;
                    break;
            }


            if (days < 10)
            {
                switch (typeOfRoom)
                {
                    case "room for one person":
                        break;
                        priceWithDiscount = price * days;
                    case "apartment":
                        priceWithDiscount = price * 0.70 * days;
                        break;
                    case "president apartment":
                        priceWithDiscount = price * 0.90 * days;
                        break;
                }
            }
            else if (days >= 10 && days <= 15)
            {
                switch (typeOfRoom)
                {
                    case "room for one person":
                        priceWithDiscount = price * days;
                        break;
                    case "apartment":
                        priceWithDiscount = price * 0.65 * days;
                        break;
                    case "president apartment":
                        priceWithDiscount = price * 0.8 * days;
                        break;
                }
            }
            else if (days > 15)
            {
                switch (typeOfRoom)
                {
                    case "room for one person":
                        priceWithDiscount = price * days;
                        break;
                    case "apartment":
                        priceWithDiscount = price * 0.5 * days;
                        break;
                    case "president apartment":
                        priceWithDiscount = price * 0.80 * days;
                        break;
                }
            }


            switch (rating)
            {
                case "positive":
                    Console.WriteLine($"{priceWithDiscount * 1.25:F2}");
                    break;
                case "negative":
                    Console.WriteLine($"{priceWithDiscount * 0.90:F2}");
                    break;
                default:
                    break;
            }
        }
    }
}
