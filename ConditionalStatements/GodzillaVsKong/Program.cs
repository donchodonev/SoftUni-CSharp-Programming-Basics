using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {

            double filmBudget = double.Parse(Console.ReadLine()) * 0.90;
            int statistCount = int.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());

            if (statistCount >= 150)
            {
                clothingPrice = clothingPrice * 0.90;
            }

            double grandTotal = filmBudget - (statistCount * clothingPrice);

            if (grandTotal >= 0)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {grandTotal:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(grandTotal):f2} leva more.");
            }
        }
    }
}
