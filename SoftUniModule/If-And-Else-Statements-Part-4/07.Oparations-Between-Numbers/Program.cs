using System;

namespace _07.Oparations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string theOperator = (Console.ReadLine());
            bool simpleOperators = theOperator == "+" || theOperator == "-" || theOperator == "*";
            double result = 0;
            switch (theOperator)
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {

                        Console.WriteLine($"{num1} {theOperator} {num2} = {result}");
                    }

                    break;
                case "%":
                    result = num1 % num2;

                    break;
                default:
                    break;
            }

            if (simpleOperators)
            {


                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} {theOperator} {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} {theOperator} {num2} = {result} odd");
                }


            }
        }
    }
}
