using System;

namespace _11.Refactor_Volume_Of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Width: ");
            double width = double.Parse(Console.ReadLine());


            double volume = double.Parse(Console.ReadLine());
            volume = (length + width + volume) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}
