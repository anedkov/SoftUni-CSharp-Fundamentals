using System;

namespace _03.Numbers_From_1_To_N_Through_3_Indexes
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
