using System;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            Console.WriteLine(VowelsCounter(input));
        }

        static int VowelsCounter(string input)
        {
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' ||
                    input[i] == 'u' || input[i] == 'y')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
