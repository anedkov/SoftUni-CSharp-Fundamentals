using System;

namespace _10.Ski_Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysStaying = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string grade = Console.ReadLine();
            int nights = daysStaying - 1;
            double discount = 0;
            double priceForOneNight = 0;
            double totalPrice = nights * priceForOneNight;
            if (typeOfRoom == "room for one person")
            {
                priceForOneNight = 18.00;
                if (grade == "positive")
                {
                    discount = 0.25;

                }
            }

            else if (typeOfRoom == "apartment")

            {
                priceForOneNight = 25;
                if (daysStaying < 10)
                {
                    discount = 0.30;
                }

                else if (daysStaying >= 10 && daysStaying <= 15)
                {
                    discount = 0.35;
                }
                else if (daysStaying > 15)
                {
                    discount = 0.5;
                }
            }

            else if (typeOfRoom == "president apartment")
            {
                priceForOneNight = 35;
                if (daysStaying < 10)
                {
                    discount = 0.10;
                }
                else if (daysStaying >= 10 && daysStaying <= 15)
                {
                    discount = 0.15;
                }
                else if (daysStaying > 15)
                {
                    discount = 0.2;
                }
            }

            totalPrice = nights * priceForOneNight;

            totalPrice = totalPrice - totalPrice * discount;
            if (grade == "positive")
            {
                totalPrice += totalPrice * 0.25;
            }
            else if (grade == "negative")
            {
                totalPrice -= totalPrice * 0.10;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
