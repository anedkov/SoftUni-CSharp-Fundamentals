using System;

namespace _10.Multiply_Evens_By_Odds
{
    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            int[] allNumbers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (char.IsDigit(currentChar))
                {
                    allNumbers[i] = int.Parse(currentChar.ToString());
                }
            }

            int evenSum = GetSumOfEvenDigits(allNumbers);
            int oddNSum = GetSumOfOddDigits(allNumbers);

            int result = GetMultipleOfEvenAndOdds(evenSum, oddNSum);

            Console.WriteLine(result);
        }

        private static int GetSumOfOddDigits(int[] allNumbers)
        {
            return allNumbers.Where(x => x % 2 == 1).Sum();
        }

        private static int GetSumOfEvenDigits(int[] allNumbers)
        {
            return allNumbers.Where(x => x % 2 == 0).Sum();
        }

        private static int GetMultipleOfEvenAndOdds(int evenSum, int oddNSum)
        {
            return evenSum * oddNSum;
        }

    }
}
