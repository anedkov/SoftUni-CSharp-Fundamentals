using System;

namespace _01.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentInput = Console.ReadLine();
            string username = "abc";
            string password = "123";

            while (username != "abc" && password != "123")
            {
                currentInput = Console.ReadLine();
            }

            Console.WriteLine("Welcome Atanas");
        }
    }
}
