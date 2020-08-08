using System;

namespace _05.Stream_Of_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                Console.WriteLine(currentChar);
            }
        }
    }
}
