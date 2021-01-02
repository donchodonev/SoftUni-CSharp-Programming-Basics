using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int allowedPoorGradesCount = int.Parse(Console.ReadLine());
            string task = "";
            string lastTask = "";
            double grade = 0.00;
            int numOfGrades = 0;
            int poorGradesReceived = 0;
            while (allowedPoorGradesCount != 0)
            {
                lastTask = Console.ReadLine();

                if (lastTask == "Enough")
                {
                    break;
                }
                task = lastTask;
                int gradeInput = int.Parse(Console.ReadLine());
                grade += gradeInput;
                numOfGrades++;
                if (gradeInput <= 4)
                {
                    allowedPoorGradesCount--;
                    poorGradesReceived++;
                }
            }
            if (lastTask == "Enough")
            {
                Console.WriteLine($"Average score: {grade / numOfGrades:f2}");
                Console.WriteLine($"Number of problems: {numOfGrades}");
                Console.WriteLine($"Last problem: {task}");
            }
            if (allowedPoorGradesCount == 0)
            {
                Console.WriteLine($"You need a break, {poorGradesReceived} poor grades.");
            }
        }
    }
}
