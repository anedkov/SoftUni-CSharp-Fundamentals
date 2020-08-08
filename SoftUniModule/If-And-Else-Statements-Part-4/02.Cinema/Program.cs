
using System;

namespace _02.cinema
{
    class program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double income = 0;

            switch (type)
            {
                case "premiere":
                    income = (rows * columns) * 12.00;

                    break;
                case "normal":

                    income = (rows * columns) * 7.50;


                    break;
                case "discount":

                    income = (rows * columns) * 5.00;

                    break;
                default:
                    Console.WriteLine("error!");
                    break;


            }
            Console.WriteLine("{0:f2} leva", income);
        }
    }
}
