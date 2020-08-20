using System;
using System.Collections.Generic;

namespace _02_Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split(" ");

            Random rnd = new Random();


            for (int i = 0; i < arr.Length; i++)
            {

                var randomIndex = rnd.Next(0, arr.Length);

                var randomElement = arr[randomIndex];
                var elementFromArray = arr[i];

                arr[randomIndex] = elementFromArray;
                arr[i] = randomElement;


                

            }

            foreach (var el in arr)
            {
                Console.WriteLine(el);
            }
         

        }
    }
}

