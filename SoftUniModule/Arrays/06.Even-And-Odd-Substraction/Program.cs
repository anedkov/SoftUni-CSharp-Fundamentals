using System;

namespace _06.Even_And_Odd_Substraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenresult = 0;
            int oddresult = 0;
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenresult += numbers[i];

                }

                else
                {
                    oddresult += numbers[i];
                }

            }

            Console.WriteLine(result = evenresult - oddresult);

        }
    }
}
