using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string[] token = Console.ReadLine()
                .Split();


            bool isChanged = token[0] == "Add"
                || token[0] == "Remove"
                || token[0] == "RemoveAt"
                || token[0] == "Insert";

            while (token[0] != "end")
            {

                switch (token[0])
                {
                    case "Add":
                        int tokensToAddInt = int.Parse(token[1]);
                        list.Add(tokensToAddInt);

                        break;

                    case "Remove":
                        int tokensToRemoveInt = int.Parse(token[1]);
                        list.Remove(tokensToRemoveInt);

                        break;

                    case "RemoveAt":
                        int tokenToInt = int.Parse(token[1]);
                        list.RemoveAt(tokenToInt);
                        break;

                    case "Insert":
                        int tokensToInt = int.Parse(token[1]);

                        int insertTokenToIndex = int.Parse(token[2]);
                        list.Insert(insertTokenToIndex, tokensToInt);
                        break;

                    case "Contains":

                        int containsNumber = int.Parse(token[1]);

                        if (list.Contains(containsNumber))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;

                    case "PrintEven":
                        PrintEven(list);
                        break;

                    case "PrintOdd":
                        PrintOdd(list);
                        break;

                    case "GetSum":
                        int result = list.Sum();
                        Console.WriteLine(string.Join(" ", result));
                        break;

                    case "Filter":

                        Filter(list, token);
                        
                        break;

                    default:
                        break;
                }


                token = Console.ReadLine().Split();
            }
            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", list));

            }
        }
        static void PrintEven(List<int> onlyEvenNums)
        {

            Console.WriteLine(string.Join(" ", onlyEvenNums.Where((x => x % 2 == 0))));
        }

        static void PrintOdd(List<int> onlyOddNumbers)
        {

            Console.WriteLine(string.Join(" ", onlyOddNumbers.Where((x => x % 2 != 0))));
        }

        static void Filter(List<int> filteredList, string[] token)
        {
            int tokenToInt = int.Parse(token[2]);
            switch (token[1])
            {
                case "<":

                    Console.WriteLine(string.Join(" ", filteredList.Where((x => x < tokenToInt))));

                    break;
                case ">":
                    Console.WriteLine(string.Join(" ", filteredList.Where((x => x > tokenToInt))));
                    break;
                case ">=":
                    Console.WriteLine(string.Join(" ", filteredList.Where((x => x >= tokenToInt))));
                    break;
                case "<=":
                    Console.WriteLine(string.Join(" ", filteredList.Where((x => x <= tokenToInt))));
                    break;

                default:
                    break;
            }
        }

    }
}

