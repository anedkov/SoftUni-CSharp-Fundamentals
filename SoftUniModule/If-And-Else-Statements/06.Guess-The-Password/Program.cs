using System;

namespace _06.Guess_The_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPassword = Console.ReadLine();
            string realPassword = "s3cr3t!P@ssw0rd";

            if (inputPassword == realPassword)
            {
                Console.WriteLine("Welcome");
            }

            else
            {
                Console.WriteLine("Wrong password");
            }
        }
    }
}
