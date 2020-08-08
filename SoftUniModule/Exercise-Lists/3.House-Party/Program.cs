using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTokens = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();


            for (int i = 0; i < numberOfTokens; i++)
            {

                string[] tokens = Console.ReadLine().Split();
                IsGoing(names, tokens);
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

        }

        public static bool IsGoing(List<string> names, string[] token)
        {
            bool checkRequest = false;
            if (token[2] == "going!" && !names.Contains(token[0]))
            {
                names.Add(token[0]);
                checkRequest = true;
            }
            else if (names.Contains(token[0]) && token[2] != "going!")
            {
                names.Remove(token[0]);
            }
            else if (!names.Contains(token[0]) && checkRequest == false)
            {
                Console.WriteLine($"{token[0]} is not in the list!");
            }
            else
            {
                Console.WriteLine($"{token[0]} is already in the list!");
            }




            return checkRequest;
            //Console.WriteLine(string.Join(" ", names));
        }

    }
}
