using System;

namespace _11.Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(num1, @operator, num2));

        }

        public static double Calculate(int num1, string @operator, int num2)

        {
            double result = 0;
            switch (@operator)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;

                default:
                    break;

            }
            return result;
        }
    }
}
