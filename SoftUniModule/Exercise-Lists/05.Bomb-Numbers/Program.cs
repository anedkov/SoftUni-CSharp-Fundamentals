using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int[] bombInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int bombNumber = bombInfo[0];
            int bombPower = bombInfo[1];

            while (true)
            {
                int indexOfBomb = numbers.IndexOf(bombNumber);
                int numbersCount = numbers.Count;
                if (indexOfBomb == -1)
                {
                    break;
                }
                int rightIndex = indexOfBomb + bombPower;
                for (int i = indexOfBomb; i <= rightIndex; i++)
                {
                    if (i < numbersCount)
                    {
                        numbers.RemoveAt(indexOfBomb);

                    }
                    else
                    {
                        break;
                    }
                }
                int leftIndex = indexOfBomb - bombPower;
                for (int i = indexOfBomb - 1; i >= leftIndex; i--)
                {
                    if (i >= 0)
                    {
                        numbers.RemoveAt(i);

                    }
                    else
                    {
                        break;
                    }
                }
            }

            int result = numbers.Sum();

          
            Console.WriteLine(result);

        }
    }
}
