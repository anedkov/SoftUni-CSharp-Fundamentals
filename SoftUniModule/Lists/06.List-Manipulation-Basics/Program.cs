using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split()
                .ToList();
            string [] token = Console.ReadLine()
                .Split();

            while (token[0] != "end")
            {
                switch (token[0])
                {
                    case "Add":
                        list.Add(token[1]);
                        break;
                    case "Remove":
                        list.Remove(token[1]);
                        break;
                    case "RemoveAt":
                        int tokenToInt = int.Parse(token[1]);
                        list.RemoveAt(tokenToInt);
                        break;
                    case "Insert":
                        int insertTokenToIndex = int.Parse(token[2]);
                        list.Insert(insertTokenToIndex,token[1]);
                        break;
                    default:
                        break;
                }
                
             
                token = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
