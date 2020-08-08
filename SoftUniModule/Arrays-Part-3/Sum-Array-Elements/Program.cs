using System;
using System.Linq;

namespace Sum_Array_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInputs = int.Parse(Console.ReadLine());

            int result = 0;
            for (int i = 0; i < numberInputs; i++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int k = 0; k < arr.Length; k++)
                {
                    result += arr[k];
                }

            }
            Console.WriteLine(result);
        }
    }
}
