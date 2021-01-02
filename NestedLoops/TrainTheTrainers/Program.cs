using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryMembers = int.Parse(Console.ReadLine());
            bool cycleContinues = true;
            string presentationName = "";
            int presentationCount = 0;
            double presentationGrade = 0;
            double allGrades = 0;

            while (cycleContinues)
            {
                string input = Console.ReadLine();
                if (input == "Finish")
                {
                    cycleContinues = false;
                    break;
                }
                presentationGrade = 0;
                presentationName = input;
                presentationCount++;
                
                //for loop to get the grading of each jury member
                for (int i = 1; i <= juryMembers; i++)
                {
                    presentationGrade += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"{presentationName} - {presentationGrade / juryMembers:F2}.");
                allGrades += presentationGrade;
            }
            double presentationAvgGrade = allGrades / (presentationCount*juryMembers);
            Console.WriteLine($"Student's final assessment is {presentationAvgGrade:F2}.");
        }
    }
}
