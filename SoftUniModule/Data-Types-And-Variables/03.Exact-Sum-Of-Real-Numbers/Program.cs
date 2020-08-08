using System;

namespace _03.Exact_Sum_Of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDigits = int.Parse(Console.ReadLine());
            decimal result = 0;
            for (int i = 0; i < numberOfDigits; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());


                result += number;

            }
            Console.WriteLine(result);
        }
    }
}
