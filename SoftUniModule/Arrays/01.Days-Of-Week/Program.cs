using System;

namespace _01.Days_Of_Week
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] days = new string[] {
                "Monday",
                "Thuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int input = int.Parse(Console.ReadLine());


            while (input < 1 || input > 7)
            {
                Console.WriteLine("Invalid day");
                input = int.Parse(Console.ReadLine());
            }



            Console.WriteLine($"{days[input - 1] }");
        }
    }
}
