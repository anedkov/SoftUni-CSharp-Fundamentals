using System;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstDigit = 0;
            int lastDigit = 0;

            for (int i = 0; i <= n; i++)
            {
                lastDigit = i % 10;
                firstDigit = i / 10;

                if (firstDigit + lastDigit == 5 || firstDigit + lastDigit == 7 || firstDigit + lastDigit == 11)
                {

                    Console.WriteLine($"{i} - True");
                }
                else
                {
                    Console.WriteLine($"{i} - False");
                }

            }
        }
    }
}
