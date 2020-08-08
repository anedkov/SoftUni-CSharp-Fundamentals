using System;

namespace _06.Smallest_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
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
            }
            Console.WriteLine(min);
        }
    }
}
