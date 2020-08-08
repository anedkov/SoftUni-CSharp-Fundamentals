using System;

namespace _04.Magic_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            bool flag = false;
            int counter = 0;
            if (end < start)
            {
                Console.WriteLine("Insert number bigger than start");

            }
            int magicalNumber = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {

                for (int j = start; j <= end; j++)
                {
                    counter++;
                    int sum = i + j;
                    if (sum == magicalNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicalNumber})");
                        flag = true;
                        break;

                    }
                }
                if (flag)
                {
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicalNumber}");
            }
        }
    }
}
