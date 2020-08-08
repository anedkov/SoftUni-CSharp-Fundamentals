﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                //numbers.RemoveAll(x => x < 0);
                
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                    i--;
                }

            }
            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                numbers.Reverse();

                Console.WriteLine(string.Join(" ", numbers));
            }


        }
    }
}
