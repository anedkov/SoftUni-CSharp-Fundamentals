using System;

namespace _06.Fruit_And_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruitOrNot = Console.ReadLine();

            if (fruitOrNot == "banana" || fruitOrNot == "apple" || fruitOrNot == "kiwi" || fruitOrNot == "cherry" || fruitOrNot == "lemon" || fruitOrNot == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (fruitOrNot == "tomato" || fruitOrNot == "cucumber" || fruitOrNot == "pepper" || fruitOrNot == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknow");
            }
        }
    }
}
