using System;

namespace _01._Convert_Meters_To_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double metters = double.Parse(Console.ReadLine());
            double toCillometers = metters / 1000;

            Console.WriteLine($"Kilometers: {toCillometers:f2}");
        }
    }
}
