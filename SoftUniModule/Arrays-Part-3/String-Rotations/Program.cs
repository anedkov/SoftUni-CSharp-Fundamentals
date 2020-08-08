using System;

namespace String_Rotations
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arr = Console.ReadLine().Split(" ");

            for (int i = arr.Length - 1; i > 0; i--)
            {
                string temp = arr[i];
                arr[i] = arr[i - 1];
                arr[i - 1] = temp;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
