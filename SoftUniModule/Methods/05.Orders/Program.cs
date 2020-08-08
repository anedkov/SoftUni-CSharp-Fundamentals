using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            double coffee = 1.50;
            double water = 1.00;
            double coke = 1.40;
            double snacks = 2.00;
            string typeOfProduct = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            switch (typeOfProduct)
            {
                case "coffee":
                    CoffeTotal(coffee, quantity);
                    break;
                case "water":
                    WaterTotal(water, quantity);
                    break;
                case "coke":
                    CokeTotal(coke, quantity);
                    break;
                case "snacks":
                    SnacksTotal(snacks, quantity);
                    break;

                default:
                    break;
            }
        }
        //coffee – 1.50
        //water – 1.00
        //coke – 1.40
        //snacks – 2.00

        public static void CoffeTotal(double coffee, int quantity)
        {
            double result = coffee * (quantity * 1.0);

            Console.WriteLine($"{result:f2}");
        }

        public static void WaterTotal(double water, int quantity)
        {
            double result = water * (quantity * 1.0);
            Console.WriteLine($"{result:f2}");
        }

        public static void CokeTotal(double coke, int quantity)
        {
            double result = coke * (quantity * 1.0);
            Console.WriteLine($"{result:f2}");
        }

        public static void SnacksTotal(double snacks, int quantity)
        {
            double result = snacks * (quantity * 1.0);
            Console.WriteLine($"{result:f2}");
        }
    }
}
