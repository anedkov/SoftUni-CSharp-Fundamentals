using System;

namespace _04.Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfIncresements = int.Parse(Console.ReadLine());

            int br = 0;
            double total = 0;

            while (br < numOfIncresements)
            {
                double sumToIncrease = double.Parse(Console.ReadLine());


                br++;
                if (sumToIncrease <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                total += sumToIncrease;
                Console.WriteLine($"Increase: {sumToIncrease:f2}");
            }
            Console.WriteLine($"Total: {total:F2}");
        }
    }
}
