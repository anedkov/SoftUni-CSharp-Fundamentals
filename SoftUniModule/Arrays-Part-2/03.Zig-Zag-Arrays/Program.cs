using System;

namespace _03.Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr1 = new string[n];
            string[] arr2 = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] currentNum = Console.ReadLine()
                                             .Split();

                if (i % 2 == 0)
                {
                    arr1[i] = currentNum[0];
                    arr2[i] = currentNum[1];
                }
                else
                {
                    arr1[i] = currentNum[1];
                    arr2[i] = currentNum[0];
                }

            }
            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}
