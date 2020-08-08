using System;

namespace _09.Chars_To_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var char1 = char.Parse(Console.ReadLine());
            var char2 = char.Parse(Console.ReadLine());
            var char3 = char.Parse(Console.ReadLine());

            Console.WriteLine($"{char1.ToString()} {char2.ToString()} {char3.ToString()}");
        }
    }
}
