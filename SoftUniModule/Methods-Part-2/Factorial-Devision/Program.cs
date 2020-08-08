using System;

namespace Factorial_Devision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            double firstFact = FactorialSum(firstNumber);
            double secondFact = FactorialSum(secondNumber);
            double output = firstFact / secondFact;

            Console.WriteLine($"{output:F2}");
        }

        static double FactorialSum(double first)
        {


            for (double i = first - 1; i >= 1; i--)
            {
                first *= i;
            }
            return first;
        }

    }
}
