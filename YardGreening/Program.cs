using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double sq_meters = double.Parse(Console.ReadLine());
            double full_price = sq_meters * 7.61;
            double discount = (full_price / 100.0) * 18.0;
            double final_price = full_price - discount;

            Console.WriteLine("{0:F2}", $"The final price is: {final_price} lv.");
            Console.WriteLine("{0:F2}", $"The discount is: {discount} lv.");
        }
    }
}
