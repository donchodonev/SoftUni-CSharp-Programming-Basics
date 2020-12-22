using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double hall_rent = double.Parse(Console.ReadLine());
            double cake_price = hall_rent / 5;
            double drinks_price = cake_price * 0.55;
            double animator_price = hall_rent / 3;

            double total = hall_rent + cake_price + drinks_price + animator_price;

            Console.WriteLine(total);
        }
    }
}
