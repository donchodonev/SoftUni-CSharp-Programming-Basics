using System;

namespace Number_100_200
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade = int.Parse(Console.ReadLine());

            if (grade < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (grade <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }

            else
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
