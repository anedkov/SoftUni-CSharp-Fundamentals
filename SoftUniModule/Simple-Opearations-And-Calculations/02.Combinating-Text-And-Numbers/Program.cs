using System;

namespace _02.Combinating_Text_And_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            Console.WriteLine($"You are {name} {lastName}, a {age} - years old person from {town}.");

        }
    }
}
