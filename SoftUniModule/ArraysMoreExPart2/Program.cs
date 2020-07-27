using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ArraysMoreExPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            // zad 1.Last 3 Consecutive Equal Strings

            //string[] arr = Console.ReadLine().Split(" ");
            //int bestCount = 0;
            //string bestWord = String.Empty;
            //string result = string.Empty;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    string currElement = arr[i];
            //    int currCount = 1;

            //    for (int k = i+1; k < arr.Length; k++)
            //    {
            //        string currI = arr[k];
            //        if (currElement == currI)
            //        {
            //            currCount++;
            //            bestCount = currCount;
            //            bestWord = currElement;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }

            //}


            //for (int k = 0; k <=bestCount; k++)
            //{
            //    result += bestWord + " ";
            //}

            //Console.WriteLine(result);

            //zad 2.Array Elements Equal to Their Index

            //int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            //string result = String.Empty;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int currElement = arr[i];
            //    if (currElement == i)
            //    {
            //        result += currElement + " ";
            //    }
            //}

            //Console.WriteLine(result);

            //// 3. Phonebook

            //string[] phoneNumbers = Console.ReadLine().Split(" ");
            //string[] names = Console.ReadLine().Split(" ");
            //string currName = "";
            //string currNum = "";
            //string result = String.Empty;
            //string command = Console.ReadLine();
            //while (command != "done")
            //{
            //    for (int i = 0; i < names.Length; i++)
            //    {
            //        currName = names[i];
            //        if (command == currName)
            //        {



            //            for (int k = 0; k < phoneNumbers.Length; k++)
            //            {
            //                currNum = phoneNumbers[k];

            //                names[i] = phoneNumbers[i];

            //                if (names[i] == phoneNumbers[k])
            //                {
            //                    Console.WriteLine($"{currName} -> {currNum}");
            //                }



            //            }
            //        }
            //    }

            //    command = Console.ReadLine();
            //}

            //zad 4 . Phone* za po-kusno , no zaduljitelno!


            //string[] phoneNumbers = Console.ReadLine().Split(" ");
            //long[] phoneNumbersToInt = new long[phoneNumbers.Length];
            //string[] names = Console.ReadLine().Split(" ");
            //string currName = "";
            //string currNum = "";
            //string result = String.Empty;
            //string command = Console.ReadLine();

            //for (int splitter = 0; splitter < phoneNumbers.Length; splitter++)
            //{
            //    phoneNumbersToInt[splitter] = long.Parse(phoneNumbers[splitter]);
            //}

            //for (int numbers = 0; numbers < phoneNumbers.Length; numbers++)
            //{
            //    if (names[numbers] == )
            //    {

            //    }
            //}
            //while (command != "done")
            //{
            
            //    command = Console.ReadLine();
            //}

            //zad 5. Char Rotation

            //string charValues = Console.ReadLine();
            //int[] intValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //char[] result = new char[intValues.Length];
            //for (int i = 0; i < intValues.Length; i++)
            //{

            //    if (intValues[i] % 2 == 0)
            //    {
            //        result[i] = (char)(charValues[i] - intValues[i]);
            //    }
            //    else
            //    {                              
            //        result[i] = (char)(charValues[i] + intValues[i]);
            //    }
            //}

            //Console.WriteLine(string.Join("", result));

            //zad 6. PowerPlants

            //var plants = Console.ReadLine()
            //                    .Split()
            //                    .Select(int.Parse)
            //                    .ToArray();
            //var alive = 0;
            //var death = 0;
            //var days = 0;
            //for (int season = 0; season < int.MaxValue; season++)
            //{
            //    for (int day = 0; day < plants.Length; day++)
            //    {
            //        if (plants[day] > 0)
            //            plants[day]++;
            //        for (int plant = 0; plant < plants.Length; plant++)
            //        {
            //            plants[plant]--;
            //        }
            //        for (int checkAlive = 0; checkAlive < plants.Length; checkAlive++)
            //        {
            //            if (plants[checkAlive] > 0)
            //                alive++;
            //            else if (plants[checkAlive] <= 0)
            //                death++;
            //        }
            //        days++;
            //        if (alive == 0)
            //        {
            //            Console.WriteLine($"survived {days} days ({season} seasons)");
            //            return;
            //        }
            //        alive = 0;
            //        death = 0;
            //    }
            //    for (int bloom = 0; bloom < plants.Length; bloom++)
            //    {
            //        if (plants[bloom] > 0)
            //            plants[bloom]++;
            //    }
            //}


        }
    }
}