using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacityOfWagons = int.Parse(Console.ReadLine());

            string[] token = Console.ReadLine()
                .Split();

            while (token[0] != "end")
            {
                

                if (token[0] == "Add")
                {
                    int tokenToInt = int.Parse(token[1]);
                    wagons.Add(tokenToInt);
                }
                else
                {
                    int tokenToInt = int.Parse(token[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int curr = wagons[i];

                        if (tokenToInt + curr <= maxCapacityOfWagons)
                        {
                            wagons[i] = tokenToInt + curr;
                            break;
                        }
                      
                    }
                }

                token = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
