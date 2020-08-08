using System;

namespace _05.Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split()
                                .Select(int.Parse)
                                .ToArray();
            int currentBest = 0;
            string result = "";
            for (int i = 0; i < arr.Length; i++)
            {

                currentBest = arr[i]; 
                bool isTop = true;


                for (int index = i + 1; index < arr.Length; index++) // zavurtame ot current
                {
                    if (currentBest <= arr[index])
                    {
                        isTop = false;
                        break;
                    }

                }
                if (isTop)
                {
                    result += currentBest + " ";
                }
            }


            Console.WriteLine(result);
        }
    }
}
