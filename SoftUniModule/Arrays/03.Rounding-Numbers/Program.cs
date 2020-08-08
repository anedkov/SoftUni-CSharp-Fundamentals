using System;
using System.Linq;

namespace _03.Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Math.Round(arr[i]);
                Console.WriteLine($"Array [{i}] = {arr[i]}");
            }
        }
    }
}
