using System;

namespace _06._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string typeOfHoliday = "";
            string destination = "";
            double cost = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    typeOfHoliday = "Camp";
                    cost = budget * 0.3;
                }
                else if (season == "winter")
                {
                    typeOfHoliday = "Hotel";
                    cost = budget * 0.7;

                }



            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    typeOfHoliday = "Camp";
                    cost = budget * 0.4;
                }
                else if (season == "winter")
                {
                    typeOfHoliday = "Hotel";
                    cost = budget * 0.8;
                }
            }
            else
            {
                destination = "Europe";
                typeOfHoliday = "Hotel";
                cost = budget * 0.9;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfHoliday} - {cost:f2}");
        }
    }
}
