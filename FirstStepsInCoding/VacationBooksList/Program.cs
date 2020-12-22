using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            double read_speed = double.Parse(Console.ReadLine());
            int days_until_completion = int.Parse(Console.ReadLine());

            double hours_of_reading_required = pages / read_speed / days_until_completion;

            Console.WriteLine(hours_of_reading_required);
        }
    }
}
