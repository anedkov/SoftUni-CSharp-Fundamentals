using System;
using System.Linq;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string input = Console.ReadLine();



            while (input != "end")
            {
                string[] commands = input.Split(" ");


                if (commands[0] == "exchange")
                {
                    int index = int.Parse(commands[1]);

                    Exchange(arr, index);

                }



                else if (commands[0] == "max")
                {
                    string typeNum = commands[1];
                    if (typeNum == "odd")
                    {
                        MaxOddIndex(arr);
                    }
                    else
                    {


                        MaxEvenIndex(arr);
                    }
                }

                else if (commands[0] == "first")
                {
                    string typeNum = commands[1];
                    int index = int.Parse(commands[1]);
                    if (typeNum == "even")
                    {

                        FirstGivenEvenElements(arr, index);
                    }
                    else
                    {
                        FirstGivenOddElements(arr, index);

                    }
                }
                else if (commands[0] == "last")
                {
                    string typeNum = commands[2];
                    int index = int.Parse(commands[1]);
                    if (typeNum == "even")
                    {
                        LastGivenEvenElements(arr, index);

                    }
                    else
                    {
                        LastGivenOddElements(arr, index);
                    }
                }


                else if (commands[0] == "min")
                {
                    string typeNum = commands[1];

                    if (typeNum == "odd")
                    {
                        MinOddIndex(arr);

                    }
                    else
                    {
                        MinEvenIndex(arr);
                    }
                }


                input = Console.ReadLine();
            }

            if (input == "end")
            {
                Console.WriteLine($"[{string.Join(", ", arr)}]");
            }
        }

        static void Exchange(int[] arr, int index)
        {
            // array 1 3 5 7 9
            //exchange 1
            // firstArray = 5 7 9 
            // secondArray = 1 3
            // arr = 5 7 9 1 3 
            if (index > arr.Length)
            {
                Console.WriteLine("Invalid index");

            }

            else
            {





                int[] newArray = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (index + i == arr.Length)
                    {
                        index = 0 - i;
                    }

                    newArray[i] = arr[i + index];
                }
                Array.Copy(newArray, arr, newArray.Length);

            }

        }

        static void MaxOddIndex(int[] arr)
        {
            int bestMaxOdd = int.MinValue;
            int bestIndex = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                int currMaxOdd = 0;
                int currBestIndex = 0;

                if (arr[i] % 2 != 0)
                {

                    currMaxOdd = arr[i];
                    currBestIndex = i;
                }


                if (currMaxOdd >= bestMaxOdd)
                {
                    bestMaxOdd = currMaxOdd;
                    bestIndex = currBestIndex;
                }

            }
            if (bestIndex <= 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(bestIndex);

            }
        }
        static void MinOddIndex(int[] arr)
        {
            int bestMin = int.MaxValue;
            int bestIndex = 0;
            int oddNumbersCounter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int currMinEven = 0;
                int currBestIndex = 0;

                if (arr[i] % 2 != 0)
                {
                    oddNumbersCounter++;
                    currMinEven = arr[i];
                    currBestIndex = i;
                    if (currMinEven <= bestMin)
                    {
                        bestMin = currMinEven;
                        currBestIndex = bestIndex;
                    }
                }
            }
            if (oddNumbersCounter == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(bestIndex);
            }

        }

        static void MaxEvenIndex(int[] arr)
        {

            int bestMaxEven = int.MinValue;
            int bestIndex = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                int currMaxEven = 0;
                int currBestIndex = 0;

                if (arr[i] % 2 == 0)
                {

                    currMaxEven = arr[i];
                    currBestIndex = i;
                }


                if (currMaxEven >= bestMaxEven)
                {
                    bestMaxEven = currMaxEven;
                    bestIndex = currBestIndex;

                }


            }
            if (bestIndex <= 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(bestIndex);

            }




        }
        static void MinEvenIndex(int[] arr)
        {
            int bestMin = int.MaxValue;
            int bestIndex = 0;
            int evenNumbersCounter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int currMinEven = 0;
                int currBestIndex = 0;

                if (arr[i] % 2 == 0)
                {
                    evenNumbersCounter++;
                    currMinEven = arr[i];
                    currBestIndex = i;
                    if (currMinEven <= bestMin)
                    {
                        bestMin = currMinEven;
                        currBestIndex = bestIndex;
                    }
                }
            }
            if (evenNumbersCounter == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(bestIndex);
            }

        }

        static void FirstGivenEvenElements(int[] arr, int givenElements)
        {

            int counter = 0;
            int[] sortedElements = new int[arr.Length];
            //четни
            if (givenElements > arr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        continue;
                    }
                    else
                    {
                        sortedElements[i] += arr[i];
                        counter++;


                    }



                }

                if (counter == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    var result = sortedElements.Take(givenElements);

                    Console.WriteLine($"[{string.Join(",", result.Where(x => x != 0))}]");
                }
            }
        }


        static void LastGivenEvenElements(int[] arr, int givenElements)
        {
            int counter = 0;
            int[] sortedElements = new int[arr.Length];
            //четни
            if (givenElements > arr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {


                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        continue;
                    }
                    else
                    {
                        sortedElements[i] += arr[i];
                        counter++;


                    }



                }

                if (counter == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    var result = sortedElements.Skip(arr.Length - givenElements);
                    Console.WriteLine($"[{string.Join(", ", result.Where(x => x != 0))}]");
                }
            }
        }


        static void FirstGivenOddElements(int[] arr, int givenElements)
        {

            int counter = 0;
            int[] sortedElements = new int[arr.Length];
            //четни
            if (givenElements > arr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {


                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        continue;
                    }
                    else
                    {
                        sortedElements[i] += arr[i];
                        counter++;


                    }



                }

                if (counter == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    var result = sortedElements.Take(givenElements);

                    Console.WriteLine($"[{string.Join(", ", result.Where(x => x != 0))}]");
                }
            }
        }

        static void LastGivenOddElements(int[] arr, int givenElements)
        {
            int counter = 0;
            int[] sortedElements = new int[arr.Length];
            //НЕчетни
            if (givenElements > arr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        continue;
                    }
                    else
                    {
                        sortedElements[i] += arr[i];
                        counter++;


                    }



                }

                if (counter == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    var result = sortedElements.Skip(arr.Length - givenElements);
                    Console.WriteLine($"[{string.Join(", ", result.Where(x => x != 0))}]");
                }
            }
        }
    }
}
