using System;

namespace _10.Even_Odd_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            int sumEven = 0;
            for (int i = 1; i <= n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumOdd += numbers;
                }
                else
                {
                    sumEven += numbers;
                }
            }
            if (sumOdd == sumEven)
            {
                Console.WriteLine($"Yes, sum = " + sumEven);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(sumEven - sumOdd));
            }
        }
    }
}
