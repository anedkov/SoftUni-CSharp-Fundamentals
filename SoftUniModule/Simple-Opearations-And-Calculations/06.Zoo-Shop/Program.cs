using System;

namespace _06.Zoo_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            double priceDogs = 2.50;
            int otherAnimals = int.Parse(Console.ReadLine());
            int priceOthers = 4;
            double all = dogs * priceDogs + otherAnimals * priceOthers;

            Console.WriteLine($"{all:F2}" + " lv.");
        }
    }
}
