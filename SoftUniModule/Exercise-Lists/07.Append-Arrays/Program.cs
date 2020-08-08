﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", Console.ReadLine()
                .Split('|')
                .Reverse()
                .Select(s => string.Join(" ",
                s.Split(new char[] {' '},
                StringSplitOptions.RemoveEmptyEntries)
                ))));
        }
    }
}
