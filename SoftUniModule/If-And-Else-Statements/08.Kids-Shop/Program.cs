using System;

namespace _08.Kids_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //igrachki
                double puzzle = 2.60;
            double talkingDoll = 3;
            double teddyBear = 4.10;
            double minion = 8.20;
            double truck = 2;
            double discount;

            //vuvejdane na kolichestva + cena za pochivka

            Console.WriteLine("Enter price of hooliday");
            double hooliday = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount of puzzles");
            int amountOfPuzzle = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount of talking dolls");
            int amountOfTalkingDolls = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount of teddybears");
            int amounOfTeddyBears = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount of minions");
            int amountOfMinions = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount of trucks");
            int amountOfTrucks = int.Parse(Console.ReadLine());

            int amountOfOrders = amountOfPuzzle + amountOfTalkingDolls + amounOfTeddyBears + amountOfMinions + amountOfTrucks;


            //vuvejdane na ceni.

            double priceOfPuzzles = amountOfPuzzle * puzzle;
            double priceOfTalkingDolls = amountOfTalkingDolls * talkingDoll;
            double priceOfTeddyBears = amounOfTeddyBears * teddyBear;
            double priceOfMinions = amountOfMinions * minion;
            double priceOfTrucks = amountOfTrucks * truck;
            double wholePrice = priceOfPuzzles + priceOfTalkingDolls + priceOfTeddyBears + priceOfMinions + priceOfTrucks;

            if (amountOfOrders >= 50)
            {

                discount = (wholePrice * 25) / 100;

                wholePrice = wholePrice - discount;
                // wholePrice =( wholePrice * 25) / 100;
            }


            double tax = (wholePrice * 10) / 100;
            double wholeMoney = wholePrice - tax;
            if (wholeMoney >= hooliday)
            {
                double left = wholeMoney - hooliday;
                Console.WriteLine($"Yes! {left:N2} lv. left.");
            }

            else
            {
                double left = wholeMoney - hooliday;
                Console.WriteLine($"Not enough money! {Math.Abs(left):N2} lv. needed");
            }
        }
    }
}
