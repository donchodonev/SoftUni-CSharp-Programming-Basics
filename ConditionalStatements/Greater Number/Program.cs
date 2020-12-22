using System;

namespace Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade = int.Parse(Console.ReadLine());
            int grade2 = int.Parse(Console.ReadLine());

            if (grade > grade2)
            {
                Console.WriteLine(grade);
            }
            else
            {
                Console.WriteLine(grade2);
            }
        }
    }
}
