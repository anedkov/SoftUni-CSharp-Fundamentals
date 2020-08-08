using System;

namespace _10.Lower_Or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char checkingChar = char.Parse(Console.ReadLine());
            bool isUpper = char.IsUpper(checkingChar);
            
            if (isUpper)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
