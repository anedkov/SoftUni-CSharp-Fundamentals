using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ArraysMoreEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Sum Array Elements
            //int numberInputs = int.Parse(Console.ReadLine());

            //int result = 0;
            //for (int i = 0; i < numberInputs; i++)
            //{
            //    int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //    for (int k = 0; k < arr.Length; k++)
            //    {
            //        result += arr[k];
            //    }

            //}

            //Console.WriteLine(result);

            //2. Multiply Array of Doubles

            //double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();
            //double p = double.Parse(Console.ReadLine());
            //double result = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    result = (arr[i] * p);
            //    Console.WriteLine(result);
            //}

            //3. Smallest element in array

            //int [] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int smallestElement = int.MaxValue;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int currSmall = arr[i];
            //    if (currSmall < smallestElement)
            //    {
            //        smallestElement = currSmall;
            //    }

            //}
            //Console.WriteLine(smallestElement);

            //4 String rotations!


            string[] arr = Console.ReadLine().Split(" ");

            for (int i = arr.Length - 1; i > 0; i--)
            {
                string temp = arr[i];
                arr[i] = arr[i - 1];
                arr[i - 1] = temp;
            }

            Console.WriteLine(string.Join(" ", arr));
        





        //5 Count of odd numbers in Array

        //int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        //int countOdd = 0;
        //for (int i = 0; i < arr.Length; i++)
        //{

        //    if (arr[i] % 2 != 0)
        //    {
        //        countOdd++;
        //    }
        //}
        //Console.WriteLine(countOdd);

        // 6. Odd numbers at Odd Positions

        //int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if (i % 2 != 0 && arr[i] % 2 !=0)
        //    {
        //        Console.WriteLine($"Index {i} -> {arr[i]}");
        //    }
        //}



    }
    }
}
