using System;

namespace Multiply_Array_Of_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double p = double.Parse(Console.ReadLine());
            double result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result = (arr[i] * p);
                Console.WriteLine(result);
            }
        }
    }
}
