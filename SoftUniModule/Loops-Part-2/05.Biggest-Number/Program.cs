using System;

namespace _05.Biggest_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());
            int br = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            while (br < nums)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum < min)
                {
                    min = currentNum;
                }
                if (currentNum > max)
                {
                    max = currentNum;
                }
                br++;

            }
            Console.WriteLine(max);
        }
    }
}
