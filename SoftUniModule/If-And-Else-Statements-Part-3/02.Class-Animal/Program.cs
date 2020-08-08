using System;

namespace _02.Class_Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();

            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                    Console.WriteLine("reptile");
                    break;
                case "tortoise":
                    Console.WriteLine("raptile");
                    break;
                case "snake":
                    Console.WriteLine("raptile");
                    break;

                default:
                    Console.WriteLine("unknown");

                    break;
            }
        }
    }
}
