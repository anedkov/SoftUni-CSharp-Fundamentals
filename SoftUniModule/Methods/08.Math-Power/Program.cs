using System;

namespace _08.Math_Power
{
    class Program
    {

        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine(PoweringNumbers(num1, num2));

        }

        public static double PoweringNumbers(double n1, double n2)
        {
            double result = 0d;
            result = Math.Pow(n1, n2);
            return result;
        }
    }
}
