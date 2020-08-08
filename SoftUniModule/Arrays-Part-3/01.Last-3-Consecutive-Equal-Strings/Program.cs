using System;

namespace _01.Last_3_Consecutive_Equal_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ");
            int bestCount = 0;
            string bestWord = String.Empty;
            string result = string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                string currElement = arr[i];
                int currCount = 1;

                for (int k = i + 1; k < arr.Length; k++)
                {
                    string currI = arr[k];
                    if (currElement == currI)
                    {
                        currCount++;
                        bestCount = currCount;
                        bestWord = currElement;
                    }
                    else
                    {
                        break;
                    }
                }

            }


            for (int k = 0; k <= bestCount; k++)
            {
                result += bestWord + " ";
            }

            Console.WriteLine(result);
        }
    }
}
