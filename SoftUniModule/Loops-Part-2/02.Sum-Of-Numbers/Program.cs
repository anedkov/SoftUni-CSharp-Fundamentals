using System;

namespace _02.Sum_Of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int sum = 0;
            int numbers = 0;
            while (command != "Stop")
            {
                numbers = int.Parse(command);
                sum += numbers;
                command = Console.ReadLine();

            }
            Console.WriteLine(sum);
        }
    }
}
