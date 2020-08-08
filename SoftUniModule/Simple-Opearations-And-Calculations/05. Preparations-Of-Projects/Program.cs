using System;

namespace _05._Preparations_Of_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectArchitech = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            int hoursNeeded = numberOfProjects * 3;
            Console.WriteLine($"The architect {projectArchitech} will need {hoursNeeded} hours to complete {numberOfProjects} project/s");
        }
    }
}
