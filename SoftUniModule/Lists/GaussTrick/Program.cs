using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            PrintGaussTrick(numbers);

        }

        static void PrintGaussTrick(List<int> numbers)
        {
            
            for (int i = 0; i < numbers.Count/2; i++)
            {

             Console.Write(numbers[i] + numbers[numbers.Count - 1 - i] + " ");
                
            }

            if (numbers.Count % 2 != 0)
            {
                Console.Write(numbers[numbers.Count/2] + " ");
               
            }
         

            
        }
    }
}
