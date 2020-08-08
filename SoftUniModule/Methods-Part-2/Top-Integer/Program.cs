using System;

namespace Top_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i < num; i++)
            {
                if (IsDivisibleByGivenNums(i) && HasAtLeastOneOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }

        }

        static bool IsDivisibleByGivenNums(int num)
        {

            int temp = num;
            int sum = 0;
            while (temp > 0)
            {
                sum += temp % 10;
                temp /= 10;
            }

            if (sum % 8 == 0)
            {
                return true;
            }

            return false;
        }

        static bool HasAtLeastOneOddDigit(int num)
        {
            int temp = num;
            int currDigit = 0;
            int counter = 0;
            while (temp > 0)
            {
                currDigit += temp % 10;
                if (currDigit % 2 != 0)
                {
                    counter++;
                    return true;
                }
                else
                {

                    temp /= 10;
                }
            }



            return false;
        }
    }
}
