﻿using System;

namespace _06.Sum_Of_Vowels
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string input = Console.ReadLine(); //pesho
            int sum = 0;
           

            for (int i = 0; i <= input.Length - 1; i++)
            {
                char currentChar = input[i];

                switch (currentChar)
                {
                    case 'a':
                        sum++;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
