using System;

namespace _07.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numberOfGrades = 12;
            double result = 0;
            for (int i = 1; i <= 12; i++)
            {
                double typeGrades = double.Parse(Console.ReadLine());
                result += typeGrades;
                if (typeGrades == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {i} grade");
                    break;

                }

            }
            double final = result / numberOfGrades;

            if (final >= 4.00)
            {
                Console.WriteLine($"{name} graduated. Avarage grade: {final:F2}");
            }
        }
    }
}
