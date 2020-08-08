using System;

namespace _07.Swimming_World_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMetters = double.Parse(Console.ReadLine());
            double timeInSecondsForMetter = double.Parse(Console.ReadLine());

            double prepluvaniInSeconds = distanceInMetters * timeInSecondsForMetter; // prepluvani v sekundi

            double delaySec = Math.Floor(distanceInMetters / (double)15); // zabavqneto 
            delaySec *= 12.5;
            double total = prepluvaniInSeconds + delaySec;

            if (total < recordInSeconds)
            {
                double timeMissing = total - recordInSeconds;

                Console.WriteLine($"No, he failed! He was {total:F2} seconds slower");
            }

            else
            {
                double newRecord = recordInSeconds - total;
                Console.WriteLine($"Yes, he succeeded! The new world record is: {total - recordInSeconds:F2} seconds.");
            }
        }
    }
}
