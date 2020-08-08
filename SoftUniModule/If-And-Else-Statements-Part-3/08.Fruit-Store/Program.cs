using System;

namespace _08.Fruit_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFruit = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double price = 0;
            int quantity = int.Parse(Console.ReadLine());
            double smetka;
            if (typeOfFruit == "banana" && dayOfTheWeek == "Monday" || dayOfTheWeek == "Tuesday" || dayOfTheWeek == "Wednesday" || dayOfTheWeek == "Thursday" || dayOfTheWeek == "Friday")
            {
                price = 2.50;
                smetka = price * quantity;
            }
            else if (typeOfFruit == "apple" && dayOfTheWeek == "Monday" || dayOfTheWeek == "Tuesday" || dayOfTheWeek == "Wednesday" || dayOfTheWeek == "Thursday" || dayOfTheWeek == "Friday")
            {
                price = 1.20;
                smetka = price * quantity;
            }

            else if (typeOfFruit == "orange" && dayOfTheWeek == "Monday" || dayOfTheWeek == "Tuesday" || dayOfTheWeek == "Wednesday" || dayOfTheWeek == "Thursday" || dayOfTheWeek == "Friday")
            {
                price = 0.85;
                smetka = price * quantity;
            }
            else if (typeOfFruit == "grapefruit" && dayOfTheWeek == "Monday" || dayOfTheWeek == "Tuesday" || dayOfTheWeek == "Wednesday" || dayOfTheWeek == "Thursday" || dayOfTheWeek == "Friday")
            {
                price = 1.45;
                smetka = price * quantity;
            }
            else if (typeOfFruit == "kiwi" && dayOfTheWeek == "Monday" || dayOfTheWeek == "Tuesday" || dayOfTheWeek == "Wednesday" || dayOfTheWeek == "Thursday" || dayOfTheWeek == "Friday")
            {
                price = 2.70;
                smetka = price * quantity;
            }
            else if (typeOfFruit == "pineapple" && dayOfTheWeek == "Monday" || dayOfTheWeek == "Tuesday" || dayOfTheWeek == "Wednesday" || dayOfTheWeek == "Thursday" || dayOfTheWeek == "Friday")
            {
                price = 5.50;
                smetka = price * quantity;
            }
            else if (typeOfFruit == "grapes" && dayOfTheWeek == "Monday" || dayOfTheWeek == "Tuesday" || dayOfTheWeek == "Wednesday" || dayOfTheWeek == "Thursday" || dayOfTheWeek == "Friday")
            {
                price = 3.85;
                smetka = price * quantity;
            }

            if (dayOfTheWeek == "Saturday" || dayOfTheWeek == "Sunday")
            {
                if (typeOfFruit == "banana")
                {
                    price = 2.70;
                    smetka = price * quantity;
                }
                else if (typeOfFruit == "apple")
                {
                    price = 1.25;
                    smetka = price * quantity;
                }

                else if (typeOfFruit == "orange")
                {
                    price = 0.90;
                    smetka = price * quantity;
                }
                else if (typeOfFruit == "grapefruit")
                {
                    price = 1.60;
                    smetka = price * quantity;
                }
                else if (typeOfFruit == "kiwi")
                {
                    price = 3.00;
                    smetka = price * quantity;
                }
                else if (typeOfFruit == "pineapple")
                {
                    price = 5.60;
                    smetka = price * quantity;
                }
                else if (typeOfFruit == "grapes")
                {
                    price = 4.20;
                    smetka = price * quantity;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
