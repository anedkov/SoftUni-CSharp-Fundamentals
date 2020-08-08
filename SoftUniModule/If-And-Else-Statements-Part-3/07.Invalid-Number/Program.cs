using System;

namespace _07.Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int validNumber = int.Parse(Console.ReadLine());

            if (validNumber >= 100 && validNumber <= 200 || validNumber == 0)
            {
                Console.WriteLine("няма изход");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
