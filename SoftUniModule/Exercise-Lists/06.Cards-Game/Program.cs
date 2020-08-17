using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace _06.Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOne = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> playerTwo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            FindWinningHand(playerOne, playerTwo);

        }

        static void FindWinningHand(List<int> p1, List<int> p2)
        {
            while (p1.Count != 0 || p2.Count != 0)
            {

            
                if (p1.Count == 0 || p2.Count == 0)
                {
                    if (p1.Count == 0)
                    {
                        Console.WriteLine($"Second player wins! Sum: {p2.Sum()}");
                    }
                    else
                    {
                        Console.WriteLine($"First player wins! Sum: {p1.Sum()}");
                    }
                    break;
                }
                if (p1[0] > p2[0])
                {
                    p1.Add(p1[0]);
                    p1.Add(p2[0]);
                    p1.RemoveAt(0);
                    p2.RemoveAt(0);
                }
                else if (p2[0] > p1[0])
                {
                    p2.Add(p2[0]);
                    p2.Add(p1[0]);
                    p1.RemoveAt(0);
                    p2.RemoveAt(0);
                }
                else
                {
                    p1.RemoveAt(0);
                    p2.RemoveAt(0);

                }


            }
        }
    }
}
