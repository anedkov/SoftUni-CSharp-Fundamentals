using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listToManipulate = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();



            string[] token = Console.ReadLine()
                .Split();

            while (token[0] != "end")
            {


                if (token[0] == "Delete")
                {
                    int tokenToInt = int.Parse(token[1]);
                   
                    listToManipulate.RemoveAll(x=> x == tokenToInt);
                  
                }
                if (token[0] == "Insert")
                {
                    int insertTokenIndex = int.Parse(token[2]);
                    int insertTokenElement = int.Parse(token[1]);
                    listToManipulate.Insert(insertTokenIndex, insertTokenElement);
                }

                token = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", listToManipulate));
        }
    }
}
