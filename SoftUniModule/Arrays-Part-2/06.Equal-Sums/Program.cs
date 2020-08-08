using System;
using System.Linq;

namespace _06.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            // 1 2 3 3 

            for (int i = 0; i < arr.Length; i++)
            {
                int sumL = 0;
                int sumR = 0;
                for (int j = 0; j < i; j++)
                {
                    sumL += arr[j];
                }

                for (int k = i + 1; k < arr.Length; k++)
                {
                    sumR += arr[k];
                }
                if (sumL == sumR)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
