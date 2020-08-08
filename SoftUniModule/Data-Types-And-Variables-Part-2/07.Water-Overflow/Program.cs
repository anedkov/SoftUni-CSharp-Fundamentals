using System;

namespace _07.Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxCapacityOfTank = 250;
            int numberOfBarrels = int.Parse(Console.ReadLine());
            int capacity = 0;

            for (int i = 0; i < numberOfBarrels; i++)
            {
                int currentCapacity = int.Parse(Console.ReadLine());
                if (capacity + currentCapacity <= maxCapacityOfTank)
                {
                    capacity += currentCapacity;
                }

                else
                {
                    Console.WriteLine("Nedostatuchno Kapacitet");

                }
            }
            Console.WriteLine(capacity);
        }
    }
}
