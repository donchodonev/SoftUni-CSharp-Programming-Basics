using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dog_food = int.Parse(Console.ReadLine());
            int other_food = int.Parse(Console.ReadLine());
            double total = (dog_food * 2.50) + (other_food * 4.00);
            Console.WriteLine("{0:F2}", total + " lv.");
        }
    }
}
