using System;

namespace _04.Sum_Of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfChars = int.Parse(Console.ReadLine());
            int theSum = 0;
            for (int i = 0; i < numberOfChars; i++)
            {
                char actualChar = char.Parse(Console.ReadLine());
                theSum += actualChar;
            }
            Console.WriteLine(theSum);
        }
    }
}
