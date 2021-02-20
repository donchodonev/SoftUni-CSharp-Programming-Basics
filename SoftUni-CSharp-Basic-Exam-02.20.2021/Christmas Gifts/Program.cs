using System;

namespace Christmas_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int toyPrice = 5;
            int sweaterPrice = 15;

            int numOfAdults = 0;
            int numOfKids = 0;
            int numOfToys = 0;
            int numOfSweaters = 0;


            while (true)
            {
                string input = Console.ReadLine();
                int age = 0;
                if (input == "Christmas")
                {
                    break;
                }
                else
                {
                    age += int.Parse(input);
                }

                if (age <= 16)
                {
                    numOfKids++;
                    numOfToys++;
                }
                else
                {
                    numOfAdults++;
                    numOfSweaters++;
                }
            }

            Console.WriteLine($"Number of adults: {numOfAdults}");
            Console.WriteLine($"Number of kids: {numOfKids}");
            Console.WriteLine($"Money for toys: {numOfKids * toyPrice}");
            Console.WriteLine($"Money for sweaters: {numOfAdults * sweaterPrice}");
        }
    }
}
