using System;
using System.ComponentModel;

namespace _08.Order_Of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine());
            //3
            //1
            //2
            //3
            // result = min = 1 & max == 3
            int bestMin = int.MaxValue;
            int bestMax = int.MinValue;

            for (int i = 0; i < countNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());

                

                if (number<bestMin)
                {
                    bestMin = number;
                }
                if (number>bestMax)
                {
                    bestMax = number;
                }



            }
            Console.WriteLine($"Max number: {bestMax}"); 
            Console.WriteLine($"Min number: {bestMin}"); 
        }
    }
}
