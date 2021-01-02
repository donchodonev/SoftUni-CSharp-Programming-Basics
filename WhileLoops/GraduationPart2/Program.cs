using System;

namespace GraduationPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double grade = 0.00;
            int fail = 2;
            int gradeCount = 0;
            while (fail != 0 && gradeCount < 12)
            {
                double input = double.Parse(Console.ReadLine());
                if (input < 4.00)
                {
                    fail--;
                    gradeCount++;
                    grade += input;
                }
                else
                {
                    gradeCount++;
                    grade += input;
                }
            }
            if (fail != 0)
            {
                Console.WriteLine($"{name} graduated. Average grade: {grade / 12:F2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {gradeCount - 1} grade");
            }
        }
    }
}
