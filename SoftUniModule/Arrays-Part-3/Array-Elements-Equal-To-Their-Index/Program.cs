using System;

namespace Array_Elements_Equal_To_Their_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string result = String.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                int currElement = arr[i];
                if (currElement == i)
                {
                    result += currElement + " ";
                }
            }

            Console.WriteLine(result);

        }
    }
}
