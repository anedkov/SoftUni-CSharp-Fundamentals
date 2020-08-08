using System;
using System.Linq;

namespace _07.Max_Sequance_Of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //3 4 4 5 5 5 6 7
            string result = "";
            int bestCount = 0;
            int bestIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                //1 1 1 2 3 1 3 3
                int currElement = arr[i];
                int currCount = 1;

                for (int currI = i + 1; currI < arr.Length; currI++)
                {
                    if (currElement == arr[currI])
                    {
                        currCount++;
                    }

                    else
                    {
                        break;
                    }
                }
                if (currCount > bestCount)
                {
                    bestCount = currCount;
                    bestIndex = i;
                }

            }
            for (int i = 0; i < bestCount; i++)
            {
                result += arr[bestIndex] + " ";

            }
            Console.WriteLine(result);
        }
    }
}
