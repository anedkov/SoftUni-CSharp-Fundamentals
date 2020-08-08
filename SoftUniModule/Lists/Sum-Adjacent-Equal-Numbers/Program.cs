using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                                  .Split()
                                  .Select(double.Parse)
                                  .ToList();

           var result = SumAdjacentEqualNums(numbers);

            Console.WriteLine(string.Join(" ",result));
        }

        static List<double> SumAdjacentEqualNums(List<double> numbers)
        {

            for (int i = 0; i < numbers.Count; i++)
            {
              
                if (i + 1 == numbers.Count)
                {
                    break;
                }
                
                if (numbers[i] == numbers[i+1])
                {
                    numbers[i] += numbers[i+1];
                    numbers.RemoveAt(i+1);
                    i = -1;
                }
            }
            return numbers;
        }
    }
}
