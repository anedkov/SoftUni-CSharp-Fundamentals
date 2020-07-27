using System;
using System.Linq;

namespace ArraysExAlen
{
    class Program
    {
        static void Main(string[] args)
        {
            //zad 1 Train
            //int wagons = int.Parse(Console.ReadLine());

            //int[] train = new int[wagons];

            //for (int i = 0; i < wagons; i++)
            //{
            //    train[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine(string.Join(" ", train));
            //Console.WriteLine(train.Sum());

            //zad 2 Common Elements

            // sys foreach cikul
            //string[] arr1 = Console.ReadLine().Split();
            //string[] arr2 = Console.ReadLine().Split();
            //string result = "";
            //foreach (var word1 in arr2)
            //{
            //    foreach (var word2 in arr1)
            //    {
            //        if (word1 == word2)
            //        {
            //            result += word1 + " ";
            //        }
            //    }
            //}
            //Console.WriteLine(result);

            // zad 2 sys for loop

            //string[] arr1 = Console.ReadLine().Split();
            //string[] arr2 = Console.ReadLine().Split();
            //string result = string.Empty;

            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    for (int j = 0; j < arr1.Length; j++)
            //    {
            //        if (arr2[i] == arr1[j]  )
            //        {
            //            result += arr2[i] + " "; 
            //        }
            //    }
            //}
            //Console.WriteLine(result);

            //int n = int.Parse(Console.ReadLine());
            //string[] arr1 = new string[n];
            //string[] arr2 = new string [n];

            //for (int i = 0; i < n; i++)
            //{
            //    string[] currentNum = Console.ReadLine()
            //                                 .Split();

            //    if (i % 2 == 0)
            //    {
            //        arr1[i] = currentNum[0];
            //        arr2[i] = currentNum[1];
            //    }
            //    else
            //    {
            //        arr1[i] = currentNum[1];
            //        arr2[i] = currentNum[0];
            //    }

            //}
            //Console.WriteLine(string.Join(" ", arr1));
            //Console.WriteLine(string.Join(" ", arr2));

            // zad 4 array rotations

            //    string[] arr = Console.ReadLine().
            //                            Split();
            //    int rotations = int.Parse(Console.ReadLine());
            //    for (int r = 0; r < rotations; r++)
            //    {


            //        string lastNum = arr[0];
            //        for (int i = 0; i < arr.Length - 1; i++)
            //        {
            //            arr[i] = arr[i + 1];


            //        }
            //        arr[arr.Length - 1] = lastNum;
            //    }

            //    Console.WriteLine(string.Join(" ", arr));
            //int[] arr = Console.ReadLine().Split()
            //                    .Select(int.Parse)
            //                    .ToArray();
            //int currentBest = 0;
            //string result = "";
            //for (int i = 0; i < arr.Length; i++)
            //{

            //        currentBest = arr[i]; // current best e segashniq nai golqm index
            //        bool isTop = true;


            //        for (int index = i+1; index < arr.Length; index++) // zavurtame ot segashniq nai dobur natatuk
            //        {
            //            if (currentBest <= arr[index])
            //            {
            //                isTop = false;
            //                    break;
            //            }

            //        }
            //        if (isTop)
            //        {
            //            result += currentBest + " ";
            //        }
            //    }


            //Console.WriteLine(result);

            //zad 6 equal sums

            //int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //// 1 2 3 3 

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int sumL = 0;
            //    int sumR = 0;
            //    for (int j = 0; j < i; j++)
            //    {
            //        sumL += arr[j];
            //    }

            //    for (int k = i+1; k < arr.Length; k++)
            //    {
            //        sumR += arr[k];
            //    }
            //    if (sumL == sumR)
            //    {
            //        Console.WriteLine(i);
            //        return;
            //    }
            //}
            //Console.WriteLine("no");

            // 7. Max sequence of elements

            //int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            ////3 4 4 5 5 5 6 7
            //string result = "";
            //int bestCount = 0;
            //int bestIndex = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    //1 1 1 2 3 1 3 3
            //    int currElement = arr[i];
            //    int currCount = 1;

            //    for (int currI = i + 1; currI < arr.Length; currI++)
            //    {
            //        if (currElement == arr[currI])
            //        {
            //            currCount++;
            //        } 

            //        else
            //        {
            //            break;
            //        }
            //    }
            //    if (currCount > bestCount)
            //    {
            //        bestCount = currCount;
            //        bestIndex = i;
            //    }

            //}
            //for (int i = 0; i < bestCount; i++)
            //{
            //    result += arr[bestIndex] + " ";

            //}
            //Console.WriteLine(result);

            //zad 8 Magic sum
            //14 20 60 13 7 19 8 
            //27
            //int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int magicNum = int.Parse(Console.ReadLine());
            //string result = "";
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int currElement = arr[i];

            //    for (int k = i+ 1; k < arr.Length; k++)
            //    {
            //        int secondCurrElement = arr[k];
            //        if (currElement + secondCurrElement == magicNum)
            //        {

            //            Console.WriteLine($"{currElement} {secondCurrElement}");

            //        }

            //    }

            //}


            //zad 9. Kamino Factory

            int dna = int.Parse(Console.ReadLine());
            //5
            //1!0!1!1!0
            //0!1!1!0!0
            //Clone them!
            int[] bestarr = new int[dna];
            //int bestCount = 0;
            //int bestIndex = 0;
            int bestCurrSum = 0;
            int maxCount = 0;
            
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Clone them!")
                {
                    break;
                }
               int [] arr = Console.ReadLine().Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int i = 0; i < arr.Length; i++)
            {
                
                int currElement = arr[i];
                int currBestCount = 1;
                
                if (currElement == 0)
                {
                    continue;
                }
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (arr[k] == 1)
                    {
                        currBestCount++;
                        
                    }

                    else
                    {
                        break;
                    }

                }
                if (currBestCount > bestCount)
                {
                    bestIndex = i;
                    bestSum = arr.Sum();
                    bestarr = arr.ToArray();
                    bestCount = currBestCount;
                }
            }

            Console.WriteLine($"Best DNA sample 2 with sum: {bestSum}");
            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine($"BestIndex: {bestIndex}");
                
            }
        }

    }

}
