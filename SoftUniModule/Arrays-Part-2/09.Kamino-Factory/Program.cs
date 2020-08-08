using System;
using System.Linq;

namespace _09.Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dna = int.Parse(Console.ReadLine());

            int[] bestDna = new int[dna];
            int bestStartOfSeq = dna;
            int bestSequenseLenght = 0;
            int bestSum = 0;
            int bestNumber = 0;

            string sampleStr = Console.ReadLine();

            int sampleCounter = 0;

            while (sampleStr != "Clone them!")
            {
                sampleCounter++;

                int[] currendDna = sampleStr
                                      .Split("!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                                      .Select(int.Parse)
                                      .ToArray();

                int currentSum = currendDna.Sum();

                int currentStartOfSequence = 0;
                int currentSequenseLenght = 0;

                for (int i = 0; i < currendDna.Length - 1; i++)
                {
                    int currentStart = i;
                    int currentSequenceLength = 1;

                    for (int j = i + 1; j < currendDna.Length; j++)
                    {
                        if (currendDna[i] == 1 && currendDna[j] == 1)
                        {
                            currentSequenceLength++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (currentSequenceLength > currentSequenseLenght)
                    {
                        currentStartOfSequence = currentStart;
                        currentSequenseLenght = currentSequenceLength;
                    }
                }

                if (currentSequenseLenght > bestSequenseLenght)
                {
                    bestStartOfSeq = currentStartOfSequence;
                    bestSequenseLenght = currentSequenseLenght;
                    bestSum = currentSum;
                    bestDna = currendDna;
                    bestNumber = sampleCounter;
                }
                else if (currentSequenseLenght == bestSequenseLenght)
                {
                    if (currentStartOfSequence < bestStartOfSeq)
                    {
                        bestStartOfSeq = currentStartOfSequence;
                        bestSequenseLenght = currentSequenseLenght;
                        bestSum = currentSum;
                        bestDna = currendDna;
                        bestNumber = sampleCounter;
                    }
                    else if (currentStartOfSequence == bestStartOfSeq)
                    {
                        if (currentSum > bestSum)
                        {
                            bestStartOfSeq = currentStartOfSequence;
                            bestSequenseLenght = currentSequenseLenght;
                            bestSum = currentSum;
                            bestDna = currendDna;
                            bestNumber = sampleCounter;
                        }
                    }
                }

                sampleStr = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestNumber} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestDna));
        
        }
    }
}
