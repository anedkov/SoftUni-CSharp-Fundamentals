using System;

namespace NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {

                PrintingMatrix(number);
            }
        }

        static void PrintingMatrix(int number)
        {
            int[] row = new int[number];

            for (int i = 0; i < number; i++)
            {
                row[i] += number;
            }
            Console.WriteLine(String.Join(" ", row));

        }
    }
}
