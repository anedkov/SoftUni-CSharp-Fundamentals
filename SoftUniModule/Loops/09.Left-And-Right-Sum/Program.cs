using System;

namespace _09.Left_And_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n *= 2;
            int leftSide = 0;
            int rightSide = 0;

            for (int i = 1; i <= n; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                int divider = n / 2;
                if (i <= divider)
                {
                    leftSide += nums;
                }
                else
                {
                    rightSide += nums;
                }

            }
            if (leftSide == rightSide)
            {
                Console.WriteLine($"Yes, sum = " + leftSide);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(leftSide - rightSide));
            }
        }
    }
}
