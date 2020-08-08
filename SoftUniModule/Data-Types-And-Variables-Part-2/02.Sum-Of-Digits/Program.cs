using System;

namespace _02.Sum_Of_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int theNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            while (theNumber != 0)
            {
                sum += theNumber % 10;
                theNumber /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
