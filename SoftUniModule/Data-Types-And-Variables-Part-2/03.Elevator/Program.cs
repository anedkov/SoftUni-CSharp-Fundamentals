using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            int capacity = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Ceiling(numberOfPeople / (double)capacity));


        }
    }
}
