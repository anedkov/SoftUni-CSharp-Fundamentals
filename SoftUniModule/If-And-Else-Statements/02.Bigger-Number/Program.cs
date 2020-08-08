using System;

namespace _02.Bigger_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber >= secondNumber)
            {
                Console.WriteLine(firstNumber);
            }
        }
    }
}
