using System;

namespace _05.Time_After_15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourinput = int.Parse(Console.ReadLine());
            int minutesInput = int.Parse(Console.ReadLine());
            //convert time to minutes 
            int timeToMinutes = hourinput * 60 + minutesInput;
            //convert time to minutes after 15 
            int timeToMinutesAfter = timeToMinutes + 15;
            //back to hours
            int hoursAfter = timeToMinutesAfter / 60;
            int minutesAfter = timeToMinutesAfter % 60;

            Console.WriteLine($"{hoursAfter}: 0{timeToMinutesAfter}");
        }
    }
}
