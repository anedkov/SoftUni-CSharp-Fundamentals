using System;

namespace _06.Godzilla_Vs._KingKong
{
    class Program
    {
        static void Main(string[] args)
        {
            •	Декорът за филма е на стойност 10 % от бюджета. ->бюджет * 0.2;
            При повече от 150 статиста,  има отстъпка за облеклото на стойност 10 %.


            double budget = double.Parse(Console.ReadLine());
            int countStatists = int.Parse(Console.ReadLine());
            double pricePerStatists = double.Parse(Console.ReadLine());

            double priceDecor = budget * 0.1;
            double priceClothes = countStatists * pricePerStatists;

            if (countStatists > 150)
            {
                priceClothes = priceClothes - 0.10 * priceClothes;
            }

            double total = priceDecor + priceClothes;

            if (total > budget)

            {
                Console.WriteLine("Not enough money");
                double needMoney = total - budget;
                Console.WriteLine($"Wingards needs {needMoney:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                double leftMoney = budget - total;
                Console.WriteLine($"Wingards needs {leftMoney:F2} leva left.");
            }
        }
    }
}
