using System;

namespace _02.Numbers_From_N_To_1_Reversed
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = input; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
