using System;

namespace _02.Bonus_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            double bonusPoints = 0;
            if (points <= 100)
            {
                bonusPoints = 5;
            }
            else if (points > 1000)
            {
                bonusPoints = points * 0.1;
            }
            else if (points > 100)
            {
                bonusPoints = points * 0.2;
            }

            // do tuk pravihme proverka za negovata golemina, zatova trqbva da napravim nov if za drugite usloviq
            if (points % 2 == 0)
            {
                bonusPoints += 1;
            }

            else if (points % 10 == 5)
            {
                bonusPoints += 2;
            }
            double total = points + bonusPoints;
            Console.WriteLine(bonusPoints);
            Console.WriteLine(total);

        }
    }
}
