using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Arrays01
{
    class Program
    {
        static void Main(string[] args)
        {
            // zad 1 Days of Week
            //string[] days = new string[]
            //            //    "Monday",
            //    "Thuesday",
            //    "Wednesday",
            //    "Thursday",
            //    "Friday",
            //    "Saturday",
            //    "Sunday"
            //};

            //    int input = int.Parse(Console.ReadLine());


            //    while (input < 1 || input > 7 )
            //    {
            //        Console.WriteLine("Invalid day");
            //        input = int.Parse(Console.ReadLine());
            //    }



            //        Console.WriteLine($"{days[input - 1] }");

            //zad 2 Print numbers in reverse 

            //int n = int.Parse(Console.ReadLine());
            //int[] array = new int[n];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[array.Length - i - 1] + " ");
            //}


            //zad 3 Rounding away from 0


            //double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = Math.Round(arr[i]);
            //    Console.WriteLine($"Array [{i}] = {arr[i]}");
            //}


            //zad 4 Reverse array of strings

            //string[] arr = Console.ReadLine().Split();

            //for (int i = 0; i < arr.Length/2; i++)

            //{
            //    string temp = arr[i];
            //    arr[i] = arr[arr.Length - i - 1];
            //    arr[arr.Length - i - 1] = temp;
            //}

            //Console.WriteLine(String.Join(" ", arr));

            //zad 5 Sum even numbers

            //int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int result = 0;            

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        result += numbers[i];

            //    }



            //}

            //Console.WriteLine(result);

            //zad 6 Even and Odd Subtraction

            //int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int evenresult = 0;
            //int oddresult = 0;
            //int result = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        evenresult += numbers[i];

            //    }

            //    else
            //    {
            //        oddresult += numbers[i];
            //    }

            //}

            //Console.WriteLine(result = evenresult - oddresult);


            ////Console.WriteLine($"Array[{i}] = {arr[i]}");  pechatame masiv

            //zad 7.Equal Arrays
            // moq nachin - ne napulno veren
            //int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int result = 0;
            //bool isEqual = false;
            //for (int i = 0; i < arr1.Length; i++)
            //{


            //    if (arr1[i] != arr2[i])
            //    {
            //        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");

            //        isEqual = false;

            //        break;
            //    }

            //    else
            //    {
            //        result += arr1[i];
            //        isEqual = true;
            //    }

            //}

            //if (isEqual == true)
            //{
            //    Console.WriteLine($"Arrays are identical. Sum: {result}");
            //}

            // zad 7 Equal Arrays - drug nachin ot foruma 100/100

            //int[] array1 = Console.ReadLine()
            //    .Split(" ")
            //    .Select(int.Parse)
            //    .ToArray();

            //int[] array2 = Console.ReadLine()
            //    .Split(" ")
            //    .Select(int.Parse)
            //    .ToArray();

            //for (int i = 0; i < array1.Length; i++)
            //{
            //    if (array1[i] != array2[i])
            //    {
            //        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
            //        return;
            //    }

            //}

            //int sum = array1.Sum();
            //Console.WriteLine($"Arrays are identical. Sum: {sum}");

            //zad 8 Condane array to number

            //int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //if (arr.Length == 1)
            //{
            //    Console.WriteLine(arr[0]);
            //    return;

            //}
            //else
            //{

            //    while (arr.Length > 1)
            //    {

            //        int[] condensed = new int[arr.Length - 1];

            //        for (int i = 0; i < arr.Length - 1; i++)
            //        {
            //            condensed[i] = arr[i] + arr[i + 1]; // subirame indexite ot arr1 i gi pribavqme kym 2riq masiv
            //        }
            //        arr = condensed;


            //    }

            //    Console.WriteLine(string.Join("", arr[0]));

            //}
        }
    }
}

