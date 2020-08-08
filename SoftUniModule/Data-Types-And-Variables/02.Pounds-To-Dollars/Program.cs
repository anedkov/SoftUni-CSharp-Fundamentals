using System;

namespace _02.Pounds_To_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal toDollars = pounds * 1.31M;

            Console.WriteLine($"Dollars: {toDollars:f3}");
        }
    }
}
