using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._List_Of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());


            List<string> products = new List<string>(numbers);

            for (int i = 0; i < numbers; i++)
            {
                products.Add(Console.ReadLine());
            }

            products.Sort();
            for (int i = 0; i < numbers; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }


    }
}
