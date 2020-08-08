using System;

namespace Add_And_Substract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int result = sumFirstTwoNumbers(firstNumber, secondNumber) - substractFromFirstTwo(thirdNumber);

            sumFirstTwoNumbers(firstNumber, secondNumber);
            substractFromFirstTwo(thirdNumber);

            Console.WriteLine(result);
        }

        static int sumFirstTwoNumbers(int first, int second)
        {
            return first + second;
        }

        static int substractFromFirstTwo(int third)
        {
            return third;
        }
    }
}
