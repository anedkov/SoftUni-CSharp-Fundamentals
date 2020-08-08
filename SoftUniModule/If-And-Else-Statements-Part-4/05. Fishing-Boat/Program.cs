using System;

namespace _05._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            double rent = 0.00;

            if (season == "Spring")
            {
                rent = 3000.00;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                rent = 4200.00;
            }
            else if (season == "Winter")
            {
                rent = 2600.00;
            }
            if (fishermen <= 6)
            {
                rent = rent * 0.9;
            }
            else if (fishermen >= 7 && fishermen <= 11)
            {
                rent = rent * 0.85;
            }
            else if (fishermen >= 12)
            {
                rent = rent * 0.75;
            }

            if ((fishermen % 2 == 0) && (season == "Spring" || season == "Summer" || season == "Winter"))
            {
                rent = rent * 0.95;
            }

            if (budget > rent)
            {
                double cashLeft = budget - rent;
                Console.WriteLine("Yes! You have {0:f2} leva left.", cashLeft);
            }
            else if (budget < rent)
            {
                double cashNeeded = rent - budget;
                Console.WriteLine("Not enough money! You need {0:f2} leva.", cashNeeded);
            }
        }
    }
}
