using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            int time_per_project = 3;
            Console.WriteLine($"The architect {name} will need {projects * time_per_project} hours to complete {projects} project/s.");
        }
    }
}
