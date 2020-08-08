using System;

namespace _05.Traveling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {

                double needMoney = double.Parse(Console.ReadLine());
                double savedMoney = 0;

                while (savedMoney < needMoney)
                {
                    double currentsavedMoney = double.Parse(Console.ReadLine());
                    savedMoney += currentsavedMoney;
                }
                Console.WriteLine($"Going to {destination}");
                destination = Console.ReadLine();
            }
        }
    }
}
