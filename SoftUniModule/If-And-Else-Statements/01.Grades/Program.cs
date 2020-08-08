using System;

namespace _01.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //Checks for excellent grade only

            double grade = double.Parse(Console.ReadLine());

            if (grade >= 5.50)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
