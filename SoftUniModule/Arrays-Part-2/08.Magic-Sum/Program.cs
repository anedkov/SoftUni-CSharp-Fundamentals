using System;
using System.Linq;

namespace _08.Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int magicNum = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < arr.Length; i++)
            {
                int currElement = arr[i];

                for (int k = i + 1; k < arr.Length; k++)
                {
                    int secondCurrElement = arr[k];
                    if (currElement + secondCurrElement == magicNum)
                    {

                        Console.WriteLine($"{currElement} {secondCurrElement}");

                    }

                }

            }

        }
    }
}
