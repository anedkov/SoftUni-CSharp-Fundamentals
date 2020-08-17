using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double pari = double.Parse(Console.ReadLine());

            List<int> drums = Console.ReadLine()
                           .Split()
                           .Select(int.Parse)
                           .ToList();

            List<int> initDrums = new List<int>(drums);

            string line = Console.ReadLine();
            while (!line.Equals("Hit it again, Gabsy!"))
            {
                int power = int.Parse(line);

                for (int i = 0; i < drums.Count; i++)
                {
                    drums[i] -= power;

                    if (drums[i] <= 0)
                    {
                        if (initDrums[i] * 3 <= pari)
                        {
                            drums[i] = initDrums[i];
                            pari -= initDrums[i] * 3;
                        }
                        else
                        {
                            drums.RemoveAt(i);
                            initDrums.RemoveAt(i);
                            i--;
                        }
                    }
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", drums));

            Console.WriteLine($"Gabsy has {pari:f2}lv.");
        }
    }
}
