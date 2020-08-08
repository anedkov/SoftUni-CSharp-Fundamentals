using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstList = Console.ReadLine()
                                     .Split()
                                     .ToList();
            List<string> secondList = Console.ReadLine()
                                     .Split()
                                     .ToList();

            PrintMergingList(firstList, secondList);
        }

        static void PrintMergingList(List<string> firstList, List<string> secondList)
        {
            List<string> result = new List<string>();

            int count = Math.Max(firstList.Count, secondList.Count);

            for (int i = 0; i < count; i++)
            {
                if (i < firstList.Count)
                {
                    result.Add(firstList[i]);
                }
                if (i < secondList.Count)
                {
                    result.Add(secondList[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
  

