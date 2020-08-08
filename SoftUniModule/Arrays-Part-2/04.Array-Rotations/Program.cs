using System;

namespace _04.Array_Rotations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().
                                    Split();
            int rotations = int.Parse(Console.ReadLine());
            for (int r = 0; r < rotations; r++)
            {


                string lastNum = arr[0];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];


                }
                arr[arr.Length - 1] = lastNum;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
