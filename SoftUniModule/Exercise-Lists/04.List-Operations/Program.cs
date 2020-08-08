using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split()
                .ToList();
            string[] token = Console.ReadLine().Split();

            while (token[0] != "End")
            {
                switch (token[0])
                {
                    case "Shift":
                        if (token[1] == "left")
                        {
                            ShiftLeft(list, token);

                            //shift left <- first number becomes last 'count' times
                        }
                        else if (token[1] == "right")
                        {
                            ShiftRight(list, token);
                            //shift right >- last number becomes first 'count' times
                        }
                        break;

                    case "Add":
                        list.Add(token[1]);
                        break;

                    case "Insert":

                        int tokenIndex = int.Parse(token[2]);

                        if (tokenIndex > list.Count)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }

                        list.Insert(tokenIndex, token[1]);
                        break;

                    case "Remove":
                        int tokenRemoveAtIndex = int.Parse(token[1]);
                        if (tokenRemoveAtIndex > list.Count)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        list.RemoveAt(tokenRemoveAtIndex);
                        break;



                    default:
                        break;
                }

                token = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", list));


            static void ShiftLeft(List<string> list, string[] token)
            {
                int tokenToInt = int.Parse(token[2]);

                if (tokenToInt > list.Count)
                {
                    Console.WriteLine("Invalid index");
                }
                else
                {

                    int index = 0;
                    for (int k = 0; k < tokenToInt; k++)
                    {
                        list.Add(list[0]);
                        list.RemoveAt(index);
                    }


                }

            }

            static void ShiftRight(List<string> list, string[] token)
            {
                int tokenToInt = int.Parse(token[2]);
                if (tokenToInt > list.Count)
                {
                    Console.WriteLine("Invalid index");
                }
                else
                {
                    for (int i = 0; i < tokenToInt; i++)
                    {
                        var lastIndex = list.Last();

                        list.Insert(0, lastIndex);
                        list.RemoveAt(list.Count - 1);


                    }
                }
            }

        }
    }
}