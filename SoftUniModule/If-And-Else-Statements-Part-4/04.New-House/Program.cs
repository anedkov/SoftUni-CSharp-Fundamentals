using System;

namespace _04.New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double singlePrice = 0;
            //крайната цена = броя на цветя * ед цена;

            switch (flowerType)
            {
                case "Roses":
                    singlePrice = 5;
                    break;
                case "Dahlias":
                    singlePrice = 3.8;
                    break;
                case "Tulips":
                    singlePrice = 2.8;
                    break;
                case "Narcissus":
                    singlePrice = 3;
                    break;
                case "Gladiolus":
                    singlePrice = 2.50;
                    break;


                default:
                    break;
            }
            double totalPrice = flowerCount * singlePrice; // намерихме крайната цена

            //отстъпки.. 
            if (flowerCount > 80 && flowerType == "Roses")
            {
                totalPrice = totalPrice - 0.10 * totalPrice; // махаме 10 процента от цената!!!!
            }
            else if (flowerCount > 90 && flowerType == "Dahlias")
            {
                totalPrice = totalPrice - 0.15 * totalPrice;
            }
            else if (flowerCount > 80 && flowerType == "Tulips")
            {
                totalPrice = totalPrice - 0.15 * totalPrice;
            }
            else if (flowerCount < 120 && flowerType == "Narcissus")
            {
                totalPrice = totalPrice + 0.15 * totalPrice; // оскъпяваме с 15 процента към тотал прайз!!!
            }
            else if (flowerCount < 80 && flowerType == "Gladiolus")
            {

                totalPrice = totalPrice + 0.20 * totalPrice;
            }

            if (budget >= totalPrice)
            {
                double left = budget - totalPrice;

                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {left:f2} leva left.");
            }
            else
            {
                double needMoney = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {needMoney:f2} leva more.");

            }
        }
    }
}
