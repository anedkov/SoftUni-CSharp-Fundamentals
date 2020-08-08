using System;

namespace Count_Of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int countOdd = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] % 2 != 0)
                {
                    countOdd++;
                }
            }
            Console.WriteLine(countOdd);

        }
    }
}
