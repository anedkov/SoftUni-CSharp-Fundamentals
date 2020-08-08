using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    NumAdd(num1, num2);
                    break;
                case "multiply":
                    NumMultiply(num1, num2);
                    break;
                case "subtract":
                    NumSubtract(num1, num2);
                    break;
                case "divide":
                    NumDivide(num1, num2);
                    break;
                default:
                    break;
            }

        }

        private static void NumDivide(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }

        private static void NumSubtract(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }

        private static void NumMultiply(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }

        private static void NumAdd(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
      }
   }

