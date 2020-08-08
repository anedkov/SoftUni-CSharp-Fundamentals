using System;

namespace _11.Smart_Lilly
{
    class Program
    {
        static void Main(string[] args)
        {

            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int moneyFromBirthDays = 0;
            int moneyGift = 10;
            int toysCount = 0; // durji broq na igrachkite za ne chetnite rd

            for (int birthday = 1; birthday <= age; birthday++)
            {
                if (birthday % 2 == 0)
                {
                    moneyFromBirthDays += moneyGift; // kogato vlezem tq veche e na 2 i dobavqme 10 lv
                    moneyGift += 10; // sledvashtiq put koito vlezem shte bude 20 lv ( toest s 10 poveche)
                    moneyFromBirthDays -= 1;
                }
                else
                {
                    toysCount++;

                }
            }
            int moneyFromToys = toysCount * toyPrice;
            moneyFromBirthDays += moneyFromToys;
            double diff = Math.Abs(moneyFromBirthDays - washingMachinePrice);
            if (moneyFromBirthDays >= washingMachinePrice)
            {

                Console.WriteLine($"Yes {diff:F2}");
            }
            else
            {
                Console.WriteLine($"No {diff:F2}");
            }
        }
    }
}
