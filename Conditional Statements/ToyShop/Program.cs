using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {

            double puzzle_price = 2.60;
            double doll_price = 3.00;
            double bear_price = 4.10;
            double minion_price = 8.20;
            double truck_price = 2.00;


            double trip_price = double.Parse(Console.ReadLine());

            int puzzle_count = int.Parse(Console.ReadLine());
            int doll_count = int.Parse(Console.ReadLine());
            int bear_count = int.Parse(Console.ReadLine());
            int minion_count = int.Parse(Console.ReadLine());
            int truck_count = int.Parse(Console.ReadLine());
            int total_count = puzzle_count + doll_count + bear_count + minion_count + truck_count;

            double purchase_made =

                (puzzle_count * puzzle_price)
                +
                (doll_count * doll_price)
                +
                (bear_count * bear_price)
                +
                (minion_count * minion_price)
                +
                (truck_count * truck_price)
                ;

            if (total_count >= 50)
            {
                purchase_made = purchase_made * 0.75;
                purchase_made = purchase_made * 0.90;
                if (purchase_made >= trip_price)
                {
                    Console.WriteLine($"Yes! {purchase_made - trip_price:f2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {trip_price - purchase_made:f2} lv needed.");

                }
            }
            else
            {
                purchase_made = purchase_made * 0.90;
                if (purchase_made >= trip_price)
                {
                    Console.WriteLine($"Yes! {purchase_made - trip_price:f2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {trip_price - purchase_made:f2} lv needed.");

                }
            }
        }
    }
}
