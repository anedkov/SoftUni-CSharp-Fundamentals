using System;

namespace Smallest_Element_In_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int smallestElement = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                int currSmall = arr[i];
                if (currSmall < smallestElement)
                {
                    smallestElement = currSmall;
                }

            }
            Console.WriteLine(smallestElement);
        }
    }
}
