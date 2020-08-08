using System;

namespace _04.Inch_To_Centimeters_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 5.65765;
            Console.WriteLine(Math.Round(number, 2));
            Console.WriteLine($"{number:F2}");
        }
    }
}
