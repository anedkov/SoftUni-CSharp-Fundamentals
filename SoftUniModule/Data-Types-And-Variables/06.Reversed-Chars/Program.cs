﻿using System;

namespace _06.Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            var char1 = char.Parse(Console.ReadLine());
            var char2 = char.Parse(Console.ReadLine());
            var char3 = char.Parse(Console.ReadLine());

            Console.WriteLine($"{char3}{char2}{char1}");

        }
    }
}
