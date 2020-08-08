using System;

namespace _04.Inch_To_Cantimaters
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double numberToInch = number * 2.54;

            Console.WriteLine(numberToInch);

        }
    }
}
