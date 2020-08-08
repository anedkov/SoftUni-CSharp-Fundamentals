using System;

namespace Vowels_Count_Another_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];
                if (isVowel(symbol))
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }

        static bool isVowel(char symbol)
        {
            return symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' ||
                    symbol == 'u' || symbol == 'y';
        }
    }
}
