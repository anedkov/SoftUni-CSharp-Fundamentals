using System;
using System.Linq;

namespace _08.Condense_Array_To_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (arr.Length == 1)
            {
                Console.WriteLine(arr[0]);
                return;

            }
            else
            {

                while (arr.Length > 1)
                {

                    int[] condensed = new int[arr.Length - 1];

                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        condensed[i] = arr[i] + arr[i + 1]; // subirame indexite ot arr1 i gi pribavqme kym 2riq masiv
                    }
                    arr = condensed;


                }

                Console.WriteLine(string.Join("", arr[0]));

            }
        }
    }
}
