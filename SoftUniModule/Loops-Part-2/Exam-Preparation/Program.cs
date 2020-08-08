using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxPoorGrades = int.Parse(Console.ReadLine());
            int countPoorGrades = 0;
            int sumGrades = 0;
            int countGrades = 0;
            string lastTask = "";
            //Стоп -> при command == Enough -> продължаваме -> command != oт Еnough;
            //Стоп -> броя на слабите оценки == maxPoorGrades

            string command = ""; // zadacha ili enough

            while (command != "Enough")
            {

                int grade = int.Parse(Console.ReadLine());
                sumGrades += grade;
                countGrades++;
                lastTask = command;
                if (grade <= 4)
                {
                    countPoorGrades++;
                }
                if (countPoorGrades == maxPoorGrades)
                {
                    Console.WriteLine($"You need a break, {countPoorGrades} poor grades.");
                    break;
                }
                command = Console.ReadLine();
            }
            if (command == "Enough")
            {
                double average = sumGrades * 1.0 / countGrades;
                Console.WriteLine($"Average score: {average}");
                Console.WriteLine($"Number of problems: {countGrades}");
                Console.WriteLine($"Last Problem: {lastTask}");
            }
        }
    }
}
