using System;
using System.Linq;

namespace Odd_Numbers_At_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0 && arr[i] % 2 != 0)
                {
                    Console.WriteLine($"Index {i} -> {arr[i]}");
                }
            }
        }
    }
}
