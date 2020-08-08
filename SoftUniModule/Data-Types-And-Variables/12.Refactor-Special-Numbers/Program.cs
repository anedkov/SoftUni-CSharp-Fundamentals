using System;

namespace _12.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberDigits = int.Parse(Console.ReadLine());

            for (int ch = 1; ch <= numberDigits; ch++)
            {
                int firstDigit = 0;
                int lastDigit = 0;

                lastDigit = ch;
                while (ch > 0)
                {

                    firstDigit += ch % 10;
                    ch = ch / 10;
                }
                bool isSpecial = false;

                isSpecial = (firstDigit == 5) || (firstDigit == 7) || (firstDigit == 11);
                Console.WriteLine("{0} -> {1}", lastDigit, isSpecial);
                firstDigit = 0;
                ch = lastDigit;
            }
        }
    }
}
